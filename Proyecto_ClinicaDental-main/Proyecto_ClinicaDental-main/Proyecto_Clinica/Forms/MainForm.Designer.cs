namespace Proyecto_Clinica.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnHistorialClinico = new System.Windows.Forms.Button();
            this.btnFacturas = new System.Windows.Forms.Button();
            this.btnTratamientos = new System.Windows.Forms.Button();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnRecepcionistas = new System.Windows.Forms.Button();
            this.btnDentistas = new System.Windows.Forms.Button();
            this.btnPacientes = new System.Windows.Forms.Button();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panelTop.Controls.Add(this.lblBienvenida);
            this.panelTop.Controls.Add(this.btnCerrarSesion);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1000, 60);
            this.panelTop.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(20, 17);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(238, 25);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Clínica Dental - Sistema";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(865, 15);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(120, 30);
            this.btnCerrarSesion.TabIndex = 1;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnHistorialClinico);
            this.panelMenu.Controls.Add(this.btnFacturas);
            this.panelMenu.Controls.Add(this.btnTratamientos);
            this.panelMenu.Controls.Add(this.btnCitas);
            this.panelMenu.Controls.Add(this.btnRecepcionistas);
            this.panelMenu.Controls.Add(this.btnDentistas);
            this.panelMenu.Controls.Add(this.btnPacientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 60);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 540);
            this.panelMenu.TabIndex = 1;
            // 
            // btnHistorialClinico
            // 
            this.btnHistorialClinico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnHistorialClinico.FlatAppearance.BorderSize = 0;
            this.btnHistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialClinico.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHistorialClinico.ForeColor = System.Drawing.Color.White;
            this.btnHistorialClinico.Location = new System.Drawing.Point(0, 300);
            this.btnHistorialClinico.Name = "btnHistorialClinico";
            this.btnHistorialClinico.Size = new System.Drawing.Size(200, 50);
            this.btnHistorialClinico.TabIndex = 6;
            this.btnHistorialClinico.Text = "📋 Historial Clínico";
            this.btnHistorialClinico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorialClinico.UseVisualStyleBackColor = false;
            this.btnHistorialClinico.Click += new System.EventHandler(this.btnHistorialClinico_Click);
            // 
            // btnFacturas
            // 
            this.btnFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnFacturas.FlatAppearance.BorderSize = 0;
            this.btnFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFacturas.ForeColor = System.Drawing.Color.White;
            this.btnFacturas.Location = new System.Drawing.Point(0, 250);
            this.btnFacturas.Name = "btnFacturas";
            this.btnFacturas.Size = new System.Drawing.Size(200, 50);
            this.btnFacturas.TabIndex = 5;
            this.btnFacturas.Text = "💵 Facturas";
            this.btnFacturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturas.UseVisualStyleBackColor = false;
            this.btnFacturas.Click += new System.EventHandler(this.btnFacturas_Click);
            // 
            // btnTratamientos
            // 
            this.btnTratamientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnTratamientos.FlatAppearance.BorderSize = 0;
            this.btnTratamientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTratamientos.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTratamientos.ForeColor = System.Drawing.Color.White;
            this.btnTratamientos.Location = new System.Drawing.Point(0, 200);
            this.btnTratamientos.Name = "btnTratamientos";
            this.btnTratamientos.Size = new System.Drawing.Size(200, 50);
            this.btnTratamientos.TabIndex = 4;
            this.btnTratamientos.Text = "💊 Tratamientos";
            this.btnTratamientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTratamientos.UseVisualStyleBackColor = false;
            this.btnTratamientos.Click += new System.EventHandler(this.btnTratamientos_Click);
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnCitas.FlatAppearance.BorderSize = 0;
            this.btnCitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCitas.ForeColor = System.Drawing.Color.White;
            this.btnCitas.Location = new System.Drawing.Point(0, 150);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(200, 50);
            this.btnCitas.TabIndex = 3;
            this.btnCitas.Text = "📅 Citas";
            this.btnCitas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnRecepcionistas
            // 
            this.btnRecepcionistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnRecepcionistas.FlatAppearance.BorderSize = 0;
            this.btnRecepcionistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecepcionistas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRecepcionistas.ForeColor = System.Drawing.Color.White;
            this.btnRecepcionistas.Location = new System.Drawing.Point(0, 100);
            this.btnRecepcionistas.Name = "btnRecepcionistas";
            this.btnRecepcionistas.Size = new System.Drawing.Size(200, 50);
            this.btnRecepcionistas.TabIndex = 2;
            this.btnRecepcionistas.Text = "👤 Recepcionistas";
            this.btnRecepcionistas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecepcionistas.UseVisualStyleBackColor = false;
            this.btnRecepcionistas.Click += new System.EventHandler(this.btnRecepcionistas_Click);
            // 
            // btnDentistas
            // 
            this.btnDentistas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnDentistas.FlatAppearance.BorderSize = 0;
            this.btnDentistas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDentistas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDentistas.ForeColor = System.Drawing.Color.White;
            this.btnDentistas.Location = new System.Drawing.Point(0, 50);
            this.btnDentistas.Name = "btnDentistas";
            this.btnDentistas.Size = new System.Drawing.Size(200, 50);
            this.btnDentistas.TabIndex = 1;
            this.btnDentistas.Text = "🦷 Dentistas";
            this.btnDentistas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDentistas.UseVisualStyleBackColor = false;
            this.btnDentistas.Click += new System.EventHandler(this.btnDentistas_Click);
            // 
            // btnPacientes
            // 
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnPacientes.FlatAppearance.BorderSize = 0;
            this.btnPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacientes.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPacientes.ForeColor = System.Drawing.Color.White;
            this.btnPacientes.Location = new System.Drawing.Point(0, 0);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Size = new System.Drawing.Size(200, 50);
            this.btnPacientes.TabIndex = 0;
            this.btnPacientes.Text = "👥 Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.UseVisualStyleBackColor = false;
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelContenido.Controls.Add(this.lblTitulo);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(200, 60);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Padding = new System.Windows.Forms.Padding(20);
            this.panelContenido.Size = new System.Drawing.Size(800, 540);
            this.panelContenido.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblTitulo.Location = new System.Drawing.Point(23, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(520, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Bienvenido al Sistema de Gestión de la Clínica";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.MinimumSize = new System.Drawing.Size(1016, 639);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clínica Dental - Sistema de Gestión";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelContenido.ResumeLayout(false);
            this.panelContenido.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnPacientes;
        private System.Windows.Forms.Button btnDentistas;
        private System.Windows.Forms.Button btnRecepcionistas;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnTratamientos;
        private System.Windows.Forms.Button btnFacturas;
        private System.Windows.Forms.Button btnHistorialClinico;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Label lblTitulo;
    }
}