 using System;
 using System.Configuration;
 using System.Data.SqlClient;

 namespace ClinicaDentalApp.Database
 {
     public static class DBConnection
     {
         public static SqlConnection GetConnection()
         {
             var cs = ConfigurationManager.ConnectionStrings["ClinicaDB"]?.ConnectionString;
             if (string.IsNullOrWhiteSpace(cs))
                 throw new InvalidOperationException("No se encontró la cadena de conexión 'ClinicaDB' en App.config.");
             return new SqlConnection(cs);
         }
     }
 }
