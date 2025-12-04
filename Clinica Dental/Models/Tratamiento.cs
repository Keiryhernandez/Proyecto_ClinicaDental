namespace ClinicaDentalApp.Models
{
    public class Tratamiento
    {
        public int Id_Tratamiento { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public string Duracion { get; set; }
        public int Id_Cita { get; set; }
    }
}

