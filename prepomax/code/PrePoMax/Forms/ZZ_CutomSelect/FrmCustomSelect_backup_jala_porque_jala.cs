using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaeGlobals;
using CaeMesh;

// custom select form
namespace PrePoMax.Forms
{
    public partial class FrmCustomSelect : UserControls.PrePoMaxChildForm//, IFormHighlight
    {
        /*
        Este formulario no esta 100% estructurado like PrePoMax project. Pero funiciona. La obtención de IDs de nodos, se hace desde el ´FrmMain.cs´. Aca solo se reciven datos.

        Aca solo se quiere seleccionar nodos.
        */ 
        // Variables
        private int _numOfNodesToSelect;
        private double[][] _coorNodesToDraw;
        private Controller _controller;
        
        // widget moment
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbItem;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Button btnSelectNodes;

        // Callbacks
        public Action<string> Form_WriteDataToOutput; // Para escribir datos en ventana de salida
        public Action<object, EventArgs> Form_RemoveAnnotations;

        // Para guardado en PMX file
        private FeNodeSet _customNodeSet;

        // Constructores
        public FrmCustomSelect()
        {
            //InitializeComponent();
            // |
            // V

            // PMX FeNodeSet
            _customNodeSet = new FeNodeSet("CustomSelection", null);

            _numOfNodesToSelect = 1; // Es implicito, es la cantidad de nodos a seleccionar. De uno por uno es lo acertado. Es posible que sea mejor eliminar esta logic, porque igual solo se necesitara seleccionar nodos, a lo mucho nomas bordes. Edges.

            this.btnClose = new System.Windows.Forms.Button();
            this.btnSelectNodes = new System.Windows.Forms.Button();
            
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));

            this.gbItem = new System.Windows.Forms.GroupBox(); // Items locos
            this.gbItem.SuspendLayout();
            this.SuspendLayout();

            /*
            btnClose
            Boton cerrar. Anchor, establece la posición del widget. Name es para backend, y Text es para front.
            Point para coordenadas `xy`. Y Size, pos el tamaño.
            */
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "Close";
            this.btnClose.Anchor = (
                (System.Windows.Forms.AnchorStyles)
                (
                    (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)
                )
            );
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Location = new System.Drawing.Point(26, 256-25);
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            /*
            btnSelectNodes
            */
            this.btnSelectNodes.Name = "btnSelectNodes";
            this.btnSelectNodes.Text = "Select nodes";
            this.btnSelectNodes.Anchor = (
                (System.Windows.Forms.AnchorStyles)
                (
                    (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                )
            );
            this.btnSelectNodes.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNodes.Click += new System.EventHandler(this.btnSelectNodes_Click);

            /*
            FrmCustomSelect
            Atributos del formulario/ventana. ClientSize es tamaño de ventana
            */
            this.Text = "Custom Select";
            this.Name = "FrmCustomSelect";
            this.ClientSize = new System.Drawing.Size(256, 256);
            this.CancelButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomSelect_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FrmCustomSelect_VisibleChanged);
            this.ResumeLayout(false);

            // Agregar widgets
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSelectNodes);
        }

        // Eventos principales. Creo que si o si metodos de interface `IFormHighlight`
        public void PrepareForm(Controller controller)
        {
            // Preparar controlador para formulario. Con esto seguro guardo cosas en el `pmx`.
            _controller = controller;
            _controller.SetSelectByToOff();

            // PMX | Intentar recuperar NodeSet guardado
            if (_controller.Model.Mesh.NodeSets.ContainsKey("CustomSelection"))
            {
                _customNodeSet = _controller.Model.Mesh.NodeSets["CustomSelection"];

                DrawDataOfSelectedNodes();
                Highlight();

                Debug.WriteLine("CustomSelection cargado desde PMX");
            }
        }
        private void FrmCustomSelect_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Esto si no se que es. Parece que es forzar cerrado.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void FrmCustomSelect_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                _controller.SetQuerySelection(true);
            }
            // Cuando el formulario esta oculto
            else
            {
                _controller.SelectBy = vtkSelectBy.Default;
                // Clear
                RemoveMeasureAnnotation();
                _controller.ClearSelectionHistoryAndCallSelectionChanged();
                //
                _controller.SetQuerySelection(false);
            }
        }

        public void RemoveMeasureAnnotation() 
        {
            _controller.Annotations.RemoveCurrentMeasureAnnotation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana. Bueno en realidad solo la oculta.
            Hide();
        }

        private void btnSelectNodes_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Mensaje en lugar de seleccionar nodos");
            _controller.SelectBy = vtkSelectBy.Node;
            _controller.Selection.SelectItem = vtkSelectItem.Node;

            // Clear
            RemoveMeasureAnnotation();
            _controller.ClearSelectionHistoryAndCallSelectionChanged();
        }

        // Eventos relacionados con seleccion de nodos
        public void PickedIds(int[] ids)
        {
            try
            {
                RemoveMeasureAnnotation(); // Limpiar anotaciones
                //
                Debug.Print($"Identificadores: {ids.Length}");
                if (ids == null || ids.Length == 0) return;
                //
                if (ids.Length == _numOfNodesToSelect)
                {
                    Debug.Print("Paso");
                    // One node
                    if (ids.Length == 1)
                    {
                        Debug.Print("Es un solo nodo");
                        //FeNode node = _controller.Model.Mesh.Nodes[ids[0]];

                        // PMX FeNodeSet
                        SelectionChanged(ids);
                        DrawDataOfSelectedNodes();
                    }
                    //
                    _controller.ClearSelectionHistoryAndCallSelectionChanged();
                    //
                    Highlight();
                }
            } 
            catch { }
        }

        // PMX 
        public void DrawDataOfSelectedNodes()
        {
            if (_customNodeSet.Labels == null || _customNodeSet.Labels.Length == 0)
                return;

            _coorNodesToDraw = new double[_customNodeSet.Labels.Length][];

            for (int i = 0; i < _customNodeSet.Labels.Length; i++)
            {
                int nodeId = _customNodeSet.Labels[i];

                FeNode node = _controller.Model.Mesh.Nodes[nodeId];

                _coorNodesToDraw[i] = node.Coor;
            }

            // Message
            Form_WriteDataToOutput("Selection with `frmCustomSelect`");
            Form_WriteDataToOutput($"Count of selected nodes: {_customNodeSet.Labels.Length}");
        }

        // Render
        public void Highlight()
        {
            if (_coorNodesToDraw != null)
            {
                _controller.HighlightNodes(_coorNodesToDraw);
            }
        }

        // PMX FeNodeSet
        public void SelectionChanged(int[] ids)
        {
            // Ids unicos
            HashSet<int> uniqueIds;

            if (_customNodeSet.Labels != null)
            {
                uniqueIds = new HashSet<int>(_customNodeSet.Labels);
            }
            else
            {
                uniqueIds = new HashSet<int>();
            }

            foreach (int id in ids)
            {
                uniqueIds.Add(id);
            }

            // Obtener data
            _customNodeSet.Labels = uniqueIds.ToArray();
            _customNodeSet.CreationData = _controller.Selection.DeepClone();
            _controller.GetNodesCenterOfGravity(_customNodeSet);

            // Agregar al modelo si aún no existe
            if (!_controller.Model.Mesh.NodeSets.ContainsKey(_customNodeSet.Name))
            {
                _controller.Model.Mesh.NodeSets.Add(
                    _customNodeSet.Name,
                    _customNodeSet
                );
                Debug.WriteLine(_controller.Model.Mesh.NodeSets.Count);
                foreach (var item in _controller.Model.Mesh.NodeSets)
                {
                    Debug.WriteLine(item.Key);
                }
            }
        }

    }
}
