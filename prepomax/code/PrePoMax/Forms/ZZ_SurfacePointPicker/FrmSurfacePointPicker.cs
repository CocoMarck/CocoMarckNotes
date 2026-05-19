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

namespace PrePoMax.Forms
{
    public partial class FrmSurfacePointPicker : UserControls.PrePoMaxChildForm
    {
        /*
        Este formulario es para la seleccion de cualquier punto de la superficie de un modelo.
        */

        // Variables
        private Controller _controller;

        // Widgets
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPickPoints;

        // Callbacks
        public Action<string> Form_WriteDataToOutput;
        public Action<object, EventArgs> Form_RemoveAnnotations;

        // Para guardado en PMX File
        private CoordPointSet _coordPointSet;

        // Constructors
        public FrmSurfacePointPicker()
        {
            // InitializeComponet();
            _coordPointSet = new CoordPointSet("SurfacePoints");

            this.btnClose = new System.Windows.Forms.Button();
            this.btnPickPoints = new System.Windows.Forms.Button();

            // btnClose
            this.btnClose.Name = "btnClose";
            this.btnClose.Text = "Close";
            this.btnClose.Anchor = (
                (System.Windows.Forms.AnchorStyles)
                (
                    (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)
                )
            );
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Location = new System.Drawing.Point(26, 256 - 26);
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // btnPickPoint
            this.btnPickPoints.Name = "btnPickPoints";
            this.btnPickPoints.Text = "Pick Points";
            this.btnPickPoints.Anchor = (
                (System.Windows.Forms.AnchorStyles)
                (
                    (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                )
            );
            this.btnPickPoints.Size = new System.Drawing.Size(75, 23);
            this.btnPickPoints.Location = new System.Drawing.Point(26, 26);
            this.btnPickPoints.Click += new System.EventHandler(this.btnPickPoints_Click);

            // FrmSurfacePointPicker
            this.Text = "Surface Point Picker";
            this.Name = "FrmSurfacePointPicker";
            this.ClientSize = new System.Drawing.Size(256, 256);
            this.CancelButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSurfacePointPicker_FormClosing);
            this.VisibleChanged += new System.EventHandler(this.FrmSurfacePointPicker_VisibleChanged);
            this.SuspendLayout();
            this.ResumeLayout(false);

            // Agregar widget
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPickPoints);
        }

        // Eventos principales
        public void PrepareForm(Controller controller)
        {
            // Controler
            _controller = controller;
            _controller.SetSelectByToOff();

            // PMX | Intentar obtener data.
            if (_controller.Model.Mesh.CoordPointSets.ContainsKey("SurfacePoints"))
            {
                _coordPointSet = _controller.Model.Mesh.CoordPointSets["SurfacePoints"];
                Highlight();
            }
        }

        public void RemoveMeasureAnnotation()
        {
            _controller.Annotations.RemoveCurrentMeasureAnnotation();
        }

        private void FrmSurfacePointPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Esto si no se que es. Parece que es forzar ocultado de form.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void FrmSurfacePointPicker_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                return;
            }
            // Cuando el formulario esta oculto
            else
            {
                return;
            }
        }

        public void PickedCoords(List<double[]> coords)
        {
            // Supongo que esta algun dia se usara. Pero por ahora no hace falta `2026-05-19`.
        }

        // Widgets
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnPickPoints_Click(object sender, EventArgs e)
        {
            _controller.SelectBy = vtkSelectBy.SurfacePoint;
            _controller.Selection.SelectItem = vtkSelectItem.SurfacePoint;
        }

        // Render
        // Mostrar puntos
        public void Highlight()
        {
            if (_coordPointSet == null) return;
            if (_coordPointSet.Points.Count <= 0) return;

            double[][] points = _coordPointSet.Points.
                Select(p => p.Coor).ToArray();

            _controller.HighlightNodes(points);
        }

        public void AddSurfacePoint(double[] point)
        {
            if (point == null) return;

            int id = _controller.Model.Mesh.GetNextPointId();
            _coordPointSet.AddPoint(id, point[0], point[1], point[2]);

            Form_WriteDataToOutput($"Surface point: {point[0]}, {point[1]}, {point[2]}");

            // PMX Agregar al model mesh si aun no existe.
            if (!_controller.Model.Mesh.CoordPointSets.ContainsKey(_coordPointSet.Name))
            {
                _controller.Model.Mesh.CoordPointSets.Add( _coordPointSet.Name, _coordPointSet );
            }

            Highlight();
        }
    }
}
