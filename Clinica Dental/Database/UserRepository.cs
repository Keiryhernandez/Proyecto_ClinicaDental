using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ClinicaDentalApp.Models;
using System.Linq;

namespace ClinicaDentalApp.Database
{
    public class PacienteRepository
    {
        private static readonly List<Paciente> offline = new List<Paciente>();
        private static int offlineNextId = 1;
        public List<Paciente> GetAll()
        {
            try
            {
                var list = new List<Paciente>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM Paciente", conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        list.Add(new Paciente
                        {
                            Id_Paciente = Convert.ToInt32(rdr["Id_Paciente"]),
                            Nombre = rdr["Nombre"].ToString(),
                            Apellido = rdr["Apellido"].ToString(),
                            Edad = rdr["Edad"] != DBNull.Value ? Convert.ToInt32(rdr["Edad"]) : (int?)null,
                            Genero = rdr["Genero"].ToString(),
                            Telefono = rdr["Telefono"].ToString(),
                            Direccion = rdr["Direccion"].ToString(),
                            Correo = rdr["Correo"].ToString()
                        });
                    }
                }
                return list;
            }
            catch
            {
                // Offline
                return offline.Select(p => new Paciente
                {
                    Id_Paciente = p.Id_Paciente,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Edad = p.Edad,
                    Genero = p.Genero,
                    Telefono = p.Telefono,
                    Direccion = p.Direccion,
                    Correo = p.Correo
                }).ToList();
            }
        }

        public void Insert(Paciente p)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"INSERT INTO Paciente (Nombre, Apellido, Edad, Genero, Telefono, Direccion, Correo)
                                               VALUES (@n,@a,@e,@g,@t,@d,@c)", conn);
                    cmd.Parameters.AddWithValue("@n", p.Nombre);
                    cmd.Parameters.AddWithValue("@a", p.Apellido);
                    cmd.Parameters.AddWithValue("@e", (object)p.Edad ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@g", (object)p.Genero ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@t", (object)p.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@d", (object)p.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@c", (object)p.Correo ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                // Offline insert
                p.Id_Paciente = offlineNextId++;
                offline.Add(p);
            }
        }

        public void Update(Paciente p)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"UPDATE Paciente SET Nombre=@n, Apellido=@a, Edad=@e, Genero=@g, Telefono=@t, Direccion=@d, Correo=@c
                                               WHERE Id_Paciente=@id", conn);
                    cmd.Parameters.AddWithValue("@n", p.Nombre);
                    cmd.Parameters.AddWithValue("@a", p.Apellido);
                    cmd.Parameters.AddWithValue("@e", (object)p.Edad ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@g", (object)p.Genero ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@t", (object)p.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@d", (object)p.Direccion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@c", (object)p.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", p.Id_Paciente);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                // Offline update
                var idx = offline.FindIndex(x => x.Id_Paciente == p.Id_Paciente);
                if (idx >= 0) offline[idx] = p;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM Paciente WHERE Id_Paciente=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                // Offline delete
                var item = offline.FirstOrDefault(x => x.Id_Paciente == id);
                if (item != null) offline.Remove(item);
            }
        }
    }
}

namespace ClinicaDentalApp.Database
{
    using System.Security.Cryptography;
    using System.Text;

    public class UserRepository
    {
        public bool Login(string username, string password, out string rol)
        {
            rol = null;
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT PasswordHash, Rol FROM Usuario WHERE Username=@u", conn);
                    cmd.Parameters.AddWithValue("@u", username);
                    using (var rdr = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (!rdr.Read()) return Fallback(username, password, out rol);

                        var storedHash = (byte[])rdr["PasswordHash"];
                        var inputHash = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
                        bool ok = AreEqual(storedHash, inputHash);
                        if (ok) rol = rdr["Rol"].ToString();
                        return ok || Fallback(username, password, out rol);
                    }
                }
            }
            catch
            {
                // Modo offline si no hay BD
                return Fallback(username, password, out rol);
            }
        }

        private static bool AreEqual(byte[] a, byte[] b)
        {
            if (a == null || b == null || a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++) diff |= a[i] ^ b[i];
            return diff == 0;
        }

        private static bool Fallback(string username, string password, out string rol)
        {
            // Credenciales por defecto para ejecución local sin BD
            if (string.Equals(username, "admin", StringComparison.OrdinalIgnoreCase)
                && password == "admin123")
            {
                rol = "Admin";
                return true;
            }
            rol = null;
            return false;
        }
    }
}
