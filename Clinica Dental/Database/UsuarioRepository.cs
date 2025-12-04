using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using ClinicaDentalApp.Models;

namespace ClinicaDentalApp.Database
{
    public class UsuarioRepository
    {
        public List<Usuario> GetAll()
        {
            var list = new List<Usuario>();
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT Id_Usuario, Username, Rol, Id_Recepcionista FROM Usuario", conn);
                var rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    list.Add(new Usuario
                    {
                        Id_Usuario = Convert.ToInt32(rdr["Id_Usuario"]),
                        Username = rdr["Username"].ToString(),
                        Rol = rdr["Rol"].ToString(),
                        Id_Recepcionista = rdr["Id_Recepcionista"] != DBNull.Value ? (int?)Convert.ToInt32(rdr["Id_Recepcionista"]) : null
                    });
                }
            }
            return list;
        }

        public void Insert(string username, string password, string rol, int? idRecepcionista = null)
        {
            var hash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand(@"INSERT INTO Usuario (Username, PasswordHash, Rol, Id_Recepcionista)
                                          VALUES (@u,@h,@r,@idr)", conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@h", hash);
                cmd.Parameters.AddWithValue("@r", (object)rol ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@idr", (object)idRecepcionista ?? DBNull.Value);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DBConnection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("DELETE FROM Usuario WHERE Id_Usuario=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
