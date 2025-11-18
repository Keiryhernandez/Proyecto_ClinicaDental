using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;




namespace Proyecto_Clinica
{
    public class DataAccess
    {
        private readonly string _connString;

        public DataAccess()
        {
            _connString = ConfigurationManager.ConnectionStrings["ClinicaDental"].ConnectionString;
        }

        // Intenta validar un usuario; devuelve true si coincide
        public bool ValidateUser(string username, string password, out string rol)
        {
            rol = null;
            byte[] passwordHash = Proyecto_Clinica.Utils.Utils.ComputeSha256(password);

            using (var conn = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("SELECT PasswordHash, Rol FROM Usuario WHERE Username = @username", conn))
            {
                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = username;
                conn.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (!reader.Read())
                        return false; // usuario no existe

                    // PasswordHash en la DB es varbinary
                    var dbHash = reader["PasswordHash"] as byte[];
                    rol = reader["Rol"] != DBNull.Value ? reader["Rol"].ToString() : null;

                    if (dbHash == null) return false;

                    return Proyecto_Clinica.Utils.Utils.ByteArraysEqual(dbHash, passwordHash);

                }
            }
        }
    }
}
