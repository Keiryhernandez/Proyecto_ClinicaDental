using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using RepoDb;

namespace Proyecto_Clinica.Repositorio
{
    public class UserRepository
    {
        private readonly string _connString;

        public UserRepository()
        {
            _connString = ConfigurationManager.ConnectionStrings["ClinicaDental"].ConnectionString;
        }

        // Valida un usuario y devuelve su rol
        public bool ValidateUser(string username, string password, out string rol)
        {
            rol = null;

            try
            {
                var passwordHash = Utils.Utils.ComputeSha256(password);

                using (var connection = new SqlConnection(_connString))
                {
                    // Buscar usuario por nombre de usuario
                    var user = connection.Query<Usuario>(
                        "SELECT * FROM Usuario WHERE Username = @Username",
                        new { Username = username }
                    ).FirstOrDefault();

                    // Verificar si el usuario existe
                    if (user == null || user.PasswordHash == null)
                    {
                        return false;
                    }

                    // Comparar hash de contraseña
                    if (!Utils.Utils.ByteArraysEqual(user.PasswordHash, passwordHash))
                    {
                        return false;
                    }

                    rol = user.Rol;
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log del error (opcional)
                System.Diagnostics.Debug.WriteLine($"Error en ValidateUser: {ex.Message}");
                return false;
            }
        }
    }

    // Modelo de datos para Usuario
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Rol { get; set; }
        public int? Id_Recepcionista { get; set; }
    }
}