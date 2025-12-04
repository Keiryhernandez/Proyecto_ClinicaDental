using System;
using System.Linq;
using System.Windows.Forms;
using ClinicaDentalApp.Database;
using ClinicaDentalApp.Models;
using System.Collections.Generic;

namespace ClinicaDentalApp.Forms
{
    public partial class CitasForm : Form
    {
        private readonly CitaRepository repo = new CitaRepository();

        public CitasForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvCitas.DataSource = repo.GetAll();
                dgvCitas.Columns["Id_Cita"].Visible = false;
                dgvCitas.AutoResizeColumns();
            }
            catch
            {
                dgvCitas.DataSource = new List<Cita>();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var c = new Cita
            {
                Fecha = dtpFecha.Value.Date,
                Hora = new TimeSpan(dtpHora.Value.Hour, dtpHora.Value.Minute, 0),
                Motivo = txtMotivo.Text,
                Estado = txtEstado.Text,
                Id_Paciente = int.TryParse(txtIdPaciente.Text, out int pid) ? pid : 0,
                Id_Dentista = int.TryParse(txtIdDentista.Text, out int did) ? did : 0,
                Id_Recepcionista = int.TryParse(txtIdRecep.Text, out int rid) ? rid : 0
            };
            try
            {
                repo.Insert(c);
                ClearInputs();
                LoadData();
            }
            catch { MessageBox.Show("No disponible en modo sin conexión."); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null) return;
            var id = (int)dgvCitas.CurrentRow.Cells["Id_Cita"].Value;
            var c = new Cita
            {
                Id_Cita = id,
                Fecha = dtpFecha.Value.Date,
                Hora = new TimeSpan(dtpHora.Value.Hour, dtpHora.Value.Minute, 0),
                Motivo = txtMotivo.Text,
                Estado = txtEstado.Text,
                Id_Paciente = int.TryParse(txtIdPaciente.Text, out int pid) ? pid : 0,
                Id_Dentista = int.TryParse(txtIdDentista.Text, out int did) ? did : 0,
                Id_Recepcionista = int.TryParse(txtIdRecep.Text, out int rid) ? rid : 0
            };
            try
            {
                repo.Update(c);
                ClearInputs();
                LoadData();
            }
            catch { MessageBox.Show("No disponible en modo sin conexión."); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null) return;
            var id = (int)dgvCitas.CurrentRow.Cells["Id_Cita"].Value;
            if (MessageBox.Show("¿Eliminar cita?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    repo.Delete(id);
                    LoadData();
                }
                catch { MessageBox.Show("No disponible en modo sin conexión."); }
            }
        }

        private void dgvCitas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCitas.CurrentRow == null) return;
            dtpFecha.Value = Convert.ToDateTime(dgvCitas.CurrentRow.Cells["Fecha"].Value);
            var hora = (TimeSpan)dgvCitas.CurrentRow.Cells["Hora"].Value;
            dtpHora.Value = DateTime.Today.Add(hora);
            txtMotivo.Text = dgvCitas.CurrentRow.Cells["Motivo"].Value?.ToString();
            txtEstado.Text = dgvCitas.CurrentRow.Cells["Estado"].Value?.ToString();
            txtIdPaciente.Text = dgvCitas.CurrentRow.Cells["Id_Paciente"].Value?.ToString();
            txtIdDentista.Text = dgvCitas.CurrentRow.Cells["Id_Dentista"].Value?.ToString();
            txtIdRecep.Text = dgvCitas.CurrentRow.Cells["Id_Recepcionista"].Value?.ToString();
        }

        private void ClearInputs()
        {
            dtpFecha.Value = DateTime.Today;
            dtpHora.Value = DateTime.Today;
            txtMotivo.Clear();
            txtEstado.Clear();
            txtIdPaciente.Clear();
            txtIdDentista.Clear();
            txtIdRecep.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();
    }
}
