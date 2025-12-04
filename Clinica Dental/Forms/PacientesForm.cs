using ClinicaDentalApp.Database;
using ClinicaDentalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaDentalApp.Forms
{
    public partial class PacientesForm : Form
    {
        private readonly PacienteRepository repo = new PacienteRepository();

        public PacientesForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvPacientes.DataSource = repo.GetAll();
                dgvPacientes.Columns["Id_Paciente"].Visible = false;
                dgvPacientes.AutoResizeColumns();
            }
            catch
            {
                dgvPacientes.DataSource = new List<Paciente>();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var p = new Paciente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = int.TryParse(txtEdad.Text, out int ed) ? ed : (int?)null,
                Genero = txtGenero.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text
            };
            repo.Insert(p);
            ClearInputs();
            LoadData();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null) return;
            var id = (int)dgvPacientes.CurrentRow.Cells["Id_Paciente"].Value;
            var p = new Paciente
            {
                Id_Paciente = id,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = int.TryParse(txtEdad.Text, out int ed) ? ed : (int?)null,
                Genero = txtGenero.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Correo = txtCorreo.Text
            };
            repo.Update(p);
            ClearInputs();
            LoadData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null) return;
            var id = (int)dgvPacientes.CurrentRow.Cells["Id_Paciente"].Value;
            var r = MessageBox.Show("¿Eliminar paciente?", "Confirmar", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                repo.Delete(id);
                LoadData();
            }
        }

        private void dgvPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPacientes.CurrentRow == null) return;
            txtNombre.Text = dgvPacientes.CurrentRow.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = dgvPacientes.CurrentRow.Cells["Apellido"].Value?.ToString();
            txtEdad.Text = dgvPacientes.CurrentRow.Cells["Edad"].Value?.ToString();
            txtGenero.Text = dgvPacientes.CurrentRow.Cells["Genero"].Value?.ToString();
            txtTelefono.Text = dgvPacientes.CurrentRow.Cells["Telefono"].Value?.ToString();
            txtDireccion.Text = dgvPacientes.CurrentRow.Cells["Direccion"].Value?.ToString();
            txtCorreo.Text = dgvPacientes.CurrentRow.Cells["Correo"].Value?.ToString();
        }

        private void ClearInputs()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtGenero.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();
    }
}

