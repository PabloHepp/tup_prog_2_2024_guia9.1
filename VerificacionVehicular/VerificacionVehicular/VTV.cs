using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificacionVehicular
{
    internal class VTV : IComparable
    {
        public string Patente { get; }
        public DateTime Fecha = DateTime.Now;
        public int CantidadVerificaciones {  get; }

        public TipoAprobacion Aprobacion { get; }
        public Propietario Propietario { get; private set; }

        private List<Evaluacion> verificaciones;   
        public VTV (string patente, Propietario propietario)
        {
            verificaciones = new List<Evaluacion> ();
            Patente = patente;
            Propietario = propietario;
        }
        public void AgregarEvaluacion(string nombre, string descripcion )
        {
            Evaluacion miEVal = new EvaluacionSimple(nombre, descripcion);
            verificaciones.Add(miEVal);
        }
        public void AgregarEvaluacion(string nombre, string descripcion, double minimo, double maximo, string unidad, double tolerado,double valMed)
        {
            Evaluacion miEVal = new EvaluacionParametrica(nombre, descripcion, minimo,maximo,unidad, tolerado, valMed );
            verificaciones.Add(miEVal);
        }

        public Evaluacion this[int index]
        {
            get
            {
                if 
            }
        }
        
        VTV primerdia

            primerdia.AgregarEvaluacion()1


    }
}
