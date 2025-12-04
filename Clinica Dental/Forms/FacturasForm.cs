using System;
using System.Windows.Forms;
using ClinicaDentalApp.Database;
using ClinicaDentalApp.Models;
using System.Collections.Generic;

namespace ClinicaDentalApp.Forms
{
    public partial class FacturasForm : Form
    {
        private readonly FacturaRepository repo = new FacturaRepository();

        public FacturasForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvFacturas.DataSource = repo.GetAll();
                dgvFacturas.Columns["Id_Factura"].Visible = false;
                dgvFacturas.AutoResizeColumns();
            }
            catch
            {
                dgvFacturas.DataSource = new List<Factura>();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            var f = new Factura
            {
                Fecha = dtpFecha.Value.Date,
                Monto_Total = decimal.TryParse(txtMonto.Text, out decimal m) ? m : 0,
                Metodo_Pago = txtMetodo.Text,
                Id_Paciente = int.TryParse(txtIdPaciente.Text, out int p) ? p : 0,
                Id_Tratamiento = int.TryParse(txtIdTratamiento.Text, out int t) ? t : 0
            };
            try
            {
                repo.Insert(f);
                ClearInputs();
                LoadData();
            }
            catch { MessageBox.Show("No disponible en modo sin conexión."); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null) return;
            var id = (int)dgvFacturas.CurrentRow.Cells["Id_Factura"].Value;
            var f = new Factura
            {
                Id_Factura = id,
                Fecha = dtpFecha.Value.Date,
                Monto_Total = decimal.TryParse(txtMonto.Text, out decimal m) ? m : 0,
                Metodo_Pago = txtMetodo.Text,
                Id_Paciente = int.TryParse(txtIdPaciente.Text, out int p) ? p : 0,
                Id_Tratamiento = int.TryParse(txtIdTratamiento.Text, out int t) ? t : 0
            };
            try
            {
                repo.Update(f);
                ClearInputs();
                LoadData();
            }
            catch { MessageBox.Show("No disponible en modo sin conexión."); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null) return;
            var id = (int)dgvFacturas.CurrentRow.Cells["Id_Factura"].Value;
            if (MessageBox.Show("¿Eliminar factura?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    repo.Delete(id);
                    LoadData();
                }
                catch { MessageBox.Show("No disponible en modo sin conexión."); }
            }
        }

        private void dgvFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFacturas.CurrentRow == null) return;
            dtpFecha.Value = Convert.ToDateTime(dgvFacturas.CurrentRow.Cells["Fecha"].Value);
            txtMonto.Text = dgvFacturas.CurrentRow.Cells["Monto_Total"].Value?.ToString();
            txtMetodo.Text = dgvFacturas.CurrentRow.Cells["Metodo_Pago"].Value?.ToString();
            txtIdPaciente.Text = dgvFacturas.CurrentRow.Cells["Id_Paciente"].Value?.ToString();
            txtIdTratamiento.Text = dgvFacturas.CurrentRow.Cells["Id_Tratamiento"].Value?.ToString();
        }

        private void ClearInputs()
        {
            dtpFecha.Value = DateTime.Today;
            txtMonto.Clear();
            txtMetodo.Clear();
            txtIdPaciente.Clear();
            txtIdTratamiento.Clear();
        }

        private void btnRefrescar_Click(object sender, EventArgs e) => LoadData();
    }
}
