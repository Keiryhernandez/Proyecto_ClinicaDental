using System;
using System.Windows.Forms;

namespace ClinicaDentalApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly string rol;
        private PacientesForm fPacientes;
        private DentistasForm fDentistas;
        private RecepcionistasForm fRecepcionistas;
        private CitasForm fCitas;
        private TratamientosForm fTratamientos;
        private FacturasForm fFacturas;
        private HistoriaClinicaForm fHistoria;

        public MainForm(string rol)
        {
            InitializeComponent();
            this.rol = rol;
            lblBienvenida.Text = $"Bienvenido - Rol: {rol}";
        }

        private void OpenChild(Form child)
        {
            panelContent.SuspendLayout();
            foreach (Control c in panelContent.Controls)
            {
                c.Hide();
            }

            if (!panelContent.Controls.Contains(child))
            {
                child.TopMost = false;
                child.TopLevel = false;
                child.FormBorderStyle = FormBorderStyle.None;
                child.Dock = DockStyle.Fill;
                panelContent.Controls.Add(child);
            }
            child.Show();
            child.BringToFront();
            panelContent.ResumeLayout();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            if (fPacientes == null || fPacientes.IsDisposed) fPacientes = new PacientesForm();
            OpenChild(fPacientes);
        }

        private void btnDentistas_Click(object sender, EventArgs e)
        {
            if (fDentistas == null || fDentistas.IsDisposed) fDentistas = new DentistasForm();
            OpenChild(fDentistas);
        }

        private void btnRecepcionistas_Click(object sender, EventArgs e)
        {
            if (fRecepcionistas == null || fRecepcionistas.IsDisposed) fRecepcionistas = new RecepcionistasForm();
            OpenChild(fRecepcionistas);
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            if (fCitas == null || fCitas.IsDisposed) fCitas = new CitasForm();
            OpenChild(fCitas);
        }

        private void btnTratamientos_Click(object sender, EventArgs e)
        {
            if (fTratamientos == null || fTratamientos.IsDisposed) fTratamientos = new TratamientosForm();
            OpenChild(fTratamientos);
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            if (fFacturas == null || fFacturas.IsDisposed) fFacturas = new FacturasForm();
            OpenChild(fFacturas);
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (fHistoria == null || fHistoria.IsDisposed) fHistoria = new HistoriaClinicaForm();
            OpenChild(fHistoria);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
