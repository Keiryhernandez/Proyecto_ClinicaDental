using System;
using System.Windows.Forms;
using ClinicaDentalApp.Database;
using ClinicaDentalApp.Models;

namespace ClinicaDentalApp.Forms
{
    public partial class DentistasForm : Form
    {
        private readonly DentistaRepository repo = new DentistaRepository();

        public DentistasForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvDentistas.DataSource = repo.GetAll();
                dgvDentistas.Columns["Id_Dentista"].Visible = false;
                dgvDentistas.AutoResizeColumns();
            }
            catch
            {
                dgvDentistas.DataSource = new System.Collections.Generic.List<Dentista>();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var d = new Dentista
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Especialidad = txtEspecialidad.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };
            repo.Insert(d);
            ClearInputs();
            LoadData();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDentistas.CurrentRow == null) return;
            var id = (int)dgvDentistas.CurrentRow.Cells["Id_Dentista"].Value;
            var d = new Dentista
            {
                Id_Dentista = id,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Especialidad = txtEspecialidad.Text,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text
            };
            repo.Update(d);
            ClearInputs();
            LoadData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDentistas.CurrentRow == null) return;
            var id = (int)dgvDentistas.CurrentRow.Cells["Id_Dentista"].Value;
            if (MessageBox.Show("¿Eliminar dentista?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repo.Delete(id);
                LoadData();
            }
        }

        private void dgvDentistas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDentistas.CurrentRow == null) return;
            txtNombre.Text = dgvDentistas.CurrentRow.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = dgvDentistas.CurrentRow.Cells["Apellido"].Value?.ToString();
            txtEspecialidad.Text = dgvDentistas.CurrentRow.Cells["Especialidad"].Value?.ToString();
            txtTelefono.Text = dgvDentistas.CurrentRow.Cells["Telefono"].Value?.ToString();
            txtCorreo.Text = dgvDentistas.CurrentRow.Cells["Correo"].Value?.ToString();
        }

        private void ClearInputs()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEspecialidad.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();
    }
}
