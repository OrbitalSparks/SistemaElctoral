using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral.Entidades
{
    public class Boleta
    {
        public int IdBoleta { get; set; }
        public List<Candidatos> ListaCandidatos { get; set; }
    }
}
