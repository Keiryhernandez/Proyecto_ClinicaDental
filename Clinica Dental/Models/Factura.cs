using System;

namespace ClinicaDentalApp.Models
{
    public class Factura
    {
        public int Id_Factura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto_Total { get; set; }
        public string Metodo_Pago { get; set; }
        public int Id_Paciente { get; set; }
        public int Id_Tratamiento { get; set; }
    }
}
