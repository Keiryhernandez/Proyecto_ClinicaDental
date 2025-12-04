using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClinicaDentalApp.Models;
using System.Linq;

namespace ClinicaDentalApp.Database
{
    public class FacturaRepository
    {
        private static readonly List<Factura> offline = new List<Factura>();
        private static int offlineNextId = 1;
        public List<Factura> GetAll()
        {
            try
            {
                var list = new List<Factura>();
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("SELECT * FROM Factura", conn);
                    var rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        list.Add(new Factura
                        {
                            Id_Factura = Convert.ToInt32(rdr["Id_Factura"]),
                            Fecha = Convert.ToDateTime(rdr["Fecha"]),
                            Monto_Total = rdr["Monto_Total"] != DBNull.Value ? Convert.ToDecimal(rdr["Monto_Total"]) : 0,
                            Metodo_Pago = rdr["Metodo_Pago"].ToString(),
                            Id_Paciente = Convert.ToInt32(rdr["Id_Paciente"]),
                            Id_Tratamiento = Convert.ToInt32(rdr["Id_Tratamiento"])
                        });
                    }
                }
                return list;
            }
            catch
            {
                return offline.Select(f => new Factura
                {
                    Id_Factura = f.Id_Factura,
                    Fecha = f.Fecha,
                    Monto_Total = f.Monto_Total,
                    Metodo_Pago = f.Metodo_Pago,
                    Id_Paciente = f.Id_Paciente,
                    Id_Tratamiento = f.Id_Tratamiento
                }).ToList();
            }
        }

        public void Insert(Factura f)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"INSERT INTO Factura (Fecha, Monto_Total, Metodo_Pago, Id_Paciente, Id_Tratamiento)
                                              VALUES (@fe,@m,@mp,@p,@t)", conn);
                    cmd.Parameters.AddWithValue("@fe", f.Fecha.Date);
                    cmd.Parameters.AddWithValue("@m", f.Monto_Total);
                    cmd.Parameters.AddWithValue("@mp", (object)f.Metodo_Pago ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@p", f.Id_Paciente);
                    cmd.Parameters.AddWithValue("@t", f.Id_Tratamiento);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                f.Id_Factura = offlineNextId++;
                offline.Add(f);
            }
        }

        public void Update(Factura f)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand(@"UPDATE Factura SET Fecha=@fe, Monto_Total=@m, Metodo_Pago=@mp, Id_Paciente=@p, Id_Tratamiento=@t
                                               WHERE Id_Factura=@id", conn);
                    cmd.Parameters.AddWithValue("@fe", f.Fecha.Date);
                    cmd.Parameters.AddWithValue("@m", f.Monto_Total);
                    cmd.Parameters.AddWithValue("@mp", (object)f.Metodo_Pago ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@p", f.Id_Paciente);
                    cmd.Parameters.AddWithValue("@t", f.Id_Tratamiento);
                    cmd.Parameters.AddWithValue("@id", f.Id_Factura);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var idx = offline.FindIndex(x => x.Id_Factura == f.Id_Factura);
                if (idx >= 0) offline[idx] = f;
            }
        }

        public void Delete(int id)
        {
            try
            {
                using (var conn = DBConnection.GetConnection())
                {
                    conn.Open();
                    var cmd = new SqlCommand("DELETE FROM Factura WHERE Id_Factura=@id", conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                var item = offline.FirstOrDefault(x => x.Id_Factura == id);
                if (item != null) offline.Remove(item);
            }
        }
    }
}
