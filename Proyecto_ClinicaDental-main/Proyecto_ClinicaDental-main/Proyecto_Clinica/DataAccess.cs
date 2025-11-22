using System;
using System.Configuration;
using System.Data.SqlClient;
using RepoDb;
using RepoDb.SqlServer;

namespace Proyecto_Clinica
{
    public class DataAccess
    {
        private readonly string _connString;

        static DataAccess()
        {
            SqlServerBootstrap.Initialize();
        }

        public DataAccess()
        {
            _connString = ConfigurationManager.ConnectionStrings["ClinicaDental"].ConnectionString;
        }

        // Intenta validar un usuario; devuelve true si coincide
        public bool ValidateUser(string username, string password, out string rol)
        {
            rol = null;
            var passwordHash = Utils.Utils.ComputeSha256(password);

            using (var connection = new SqlConnection(_connString))
            {
                var user = connection.Query<Usuario>("WHERE Username = @Username", new { Username = username }).FirstOrDefault();

                if (user == null || user.PasswordHash == null)
                {
                    return false;
                }

                if (!Utils.Utils.ByteArraysEqual(user.PasswordHash, passwordHash))
                {
                    return false;
                }

                rol = user.Rol;
                return true;
            }
        }
    }

    public class Usuario
    {
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public string Rol { get; set; }
    }
}
