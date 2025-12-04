using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClinicaDentalApp.Models;
using System.Linq;

namespace ClinicaDentalApp.Database
{
    public class TratamientoRepository
    {
        private static readonly List<Tratamiento> offline = new List<Tratamiento>();
        private static int offlineNextId = 1;
        public List<Tratamiento> GetAll()
        {
            try
            {
                var list = new List<Tratamiento>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM Tratamiento", conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        list.Add(new Tratamiento
                        {
                            Id_Tratamiento = Convert.ToInt32(rdr["Id_Tratamiento"]),
                            Descripcion = rdr["Descripcion"].ToString(),
                            Costo = rdr["Costo"] != DBNull.Value ? Convert.ToDecimal(rdr["Costo"]) : 0,
                            Duracion = rdr["Duracion"].ToString(),
                            Id_Cita = Convert.ToInt32(rdr["Id_Cita"])
                        });
                    }
                }
                return list;
            }
            catch
            {
                return offline.Select(t => new Tratamiento
                {
                    Id_Tratamiento = t.Id_Tratamiento,
                    Descripcion = t.Descripcion,
                    Costo = t.Costo,
                    Duracion = t.Duracion,
                    Id_Cita = t.Id_Cita
                }).ToList();
            }
        }

        public void Insert(Tratamiento t)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"INSERT INTO Tratamiento (Descripcion, Costo, Duracion, Id_Cita)
                                              VALUES (@desc,@c,@dur,@idc)", conn);
                    cmd.Parameters.AddWithValue("@desc", (object)t.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@c", t.Costo);
                    cmd.Parameters.AddWithValue("@dur", (object)t.Duracion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idc", t.Id_Cita);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                t.Id_Tratamiento = offlineNextId++;
                offline.Add(t);
            }
        }

        public void Update(Tratamiento t)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"UPDATE Tratamiento SET Descripcion=@desc, Costo=@c, Duracion=@dur, Id_Cita=@idc
                                               WHERE Id_Tratamiento=@id", conn);
                    cmd.Parameters.AddWithValue("@desc", (object)t.Descripcion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@c", t.Costo);
                    cmd.Parameters.AddWithValue("@dur", (object)t.Duracion ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idc", t.Id_Cita);
                    cmd.Parameters.AddWithValue("@id", t.Id_Tratamiento);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var idx = offline.FindIndex(x => x.Id_Tratamiento == t.Id_Tratamiento);
                if (idx >= 0) offline[idx] = t;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM Tratamiento WHERE Id_Tratamiento=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var item = offline.FirstOrDefault(x => x.Id_Tratamiento == id);
                if (item != null) offline.Remove(item);
            }
        }
    }
}
