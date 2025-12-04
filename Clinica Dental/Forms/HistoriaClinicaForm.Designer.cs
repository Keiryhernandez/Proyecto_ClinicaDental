namespace ClinicaDentalApp.Forms
{
    partial class HistoriaClinicaForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvHistoria = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();

            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.txtIdDentista = new System.Windows.Forms.TextBox();

            this.lblDiagnostico = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).BeginInit();
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
            this.dgvHistoria.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHistoria.Height = 380;
            this.dgvHistoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoria.MultiSelect = false;
            this.dgvHistoria.SelectionChanged += new System.EventHandler(this.dgvHistoria_SelectionChanged);

            // Inputs
            int xLeft = 20;
            int yTop = 80;
            int gapY = 30;

            this.lblDiagnostico.Text = "Diagnóstico";
            this.lblDiagnostico.Left = xLeft;
            this.lblDiagnostico.Top = yTop;
            this.txtDiagnostico.Left = xLeft + 100;
            this.txtDiagnostico.Top = yTop - 3;
            this.txtDiagnostico.Width = 400;

            this.txtObservaciones.Left = xLeft + 20;
            this.txtObservaciones.Top = yTop + gapY;
            this.txtObservaciones.Width = 600;

            this.txtIdPaciente.Left = xLeft + 20;
            this.txtIdPaciente.Top = yTop + gapY * 2;
            this.txtIdPaciente.Width = 80;

            this.txtIdDentista.Left = xLeft + 120;
            this.txtIdDentista.Top = yTop + gapY * 2;
            this.txtIdDentista.Width = 80;

            // Add
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvHistoria);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtIdDentista);

            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoria)).EndInit();
            this.panelTop.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvHistoria;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;

        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.TextBox txtIdDentista;

        private System.Windows.Forms.Label lblDiagnostico;
    }
}
