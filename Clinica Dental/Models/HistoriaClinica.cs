using System;

namespace ClinicaDentalApp.Models
{
     public class HistoriaClinica
     {
         public int Id_Historia { get; set; }
         public string Diagnostico { get; set; }
         public string Observaciones { get; set; }
         public int Id_Paciente { get; set; }
         public int Id_Dentista { get; set; }
     }
}
