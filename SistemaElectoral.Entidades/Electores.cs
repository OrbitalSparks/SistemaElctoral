using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral.Entidades
{
    public class Electores : Persona
    {
        public int IdLectores { get; set; }
        public bool HabilitadoVoto { get; set; }
        public bool SiVoto { get; set; }

        //public Electores(int id, string DNI, string Nombre, string Apellido,
        //    string Direccion, DateTime FechaDeNacimiento, int IdLectores, bool HabilitadoVoto, bool SiVoto)
        //    : base(id, DNI, Nombre, Apellido, Direccion, FechaDeNacimiento)
        //{
        //    this.IdLectores = IdLectores;
        //    this.HabilitadoVoto = HabilitadoVoto;
        //    this.SiVoto = SiVoto;

        //}


    }
}
