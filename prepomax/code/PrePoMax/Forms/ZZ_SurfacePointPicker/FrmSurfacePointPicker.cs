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
        private System.Windows.Forms.ListBox lstPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblPointsNumber;

        // Callbacks
        public Action<string> Form_WriteDataToOutput;
        public Action<object, EventArgs> Form_RemoveAnnotations;

        // Para guardado en PMX File
        private CoordPointSet _surfacePoints;

        // Constructors
        public FrmSurfacePointPicker()
        {
            // InitializeComponet();
            _surfacePoints = new CoordPointSet("SurfacePoints");

            this.btnClose = new System.Windows.Forms.Button();
            this.btnPickPoints = new System.Windows.Forms.Button();
            this.lstPoints = new System.Windows.Forms.ListBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblPointsNumber = new System.Windows.Forms.Label();

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

            // lblPoints lblPointsNumber
            this.lblPoints.Text = "Points: ";
            this.lblPoints.Anchor = (
                (System.Windows.Forms.AnchorStyles)
                (
                    (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                )
            );
            this.lblPoints.Size = new System.Drawing.Size(75, 23);
            this.lblPoints.Location = new System.Drawing.Point(26, 65);
            
            this.lblPointsNumber.Text = "0";
            this.lblPointsNumber.Anchor = (
                 (System.Windows.Forms.AnchorStyles)
                 (
                     (System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                 )
             );
            this.lblPointsNumber.Size = new System.Drawing.Size(75, 23);
            this.lblPointsNumber.Location = new System.Drawing.Point(100, 65);

            // lstPoints
            this.lstPoints.Anchor = (
                (System.Windows.Forms.AnchorStyles)
                (
                    System.Windows.Forms.AnchorStyles.Top |
                    System.Windows.Forms.AnchorStyles.Bottom |
                    System.Windows.Forms.AnchorStyles.Left |
                    System.Windows.Forms.AnchorStyles.Right
                )
            );
            this.lstPoints.FormattingEnabled = true;
            this.lstPoints.Location = new System.Drawing.Point(26, 88);
            this.lstPoints.Size = new System.Drawing.Size(200, 140);
            this.lstPoints.HorizontalScrollbar = true;

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
            this.Controls.Add(this.lstPoints);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblPointsNumber);
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
                _surfacePoints = _controller.Model.Mesh.CoordPointSets["SurfacePoints"];
                Highlight(); // Render
            }
            else 
            {
                // Limpia mugrete temp.
                _surfacePoints = new CoordPointSet("SurfacePoints");
            }
            // Actualizar data
            RefreshPointList(); // GUI
            UpdatePointCount(); // GUI
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
            // Supongo que esta función algun dia se usara. Pero por ahora no hace falta `2026-05-19`.
        }

        // Format Text
        private string FormatSurfacePoint(double x, double y, double z) {
            return $"Surface point: {x:F2}, {y:F2}, {z:F2}";
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

        private void RefreshPointList()
        {
            lstPoints.Items.Clear();
            foreach (var point in _surfacePoints.Points) {
                lstPoints.Items.Add( FormatSurfacePoint(point.Coor[0], point.Coor[1], point.Coor[2]) );
            }
        }

        private void UpdatePointCount() 
        {
            lblPointsNumber.Text = $"{lstPoints.Items.Count}";
        }

        // Render
        // Mostrar puntos
        public void Highlight()
        {
            if (_surfacePoints == null) return;
            if (_surfacePoints.Points.Count <= 0) return;

            double[][] points = _surfacePoints.Points.Select(p => p.Coor).ToArray();

            _controller.HighlightNodes(points);
        }

        public void AddSurfacePoint(double[] point)
        {
            if (point == null) return;

            int id = _controller.Model.Mesh.GetNextPointId();
            _surfacePoints.AddPoint(id, point[0], point[1], point[2]);
            
            Form_WriteDataToOutput( FormatSurfacePoint(point[0], point[1], point[2]) );

            // PMX Agregar al model mesh si aun no existe.
            if (!_controller.Model.Mesh.CoordPointSets.ContainsKey(_surfacePoints.Name))
            {
                _controller.Model.Mesh.CoordPointSets.Add( _surfacePoints.Name, _surfacePoints );
            }

            Highlight(); // Render
            RefreshPointList(); // GUI
            UpdatePointCount(); // GUI
        }
    }
}
