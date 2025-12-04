namespace ClinicaDentalApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.btnDentistas = new System.Windows.Forms.Button();
            this.btnRecepcionistas = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnTratamientos = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(200)))));
            this.panelHeader.Controls.Add(this.lblTituloApp);
            this.panelHeader.Controls.Add(this.btnCerrar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1277, 70);
            this.panelHeader.TabIndex = 2;
            // 
            // lblTituloApp
            // 
            this.lblTituloApp.AutoSize = true;
            this.lblTituloApp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.ForeColor = System.Drawing.Color.White;
            this.lblTituloApp.Location = new System.Drawing.Point(20, 18);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(351, 41);
            this.lblTituloApp.TabIndex = 0;
            this.lblTituloApp.Text = "Clínica Dental - Sistema";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(2057, 18);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 36);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panelSidebar.Controls.Add(this.btnPacientes);
            this.panelSidebar.Controls.Add(this.btnDentistas);
            this.panelSidebar.Controls.Add(this.btnRecepcionistas);
            this.panelSidebar.Controls.Add(this.btnCitas);
            this.panelSidebar.Controls.Add(this.btnTratamientos);
            this.panelSidebar.Controls.Add(this.btnFacturas);
            this.panelSidebar.Controls.Add(this.btnHistorial);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 70);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(220, 534);
            this.panelSidebar.TabIndex = 1;
            // 
            // btnPacientes
            // 
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Location = new System.Drawing.Point(0, 20);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(220, 50);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "  Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnDentistas
            // 
            this.btnDentistas.FlatAppearance.BorderSize = 0;
            this.btnDentistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDentistas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDentistas.ForeColor = System.Drawing.Color.White;
            this.btnDentistas.Location = new System.Drawing.Point(0, 80);
            this.btnDentistas.Name = "btnDentistas";
            this.btnDentistas.Size = new System.Drawing.Size(220, 50);
            this.btnDentistas.TabIndex = 1;
            this.btnDentistas.Text = "  Dentistas";
            this.btnDentistas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDentistas.Click += new System.EventHandler(this.btnDentistas_Click);
            // 
            // btnRecepcionistas
            // 
            this.btnRecepcionistas.FlatAppearance.BorderSize = 0;
            this.btnRecepcionistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcionistas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRecepcionistas.ForeColor = System.Drawing.Color.White;
            this.btnRecepcionistas.Location = new System.Drawing.Point(0, 140);
            this.btnRecepcionistas.Name = "btnRecepcionistas";
            this.btnRecepcionistas.Size = new System.Drawing.Size(220, 50);
            this.btnRecepcionistas.TabIndex = 2;
            this.btnRecepcionistas.Text = "  Recepcionistas";
            this.btnRecepcionistas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecepcionistas.Click += new System.EventHandler(this.btnRecepcionistas_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.Location = new System.Drawing.Point(0, 200);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(220, 50);
            this.btnCitas.TabIndex = 3;
            this.btnCitas.Text = "  Citas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.FlatAppearance.BorderSize = 0;
            this.btnTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTratamientos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnTratamientos.ForeColor = System.Drawing.Color.White;
            this.btnTratamientos.Location = new System.Drawing.Point(0, 260);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(220, 50);
            this.btnTratamientos.TabIndex = 4;
            this.btnTratamientos.Text = "  Tratamientos";
            this.btnTratamientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Location = new System.Drawing.Point(0, 320);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(220, 50);
            this.btnFacturas.TabIndex = 5;
            this.btnFacturas.Text = "  Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(0, 380);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(220, 50);
            this.btnHistorial.TabIndex = 6;
            this.btnHistorial.Text = "  Historial Clínico";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.lblBienvenida);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(220, 70);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1057, 534);
            this.panelContent.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Location = new System.Drawing.Point(260, 120);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(749, 46);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido al Sistema de Gestión de la Clínica";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1277, 604);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Dental - Sistema de Gestión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnDentistas;
        private System.Windows.Forms.Button btnRecepcionistas;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnTratamientos;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label lblBienvenida;
    }
}
