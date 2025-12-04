using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClinicaDentalApp.Models;
using System.Linq;

namespace ClinicaDentalApp.Database
{
    public class HistoriaRepository
    {
        private static readonly List<HistoriaClinica> offline = new List<HistoriaClinica>();
        private static int offlineNextId = 1;
        public List<HistoriaClinica> GetAll()
        {
            try
            {
                var list = new List<HistoriaClinica>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM Historia_Clinica", conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        list.Add(new HistoriaClinica
                        {
                            Id_Historia = Convert.ToInt32(rdr["Id_Historia"]),
                            Diagnostico = rdr["Diagnostico"].ToString(),
                            Observaciones = rdr["Observaciones"].ToString(),
                            Id_Paciente = Convert.ToInt32(rdr["Id_Paciente"]),
                            Id_Dentista = Convert.ToInt32(rdr["Id_Dentista"])
                        });
                    }
                }
                return list;
            }
            catch
            {
                return offline.Select(h => new HistoriaClinica
                {
                    Id_Historia = h.Id_Historia,
                    Diagnostico = h.Diagnostico,
                    Observaciones = h.Observaciones,
                    Id_Paciente = h.Id_Paciente,
                    Id_Dentista = h.Id_Dentista
                }).ToList();
            }
        }

        public void Insert(HistoriaClinica h)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"INSERT INTO Historia_Clinica (Diagnostico, Observaciones, Id_Paciente, Id_Dentista)
                                              VALUES (@diag,@obs,@p,@d)", conn);
                    cmd.Parameters.AddWithValue("@diag", (object)h.Diagnostico ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@obs", (object)h.Observaciones ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@p", h.Id_Paciente);
                    cmd.Parameters.AddWithValue("@d", h.Id_Dentista);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                h.Id_Historia = offlineNextId++;
                offline.Add(h);
            }
        }

        public void Update(HistoriaClinica h)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"UPDATE Historia_Clinica SET Diagnostico=@diag, Observaciones=@obs, Id_Paciente=@p, Id_Dentista=@d
                                               WHERE Id_Historia=@id", conn);
                    cmd.Parameters.AddWithValue("@diag", (object)h.Diagnostico ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@obs", (object)h.Observaciones ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@p", h.Id_Paciente);
                    cmd.Parameters.AddWithValue("@d", h.Id_Dentista);
                    cmd.Parameters.AddWithValue("@id", h.Id_Historia);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var idx = offline.FindIndex(x => x.Id_Historia == h.Id_Historia);
                if (idx >= 0) offline[idx] = h;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM Historia_Clinica WHERE Id_Historia=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var item = offline.FirstOrDefault(x => x.Id_Historia == id);
                if (item != null) offline.Remove(item);
            }
        }
    }
}
