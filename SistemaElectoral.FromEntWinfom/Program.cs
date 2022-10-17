using SistemaElectoral.Entidades;
namespace SistemaElectoral.FromEntWinfom
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmAvilitartVoto(ObtenerdatosVotacion()));
        }
        private static CentroDeVotacion ObtenerdatosVotacion()
        {
            //Creamos(Una istacia de el Centro de votacion)
            Distrito distrito = new Distrito();
            Seccion seccion = new Seccion();
            Circuito circuito = new Circuito();
            CentroDeVotacion centroDeVotacion = new CentroDeVotacion();
            centroDeVotacion.IdCentro = 1;
            centroDeVotacion.NombreCentro = "Escuela Nº7";
            centroDeVotacion.Distrito = distrito;
            centroDeVotacion.Seccion = seccion;
            centroDeVotacion.Circuito = circuito;
            centroDeVotacion.Mesas = new List<Mesa>() {
                new Mesa() { IdMesa = 1, NombreMesa="Mesa 1",PadronElectoral=  ObtenerPadron(1)},
                new Mesa() { IdMesa = 2, NombreMesa="Mesa 2",PadronElectoral=ObtenerPadron(2)}
            };

            //Creamos Distritos
            distrito.IdDistrito = 1;
            distrito.NombreDistrito = "CABA";

            //Creamos Seccion
            seccion.IdSeccion = 1;
            seccion.NombreSeccion = "Balvanera";

            //Creamos el circuito
            circuito.IdCircuito = 1;
            circuito.NombreCircuito = "Circuito 1";
           

            return centroDeVotacion ;
        }
        public static Padron ObtenerPadron(int Mesa)
        {
            Padron padron = null;
            List<Electores> electores = new List<Electores>();
            switch (Mesa)
            {
                case 1:
                    electores.Add(new Electores() { Id = 1, Apellido = "Julion", DNI = "34901757", Nombre = "Sergio" });
                    electores.Add(new Electores() { Id = 2, Apellido = "Fran", DNI = "37911457", Nombre = "Pedro" });
                    electores.Add(new Electores() { Id = 3, Apellido = "Suit", DNI = "459712546", Nombre = "Jose" });
                    padron = new Padron()
                    {
                        IdPadron= 1,
                        NombrePadron="Padron Mesa 1",
                        ListaElectores= electores
                    };
                    break;
                case 2:
                    electores.Add(new Electores() { Id = 4, Apellido = "Mas", DNI = "45941757", Nombre = "Sergio" });
                    electores.Add(new Electores() { Id = 5, Apellido = "Gus", DNI = "37812487", Nombre = "Pedro" });
                    electores.Add(new Electores() { Id = 6, Apellido = "Mill", DNI = "559752566", Nombre = "Jose" });
                    padron = new Padron()
                    {
                        IdPadron = 2,
                        NombrePadron = "Padron Mesa 2",
                        ListaElectores = electores
                    };
                    break;
                

            }
            return padron;
        }
    }
}