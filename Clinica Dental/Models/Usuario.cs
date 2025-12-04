namespace ClinicaDentalApp.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Username { get; set; }
        // PasswordHash no lo exponemos aquí como string
        public string Rol { get; set; }
        public int? Id_Recepcionista { get; set; }
    }
}
