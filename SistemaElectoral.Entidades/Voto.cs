using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral.Entidades
{
    public class Voto
    {
        public int Id { get; set; }
        public Boleta Boleta { get; set; }

    }
}
