using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificacionVehicular
{
    internal abstract class Evaluacion
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public Evaluacion(string nombre, string descripcion)
        {
            Nombre = nombre;
            Descripcion = descripcion;
        }
        public abstract TipoAprobacion Evaluar();
        public override string ToString()
        {
            return $"{Nombre}, {Descripcion}";
        }
    }
}
