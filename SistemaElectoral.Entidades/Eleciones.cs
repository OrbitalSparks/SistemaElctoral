using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral.Entidades
{
    public class Eleciones
    {
        public int IdEleciones { get; set; }
        public string NombreEleciones { get; set; }

        public DateTime FechaElecion { get; set; }
        public CentroDeVotacion centroDeVotacion { get; set; }
    }
}
