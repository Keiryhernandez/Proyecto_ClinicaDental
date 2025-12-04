namespace ClinicaDentalApp.Forms
{
    partial class DentistasForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.dgvDentistas = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();

            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvDentistas)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // panelTop & buttons (same positions as Pacientes)
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
            this.dgvDentistas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDentistas.Height = 400;
            this.dgvDentistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDentistas.MultiSelect = false;
            this.dgvDentistas.SelectionChanged += new System.EventHandler(this.dgvDentistas_SelectionChanged);

            // Inputs
            int xLeft = 20;
            int yTop = 80;
            int width = 220;
            int gapY = 30;

            this.lblNombre.Text = "Nombre";
            this.lblNombre.Left = xLeft;
            this.lblNombre.Top = yTop;
            this.txtNombre.Left = xLeft + 80;
            this.txtNombre.Top = yTop - 3;
            this.txtNombre.Width = width;

            this.lblApellido.Text = "Apellido";
            this.lblApellido.Left = xLeft;
            this.lblApellido.Top = yTop + gapY;
            this.txtApellido.Left = xLeft + 80;
            this.txtApellido.Top = yTop + gapY - 3;
            this.txtApellido.Width = width;

            this.txtEspecialidad.Left = xLeft + 320;
            this.txtEspecialidad.Top = yTop - 3;
            this.txtEspecialidad.Width = 180;

            this.txtTelefono.Left = xLeft + 20;
            this.txtTelefono.Top = yTop + gapY * 2;
            this.txtTelefono.Width = 200;

            this.txtCorreo.Left = xLeft + 240;
            this.txtCorreo.Top = yTop + gapY * 2;
            this.txtCorreo.Width = 300;

            // Add controls
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.dgvDentistas);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtCorreo);

            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDentistas)).EndInit();
            this.panelTop.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvDentistas;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRefrescar;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
    }
}
