namespace SistemaElectoral.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaDeNacimiento { get; set; }

        //public Persona(int id, string DNI, string Nombre, string Apellido, string Direccion, DateTime FechaDeNacimiento)
        //{
        //    Id = id;
        //    this.DNI = DNI;
        //    this.Nombre = Nombre;
        //    this.Apellido = Apellido;
        //    this.Direccion = Direccion;
        //    this.FechaDeNacimiento = FechaDeNacimiento;

        //}

    }

}