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

        // Surface points
        private List<double[]> _surfacePoints;

        // Constructors
        public FrmSurfacePointPicker()
        {
            // InitializeComponet();
            _surfacePoints = new List<double[]>();

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

        public void PickedIds(int[] ids)
        {
            MessageBox.Show($"{ids}");
        }

        // Widgets
        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnPickPoints_Click(object sender, EventArgs e)
        {
            _controller.SelectBy = vtkSelectBy.Node;
            _controller.Selection.SelectItem = vtkSelectItem.Node;
        }

        // Render
        // Mostrar puntos
        public void Hightlight()
        {
            if (_surfacePoints == null) return;
            if (_surfacePoints.Count <= 0) return;

            double[][] points = _surfacePoints.ToArray();

            _controller.HighlightNodes(points);
        }

        public void AddSurfacePoint(double[] point)
        {
            if (point == null) return;

            _surfacePoints.Add(point);

            Form_WriteDataToOutput($"Surface point: {point[0]}, {point[1]}, {point[2]}");

            Hightlight();
        }
    }
}
