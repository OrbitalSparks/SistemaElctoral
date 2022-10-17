using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaElectoral.Entidades
{
    public class Candidatos : Persona
    {
        public int IdCandidatos { get; set; }
        public string PartidoPolitico { get; set; }
        public Candidatos(int id, string DNI, string Nombre, string Apellido,
            string Direccion, DateTime FechaDeNacimiento, int IdCandidatos, string PartidoPolitico)
            : base(id, DNI, Nombre, Apellido, Direccion, FechaDeNacimiento)
        {
            this.IdCandidatos = IdCandidatos;
            this.PartidoPolitico = PartidoPolitico;


        }

    }
}
