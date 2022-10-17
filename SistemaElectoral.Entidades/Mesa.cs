using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral.Entidades
{
    public class Mesa
    {
        public int IdMesa { get; set; }
        public string NombreMesa { get; set;}
        //public Boleta Boleta { get; set; }

        public Padron PadronElectoral { get; set; }


    }
}
