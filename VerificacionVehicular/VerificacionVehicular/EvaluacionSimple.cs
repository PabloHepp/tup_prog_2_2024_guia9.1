using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificacionVehicular
{
    internal class EvaluacionSimple:Evaluacion
    {
        public bool HaVerificado { get; set; }
        public EvaluacionSimple(string nombre, string descripcion)
            :base(nombre, descripcion)
        {
           
        }
        public override TipoAprobacion Evaluar()
        {
                      
            return ;
        }
    }
}
