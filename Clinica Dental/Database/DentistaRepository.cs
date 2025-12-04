using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClinicaDentalApp.Models;
using System.Linq;

namespace ClinicaDentalApp.Database
{
    public class DentistaRepository
    {
        private static readonly List<Dentista> offline = new List<Dentista>();
        private static int offlineNextId = 1;
        public List<Dentista> GetAll()
        {
            try
            {
                var list = new List<Dentista>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM Dentista", conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        list.Add(new Dentista
                        {
                            Id_Dentista = Convert.ToInt32(rdr["Id_Dentista"]),
                            Nombre = rdr["Nombre"].ToString(),
                            Apellido = rdr["Apellido"].ToString(),
                            Especialidad = rdr["Especialidad"].ToString(),
                            Telefono = rdr["Telefono"].ToString(),
                            Correo = rdr["Correo"].ToString()
                        });
                    }
                }
                return list;
            }
            catch
            {
                return offline.Select(d => new Dentista
                {
                    Id_Dentista = d.Id_Dentista,
                    Nombre = d.Nombre,
                    Apellido = d.Apellido,
                    Especialidad = d.Especialidad,
                    Telefono = d.Telefono,
                    Correo = d.Correo
                }).ToList();
            }
        }

        public void Insert(Dentista d)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"INSERT INTO Dentista (Nombre, Apellido, Especialidad, Telefono, Correo)
                                              VALUES (@n,@a,@esp,@t,@c)", conn);
                    cmd.Parameters.AddWithValue("@n", d.Nombre);
                    cmd.Parameters.AddWithValue("@a", d.Apellido);
                    cmd.Parameters.AddWithValue("@esp", (object)d.Especialidad ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@t", (object)d.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@c", (object)d.Correo ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                d.Id_Dentista = offlineNextId++;
                offline.Add(d);
            }
        }

        public void Update(Dentista d)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"UPDATE Dentista SET Nombre=@n, Apellido=@a, Especialidad=@esp, Telefono=@t, Correo=@c
                                               WHERE Id_Dentista=@id", conn);
                    cmd.Parameters.AddWithValue("@n", d.Nombre);
                    cmd.Parameters.AddWithValue("@a", d.Apellido);
                    cmd.Parameters.AddWithValue("@esp", (object)d.Especialidad ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@t", (object)d.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@c", (object)d.Correo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", d.Id_Dentista);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var idx = offline.FindIndex(x => x.Id_Dentista == d.Id_Dentista);
                if (idx >= 0) offline[idx] = d;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM Dentista WHERE Id_Dentista=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var item = offline.FirstOrDefault(x => x.Id_Dentista == id);
                if (item != null) offline.Remove(item);
            }
        }
    }
}
