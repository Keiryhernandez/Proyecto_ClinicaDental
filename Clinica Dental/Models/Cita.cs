using System;

namespace ClinicaDentalApp.Models
{
    public class Cita
    {
        public int Id_Cita { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Motivo { get; set; }
        public string Estado { get; set; }
        public int Id_Paciente { get; set; }
        public int Id_Dentista { get; set; }
        public int Id_Recepcionista { get; set; }
    }
}
