using System;
using System.Windows.Forms;
using ClinicaDentalApp.Database;
using ClinicaDentalApp.Models;

namespace ClinicaDentalApp.Forms
{
    public partial class RecepcionistasForm : Form
    {
        private readonly RecepcionistaRepository repo = new RecepcionistaRepository();

        public RecepcionistasForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvRecepcionistas.DataSource = repo.GetAll();
                dgvRecepcionistas.Columns["Id_Recepcionista"].Visible = false;
                dgvRecepcionistas.AutoResizeColumns();
            }
            catch
            {
                dgvRecepcionistas.DataSource = new System.Collections.Generic.List<Recepcionista>();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var r = new Recepcionista
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Turno = txtTurno.Text
            };
            try
            {
                repo.Insert(r);
                ClearInputs();
                LoadData();
            }
            catch { MessageBox.Show("No disponible en modo sin conexión."); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvRecepcionistas.CurrentRow == null) return;
            var id = (int)dgvRecepcionistas.CurrentRow.Cells["Id_Recepcionista"].Value;
            var r = new Recepcionista
            {
                Id_Recepcionista = id,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Telefono = txtTelefono.Text,
                Turno = txtTurno.Text
            };
            try
            {
                repo.Update(r);
                ClearInputs();
                LoadData();
            }
            catch { MessageBox.Show("No disponible en modo sin conexión."); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRecepcionistas.CurrentRow == null) return;
            var id = (int)dgvRecepcionistas.CurrentRow.Cells["Id_Recepcionista"].Value;
            if (MessageBox.Show("¿Eliminar recepcionista?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    repo.Delete(id);
                    LoadData();
                }
                catch { MessageBox.Show("No disponible en modo sin conexión."); }
            }
        }

        private void dgvRecepcionistas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRecepcionistas.CurrentRow == null) return;
            txtNombre.Text = dgvRecepcionistas.CurrentRow.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = dgvRecepcionistas.CurrentRow.Cells["Apellido"].Value?.ToString();
            txtTelefono.Text = dgvRecepcionistas.CurrentRow.Cells["Telefono"].Value?.ToString();
            txtTurno.Text = dgvRecepcionistas.CurrentRow.Cells["Turno"].Value?.ToString();
        }

        private void ClearInputs()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtTurno.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();
    }
}
