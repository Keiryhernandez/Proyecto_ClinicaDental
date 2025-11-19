using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Clinica.Utils;

namespace Proyecto_Clinica.Repositorio
{
    public class UserRepository
    {
        public bool ValidateUser(string user, string pass, out string rol)
        {
            rol = "Admin"; // Solo para prueba
            return user == "admin" && pass == "123";
        }
    }
}
