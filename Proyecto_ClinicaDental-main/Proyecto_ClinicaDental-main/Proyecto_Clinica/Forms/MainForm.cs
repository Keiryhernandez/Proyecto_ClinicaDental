using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Clinica.Forms
{
    public partial class MainForm : Form
    {
        private readonly string _rol;
        private Button _botonActivo = null;

        public MainForm(string rol)
        {
            _rol = rol;
            InitializeComponent();
            lblBienvenida.Text = $"Clínica Dental - Rol: {_rol}";
            ConfigurarPermisos();
        }

        private void ConfigurarPermisos()
        {
            // Configurar permisos según el rol
            if (_rol != "Administrador")
            {
                btnRecepcionistas.Enabled = false;
                btnRecepcionistas.ForeColor = Color.Gray;
            }
        }

        private void CambiarColorBoton(Button botonSeleccionado)
        {
            // Restaurar color del botón anterior
            if (_botonActivo != null)
            {
                _botonActivo.BackColor = Color.FromArgb(52, 58, 64);
            }

            // Cambiar color del botón seleccionado
            botonSeleccionado.BackColor = Color.FromArgb(0, 122, 204);
            _botonActivo = botonSeleccionado;
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btnPacientes);
            lblTitulo.Text = "Gestión de Pacientes";
            // Ejemplo de cómo cargar un UserControl (cuando lo crees):
            // CargarUserControl(new PacientesControl());
            MessageBox.Show("Aquí se cargaría el formulario de gestión de Pacientes", 
                          "Pacientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método helper para cargar UserControls dinámicamente
        private void CargarUserControl(UserControl control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
            panelContenido.Controls.Add(lblTitulo);
            lblTitulo.BringToFront();
        }

        private void btnDentistas_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btnDentistas);
            lblTitulo.Text = "Gestión de Dentistas";
            MessageBox.Show("Aquí se cargaría el formulario de gestión de Dentistas", 
                          "Dentistas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecepcionistas_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btnRecepcionistas);
            lblTitulo.Text = "Gestión de Recepcionistas";
            MessageBox.Show("Aquí se cargaría el formulario de gestión de Recepcionistas", 
                          "Recepcionistas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btnCitas);
            lblTitulo.Text = "Gestión de Citas";
            MessageBox.Show("Aquí se cargaría el formulario de gestión de Citas", 
                          "Citas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btnTratamientos);
            lblTitulo.Text = "Gestión de Tratamientos";
            MessageBox.Show("Aquí se cargaría el formulario de gestión de Tratamientos", 
                          "Tratamientos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btnFacturas);
            lblTitulo.Text = "Gestión de Facturas";
            MessageBox.Show("Aquí se cargaría el formulario de gestión de Facturas", 
                          "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHistorialClinico_Click(object sender, EventArgs e)
        {
            CambiarColorBoton(btnHistorialClinico);
            lblTitulo.Text = "Historial Clínico";
            MessageBox.Show("Aquí se cargaría el formulario de Historial Clínico", 
                          "Historial Clínico", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Confirmar cierre de sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
                this.Close();
            }
        }
    }
}
