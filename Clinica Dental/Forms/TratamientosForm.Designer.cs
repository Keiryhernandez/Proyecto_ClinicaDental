namespace ClinicaDentalApp.Forms
{
    partial class TratamientosForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvTratamientos = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();

            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.txtIdCita = new System.Windows.Forms.TextBox();

            this.lblDescripcion = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // panelTop & buttons
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 60;
            this.panelTop.Controls.Add(this.btnNuevo);
            this.panelTop.Controls.Add(this.btnEditar);
            this.panelTop.Controls.Add(this.btnEliminar);
            this.panelTop.Controls.Add(this.btnRefrescar);

            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Left = 10;
            this.btnNuevo.Top = 10;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);

            this.btnEditar.Text = "Guardar";
            this.btnEditar.Left = 100;
            this.btnEditar.Top = 10;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);

            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Left = 200;
            this.btnEliminar.Top = 10;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.Left = 300;
            this.btnRefrescar.Top = 10;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);

            // DataGridView
            this.dgvTratamientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTratamientos.Height = 380;
            this.dgvTratamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTratamientos.MultiSelect = false;
            this.dgvTratamientos.SelectionChanged += new System.EventHandler(this.dgvTratamientos_SelectionChanged);

            // Inputs
            int xLeft = 20;
            int yTop = 80;
            int gapY = 30;

            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.Left = xLeft;
            this.lblDescripcion.Top = yTop;
            this.txtDescripcion.Left = xLeft + 100;
            this.txtDescripcion.Top = yTop - 3;
            this.txtDescripcion.Width = 400;

            this.txtCosto.Left = xLeft + 20;
            this.txtCosto.Top = yTop + gapY;
            this.txtCosto.Width = 120;

            this.txtDuracion.Left = xLeft + 160;
            this.txtDuracion.Top = yTop + gapY;
            this.txtDuracion.Width = 120;

            this.txtIdCita.Left = xLeft + 300;
            this.txtIdCita.Top = yTop + gapY;
            this.txtIdCita.Width = 80;

            // Add controls
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvTratamientos);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.txtIdCita);

            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTratamientos)).EndInit();
            this.panelTop.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvTratamientos;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.TextBox txtIdCita;

        private System.Windows.Forms.Label lblDescripcion;
    }
}
