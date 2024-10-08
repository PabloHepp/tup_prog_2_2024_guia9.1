using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificacionVehicular
{
    internal class Propietario
    {
        public int DNI;
        public string ApellidosNombres { get; set; }
        public string Email { get; set; }

        public Propietario (int dni, string nombre, string email)
        {
            DNI = dni;
            ApellidosNombres = nombre;
            Email = email;
            
        }

        public override string ToString()
        {
            return $"{ApellidosNombres}, {DNI}";
        }
    }
}
