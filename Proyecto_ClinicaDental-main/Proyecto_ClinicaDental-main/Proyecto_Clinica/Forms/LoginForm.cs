using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Proyecto_Clinica.Repositorio;

namespace Proyecto_Clinica.Forms
{
    public partial class LoginForm : Form
    {
        private UserRepository _data = new UserRepository();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsername.Text.Trim();
            string clave = txtPassword.Text.Trim();

            if (usuario == "" || clave == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_data.ValidateUser(usuario, clave, out string rol))
            {
                MessageBox.Show($"Bienvenido {usuario}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                var main = new MainForm(rol);
                main.FormClosed += (s, args) => this.Close();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.",
                    "Error de autenticación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    
    }
}
