namespace ClinicaDentalApp.Forms
{
    partial class FacturasForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();

            this.dtpFecha = new System.Windows.Forms.DateTimePicker();

            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtMetodo = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.txtIdTratamiento = new System.Windows.Forms.TextBox();

            this.lblFecha = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
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
            this.dgvFacturas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvFacturas.Height = 380;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.SelectionChanged += new System.EventHandler(this.dgvFacturas_SelectionChanged);

            // Inputs
            int xLeft = 20;
            int yTop = 80;
            int gapY = 30;

            this.lblFecha.Text = "Fecha";
            this.lblFecha.Left = xLeft;
            this.lblFecha.Top = yTop;
            this.dtpFecha.Left = xLeft + 80;
            this.dtpFecha.Top = yTop - 3;

            this.txtMonto.Left = xLeft + 20;
            this.txtMonto.Top = yTop + gapY;
            this.txtMonto.Width = 120;

            this.txtMetodo.Left = xLeft + 160;
            this.txtMetodo.Top = yTop + gapY;
            this.txtMetodo.Width = 120;

            this.txtIdPaciente.Left = xLeft + 300;
            this.txtIdPaciente.Top = yTop + gapY;
            this.txtIdPaciente.Width = 80;

            this.txtIdTratamiento.Left = xLeft + 400;
            this.txtIdTratamiento.Top = yTop + gapY;
            this.txtIdTratamiento.Width = 80;

            // Add
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtMetodo);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtIdTratamiento);

            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.panelTop.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtMetodo;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.TextBox txtIdTratamiento;

        private System.Windows.Forms.Label lblFecha;
    }
}
