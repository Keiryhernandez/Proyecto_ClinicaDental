using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClinicaDentalApp.Models;
using System.Linq;

namespace ClinicaDentalApp.Database
{
    public class CitaRepository
    {
        private static readonly List<Cita> offline = new List<Cita>();
        private static int offlineNextId = 1;
        public List<Cita> GetAll()
        {
            try
            {
                var list = new List<Cita>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM Cita", conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        list.Add(new Cita
                        {
                            Id_Cita = Convert.ToInt32(rdr["Id_Cita"]),
                            Fecha = Convert.ToDateTime(rdr["Fecha"]),
                            Hora = (TimeSpan)rdr["Hora"],
                            Motivo = rdr["Motivo"].ToString(),
                            Estado = rdr["Estado"].ToString(),
                            Id_Paciente = Convert.ToInt32(rdr["Id_Paciente"]),
                            Id_Dentista = Convert.ToInt32(rdr["Id_Dentista"]),
                            Id_Recepcionista = Convert.ToInt32(rdr["Id_Recepcionista"])
                        });
                    }
                }
                return list;
            }
            catch
            {
                return offline.Select(c => new Cita
                {
                    Id_Cita = c.Id_Cita,
                    Fecha = c.Fecha,
                    Hora = c.Hora,
                    Motivo = c.Motivo,
                    Estado = c.Estado,
                    Id_Paciente = c.Id_Paciente,
                    Id_Dentista = c.Id_Dentista,
                    Id_Recepcionista = c.Id_Recepcionista
                }).ToList();
            }
        }

        public void Insert(Cita c)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"INSERT INTO Cita (Fecha, Hora, Motivo, Estado, Id_Paciente, Id_Dentista, Id_Recepcionista)
                                              VALUES (@f,@h,@m,@e,@p,@d,@r)", conn);
                    cmd.Parameters.AddWithValue("@f", c.Fecha.Date);
                    cmd.Parameters.AddWithValue("@h", c.Hora);
                    cmd.Parameters.AddWithValue("@m", (object)c.Motivo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@e", (object)c.Estado ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@p", c.Id_Paciente);
                    cmd.Parameters.AddWithValue("@d", c.Id_Dentista);
                    cmd.Parameters.AddWithValue("@r", c.Id_Recepcionista);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                c.Id_Cita = offlineNextId++;
                offline.Add(c);
            }
        }

        public void Update(Cita c)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"UPDATE Cita SET Fecha=@f, Hora=@h, Motivo=@m, Estado=@e, Id_Paciente=@p, Id_Dentista=@d, Id_Recepcionista=@r
                                               WHERE Id_Cita=@id", conn);
                    cmd.Parameters.AddWithValue("@f", c.Fecha.Date);
                    cmd.Parameters.AddWithValue("@h", c.Hora);
                    cmd.Parameters.AddWithValue("@m", (object)c.Motivo ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@e", (object)c.Estado ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@p", c.Id_Paciente);
                    cmd.Parameters.AddWithValue("@d", c.Id_Dentista);
                    cmd.Parameters.AddWithValue("@r", c.Id_Recepcionista);
                    cmd.Parameters.AddWithValue("@id", c.Id_Cita);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var idx = offline.FindIndex(x => x.Id_Cita == c.Id_Cita);
                if (idx >= 0) offline[idx] = c;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM Cita WHERE Id_Cita=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var item = offline.FirstOrDefault(x => x.Id_Cita == id);
                if (item != null) offline.Remove(item);
            }
        }
    }
}
