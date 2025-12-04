namespace ClinicaDentalApp.Models
{
    public class Paciente
    {
        public int Id_Paciente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? Edad { get; set; }
        public string Genero { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
    }
}
