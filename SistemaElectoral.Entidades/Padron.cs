using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral.Entidades
{
    public class Padron
    {
        public int IdPadron { get; set; }
        public string NombrePadron { get; set; }

        public List<Electores> ListaElectores { get; set; }
    }
}
