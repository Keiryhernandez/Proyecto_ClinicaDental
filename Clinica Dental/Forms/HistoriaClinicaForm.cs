using System;
using System.Windows.Forms;
using ClinicaDentalApp.Database;
using ClinicaDentalApp.Models;
using System.Collections.Generic;

namespace ClinicaDentalApp.Forms
{
    public partial class HistoriaClinicaForm : Form
    {
        private readonly HistoriaRepository repo = new HistoriaRepository();

        public HistoriaClinicaForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvHistoria.DataSource = repo.GetAll();
                dgvHistoria.Columns["Id_Historia"].Visible = false;
                dgvHistoria.AutoResizeColumns();
            }
            catch
            {
                dgvHistoria.DataSource = new List<HistoriaClinica>();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var h = new HistoriaClinica
            {
                Diagnostico = txtDiagnostico.Text,
                Observaciones = txtObservaciones.Text,
                Id_Paciente = int.TryParse(txtIdPaciente.Text, out int p) ? p : 0,
                Id_Dentista = int.TryParse(txtIdDentista.Text, out int d) ? d : 0
            };
            repo.Insert(h);
            ClearInputs();
            LoadData();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvHistoria.CurrentRow == null) return;
            var id = (int)dgvHistoria.CurrentRow.Cells["Id_Historia"].Value;
            var h = new HistoriaClinica
            {
                Id_Historia = id,
                Diagnostico = txtDiagnostico.Text,
                Observaciones = txtObservaciones.Text,
                Id_Paciente = int.TryParse(txtIdPaciente.Text, out int p) ? p : 0,
                Id_Dentista = int.TryParse(txtIdDentista.Text, out int d) ? d : 0
            };
            repo.Update(h);
            ClearInputs();
            LoadData();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvHistoria.CurrentRow == null) return;
            var id = (int)dgvHistoria.CurrentRow.Cells["Id_Historia"].Value;
            if (MessageBox.Show("¿Eliminar historia clínica?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                repo.Delete(id);
                LoadData();
            }
        }

        private void dgvHistoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHistoria.CurrentRow == null) return;
            txtDiagnostico.Text = dgvHistoria.CurrentRow.Cells["Diagnostico"].Value?.ToString();
            txtObservaciones.Text = dgvHistoria.CurrentRow.Cells["Observaciones"].Value?.ToString();
            txtIdPaciente.Text = dgvHistoria.CurrentRow.Cells["Id_Paciente"].Value?.ToString();
            txtIdDentista.Text = dgvHistoria.CurrentRow.Cells["Id_Dentista"].Value?.ToString();
        }

        private void ClearInputs()
        {
            txtDiagnostico.Clear();
            txtObservaciones.Clear();
            txtIdPaciente.Clear();
            txtIdDentista.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();
    }
}
