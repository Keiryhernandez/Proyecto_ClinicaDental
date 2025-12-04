using System;
using System.Windows.Forms;
using ClinicaDentalApp.Database;

namespace ClinicaDentalApp.Forms
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository repo = new UserRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (repo.Login(txtUsuario.Text, txtPass.Text, out string rol))
            {
                MainForm main = new MainForm(rol);
                this.Hide();
                main.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
