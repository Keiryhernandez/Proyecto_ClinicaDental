namespace ClinicaDentalApp.Forms
{
    partial class CitasForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();

            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.ShowUpDown = true;

            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtIdPaciente = new System.Windows.Forms.TextBox();
            this.txtIdDentista = new System.Windows.Forms.TextBox();
            this.txtIdRecep = new System.Windows.Forms.TextBox();

            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
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
            this.dgvCitas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCitas.Height = 380;
            this.dgvCitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitas.MultiSelect = false;
            this.dgvCitas.SelectionChanged += new System.EventHandler(this.dgvCitas_SelectionChanged);

            // Inputs
            int xLeft = 20;
            int yTop = 80;
            int gapY = 30;

            this.lblFecha.Text = "Fecha";
            this.lblFecha.Left = xLeft;
            this.lblFecha.Top = yTop;
            this.dtpFecha.Left = xLeft + 80;
            this.dtpFecha.Top = yTop - 3;

            this.lblHora.Text = "Hora";
            this.lblHora.Left = xLeft + 320;
            this.lblHora.Top = yTop;
            this.dtpHora.Left = xLeft + 380;
            this.dtpHora.Top = yTop - 3;

            this.txtMotivo.Left = xLeft + 20;
            this.txtMotivo.Top = yTop + gapY;
            this.txtMotivo.Width = 300;

            this.txtEstado.Left = xLeft + 340;
            this.txtEstado.Top = yTop + gapY;
            this.txtEstado.Width = 180;

            this.txtIdPaciente.Left = xLeft + 20;
            this.txtIdPaciente.Top = yTop + gapY * 2;
            this.txtIdPaciente.Width = 80;

            this.txtIdDentista.Left = xLeft + 120;
            this.txtIdDentista.Top = yTop + gapY * 2;
            this.txtIdDentista.Width = 80;

            this.txtIdRecep.Left = xLeft + 220;
            this.txtIdRecep.Top = yTop + gapY * 2;
            this.txtIdRecep.Width = 80;

            // Add
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvCitas);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.txtIdDentista);
            this.Controls.Add(this.txtIdRecep);

            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.panelTop.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtIdPaciente;
        private System.Windows.Forms.TextBox txtIdDentista;
        private System.Windows.Forms.TextBox txtIdRecep;

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
    }
}
