using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral.Entidades
{
    public class CentroDeVotacion
    {
        public int IdCentro { get; set; }
        public string NombreCentro { get; set; }
        public Distrito Distrito { get; set; }
        public Seccion Seccion { get; set; }
        public Circuito Circuito { get; set; }
        public List<Mesa> Mesas { get; set; }
        //public string Padron { get; set; }
    }
}
