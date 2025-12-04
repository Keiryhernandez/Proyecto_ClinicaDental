using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClinicaDentalApp.Models;
using System.Linq;

namespace ClinicaDentalApp.Database
{
    public class RecepcionistaRepository
    {
        private static readonly List<Recepcionista> offline = new List<Recepcionista>();
        private static int offlineNextId = 1;
        public List<Recepcionista> GetAll()
        {
            try
            {
                var list = new List<Recepcionista>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM Recepcionista", conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        list.Add(new Recepcionista
                        {
                            Id_Recepcionista = Convert.ToInt32(rdr["Id_Recepcionista"]),
                            Nombre = rdr["Nombre"].ToString(),
                            Apellido = rdr["Apellido"].ToString(),
                            Telefono = rdr["Telefono"].ToString(),
                            Turno = rdr["Turno"].ToString()
                        });
                    }
                }
                return list;
            }
            catch
            {
                return offline.Select(x => new Recepcionista
                {
                    Id_Recepcionista = x.Id_Recepcionista,
                    Nombre = x.Nombre,
                    Apellido = x.Apellido,
                    Telefono = x.Telefono,
                    Turno = x.Turno
                }).ToList();
            }
        }

        public void Insert(Recepcionista r)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"INSERT INTO Recepcionista (Nombre, Apellido, Telefono, Turno)
                                              VALUES (@n,@a,@t,@turn)", conn);
                    cmd.Parameters.AddWithValue("@n", r.Nombre);
                    cmd.Parameters.AddWithValue("@a", r.Apellido);
                    cmd.Parameters.AddWithValue("@t", (object)r.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@turn", (object)r.Turno ?? DBNull.Value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                r.Id_Recepcionista = offlineNextId++;
                offline.Add(r);
            }
        }

        public void Update(Recepcionista r)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"UPDATE Recepcionista SET Nombre=@n, Apellido=@a, Telefono=@t, Turno=@turn
                                               WHERE Id_Recepcionista=@id", conn);
                    cmd.Parameters.AddWithValue("@n", r.Nombre);
                    cmd.Parameters.AddWithValue("@a", r.Apellido);
                    cmd.Parameters.AddWithValue("@t", (object)r.Telefono ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@turn", (object)r.Turno ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@id", r.Id_Recepcionista);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var idx = offline.FindIndex(x => x.Id_Recepcionista == r.Id_Recepcionista);
                if (idx >= 0) offline[idx] = r;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM Recepcionista WHERE Id_Recepcionista=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var item = offline.FirstOrDefault(x => x.Id_Recepcionista == id);
                if (item != null) offline.Remove(item);
            }
        }
    }
}
