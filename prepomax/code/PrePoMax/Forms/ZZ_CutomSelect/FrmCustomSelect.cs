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
        private double[][] _coorLinesToDraw;
        private Controller _controller;
        
        // widget moment
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbItem;
        private UserControls.ListViewWithSelection lvQueries; // Esto ni se necesita pero lo pongo igual
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.Button btnSelectNodes;

        // Callbacks
        public Action<string> Form_WriteDataToOutput; // Para escribir datos en ventana de salida
        public Action<object, EventArgs> Form_RemoveAnnotations;

        // Diccionario almacen de nodos
        private Dictionary<int, FeNode> _selectedNodes = new Dictionary<int, FeNode>();

        // Constructores
        public FrmCustomSelect()
        {
            //InitializeComponent();
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
        /* Esto no se necesita
        private void lvQueries_MouseDown(object sender, MouseEventArgs e)
        {
            lvQueries.SelectedItems.Clear();
        }

        private void lvQueries_MouseUp(object sender, MouseEventArgs e) 
        {
        }
        */
        public void PrepareForm(Controller controller)
        {
            // Preparar controlador para formulario. Con esto seguro guardo cosas en el `pmx`.
            _controller = controller;
            _controller.SetSelectByToOff();
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
                /*
                if (_controller.SelectItem == vtkSelectItem.Element && ids.Length == 1)
                {
                    // NO SE NECESITA SOLO NODOS. Seleccionar un solo elemento. 
                    OneElementPicked(ids[0]);
                }
                else if (_controller.SelectItem == vtkSelectItem.GeometrySurface)
                {
                    // NO SE NECESITA SOLO NODOS. Seleccionar superficie, asumo que cara.
                    SelectionNodeMouse selectionNodeMouse = _controller.Selection.Nodes[0] as SelectionNodeMouse;
                    if (selectionNodeMouse != null)
                    {
                        _controller.Selection.Clear();
                        ids = _controller.GetIdsFromSelectionNodeMouse(selectionNodeMouse);
                        //OneSurfacePicked
                    }
                }
                */
                if (ids.Length == _numOfNodesToSelect)
                {
                    Debug.Print("Paso");
                    // One node
                    if (ids.Length == 1)
                    {
                        Debug.Print("Es un solo nodo");
                        FeNode node = _controller.Model.Mesh.Nodes[ids[0]];
                        _selectedNodes.Add(ids[0], node); // Este puede tronar, porque añado a lo loco.
                        OneNodePicked(ids[0]);
                    }
                    //
                    _controller.ClearSelectionHistoryAndCallSelectionChanged();
                    //
                    Highlight();
                }
            } 
            catch { }
        }

        public void OneNodePicked(int nodeId)
        {
            if (Form_WriteDataToOutput != null)
            {
                string data;
                string lenUnit = _controller.GetLengthUnit();
                string lenUnitInBrackets = string.Format("[{0}]", lenUnit);
                _coorNodesToDraw = new double[_numOfNodesToSelect][];
                //
                Vec3D baseV = new Vec3D(_controller.GetNode(nodeId).Coor);
                // Item name
                string itemName = "Node";
                if (_controller.CurrentView == ViewGeometryModelResults.Geometry) itemName = "Vertex";
                //
                Form_WriteDataToOutput("");
                data = string.Format("{0,16}{1,8}{2,16}{3,16}", itemName.PadRight(16), "[/]", "id:", nodeId);
                Form_WriteDataToOutput(data);
                //
                /*EVITADO. esto por ahora no me importa
                if (_controller.CurrentView == ViewGeometryModelResults.Results) // Tiene que estar en results esto no me sirve.
                {
                    float fieldValue = _controller.GetNodalValue(nodeId);
                    string fieldUnit = "[" + _controller.GetCurrentResultsUnitAbbreviation() + "]";
                    //
                    Vec3D trueScaledV = new Vec3D( _controller.GetScaledNode(1, nodeId).Coor );
                    Vec3D disp = trueScaledV - baseV;
                    //
                    data = string.Format(
                        "{0,16}{1,8}{2,16}{3,16:E}, {4,16:E}, {5,16:E}", 
                        "Deformed".PadRight(16), lenUnitInBrackets, 
                        "x, y, z:", trueScaledV.X, trueScaledV.Y, trueScaledV.Z
                    );
                    Form_WriteDataToOutput(data);
                    data = string.Format(
                        "{0,16}{1,8}{2,16}{3,16:E}, {4,16:E}, {5,16:E}",
                        "Displacement".PadRight(16), lenUnitInBrackets,
                        "x, y, z:", disp.X, disp.Y, disp.Z
                    );
                    Form_WriteDataToOutput(data);
                    data = string.Format(
                        "{0,16}{1,8}{2,16}{3,16:E}", "Field value".PadRight(16), fieldUnit, ":", fieldValue
                    );
                    Form_WriteDataToOutput(data);
                    //
                    float scale = _controller.GetScale();
                    baseV = new Vec3D(_controller.GetScaledNode(scale, nodeId).Coor);
                }
                */
                //
                Form_WriteDataToOutput("Selection with `frmCustomSelect` and Query funcs");
                Form_WriteDataToOutput($"Count of selected nodes: {_selectedNodes.Count}");
                Form_WriteDataToOutput("");
                //
                _coorNodesToDraw[0] = baseV.Coor;
                _coorLinesToDraw = null;
                //
                //_controller.Annotations.AddNodeAnnotation(nodeId); // Dibuja una nota. No me intereza
            }
        }
        
        public void OneElementPicked(int elementId) 
        {
            string itemName = "Element id:";
            if (_controller.CurrentView == ViewGeometryModelResults.Geometry) itemName = "Facet id:";
        }

        // Render
        public void Highlight()
        {
            if (_coorNodesToDraw != null)
            {
                if (_coorNodesToDraw.GetLength(0) == 1)
                {
                    _controller.HighlightNodes(_coorNodesToDraw);
                }
                else if (_coorNodesToDraw.GetLength(0) == 2)
                {
                    _controller.HighlightNodes(_coorNodesToDraw);
                    _controller.HighlightLineWithArrow(_coorNodesToDraw[0], _coorNodesToDraw[1], true, true, false, 1);
                }
                else if (_coorNodesToDraw.GetLength(0) > 2)
                {
                    _controller.HighlightNodes(_coorNodesToDraw);
                    _controller.HighlightConnectedLines(_coorLinesToDraw);
                }
            }
        }

    }
}
