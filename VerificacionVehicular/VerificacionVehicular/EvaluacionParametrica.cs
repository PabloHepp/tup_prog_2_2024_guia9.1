using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificacionVehicular
{
    internal class EvaluacionParametrica: Evaluacion
    {
        public double ValorMinimo { get;}
        public double ValorMaximo { get;}
        public string Unidad {  get;}
        public double ValorTolerado { get;}
        public double ValorMedido { get; set; }

        public EvaluacionParametrica (string nombre, string descripcion,double valorMinimo, double valorMaximo, string unidad, double valorTolerado, double valorMedido)
            :base(nombre, descripcion)
        {
            ValorMinimo = valorMinimo;
            ValorMaximo = valorMaximo;
            Unidad = unidad;
            ValorTolerado = valorTolerado;
            ValorMedido = valorMedido;
        }

        public override TipoAprobacion Evaluar()
        {
            if(ValorMedido >= ValorMinimo && ValorMedido <= ValorMaximo)
            {
                return TipoAprobacion.Aprobado;
            }
            else if (ValorMedido >= (ValorMinimo * 0.7) && ValorMedido < ValorMinimo)
            {
                return TipoAprobacion.Parcial;
            }
             return TipoAprobacion.NoAprobado;
           
        }

        public override string ToString()
        {
            return $"Resultado: {Evaluar()}";
        }
    }
}
