using System;
using System.Windows.Forms;
using ClinicaDentalApp.Database;
using ClinicaDentalApp.Models;
using System.Collections.Generic;

namespace ClinicaDentalApp.Forms
{
    public partial class TratamientosForm : Form
    {
        private readonly TratamientoRepository repo = new TratamientoRepository();

        public TratamientosForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvTratamientos.DataSource = repo.GetAll();
                dgvTratamientos.Columns["Id_Tratamiento"].Visible = false;
                dgvTratamientos.AutoResizeColumns();
            }
            catch
            {
                dgvTratamientos.DataSource = new List<Tratamiento>();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var t = new Tratamiento
            {
                Descripcion = txtDescripcion.Text,
                Costo = decimal.TryParse(txtCosto.Text, out decimal c) ? c : 0,
                Duracion = txtDuracion.Text,
                Id_Cita = int.TryParse(txtIdCita.Text, out int idc) ? idc : 0
            };
            try
            {
                repo.Insert(t);
                ClearInputs();
                LoadData();
            }
            catch { MessageBox.Show("No disponible en modo sin conexión."); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvTratamientos.CurrentRow == null) return;
            var id = (int)dgvTratamientos.CurrentRow.Cells["Id_Tratamiento"].Value;
            var t = new Tratamiento
            {
                Id_Tratamiento = id,
                Descripcion = txtDescripcion.Text,
                Costo = decimal.TryParse(txtCosto.Text, out decimal c) ? c : 0,
                Duracion = txtDuracion.Text,
                Id_Cita = int.TryParse(txtIdCita.Text, out int idc) ? idc : 0
            };
            try
            {
                repo.Update(t);
                ClearInputs();
                LoadData();
            }
            catch { MessageBox.Show("No disponible en modo sin conexión."); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvTratamientos.CurrentRow == null) return;
            var id = (int)dgvTratamientos.CurrentRow.Cells["Id_Tratamiento"].Value;
            if (MessageBox.Show("¿Eliminar tratamiento?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    repo.Delete(id);
                    LoadData();
                }
                catch { MessageBox.Show("No disponible en modo sin conexión."); }
            }
        }

        private void dgvTratamientos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTratamientos.CurrentRow == null) return;
            txtDescripcion.Text = dgvTratamientos.CurrentRow.Cells["Descripcion"].Value?.ToString();
            txtCosto.Text = dgvTratamientos.CurrentRow.Cells["Costo"].Value?.ToString();
            txtDuracion.Text = dgvTratamientos.CurrentRow.Cells["Duracion"].Value?.ToString();
            txtIdCita.Text = dgvTratamientos.CurrentRow.Cells["Id_Cita"].Value?.ToString();
        }

        private void ClearInputs()
        {
            txtDescripcion.Clear();
            txtCosto.Clear();
            txtDuracion.Clear();
            txtIdCita.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();
    }
}
