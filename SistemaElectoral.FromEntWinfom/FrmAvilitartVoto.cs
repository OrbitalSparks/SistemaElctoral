using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaElectoral.Entidades;

namespace SistemaElectoral.FromEntWinfom
{
    public partial class FrmAvilitartVoto : Form
    {
        public FrmAvilitartVoto()
        {
            InitializeComponent();
        }
        public FrmAvilitartVoto(CentroDeVotacion centroDeVotacion)
        {
            InitializeComponent();
            lblDistrito.Text=centroDeVotacion.Distrito.NombreDistrito;
            lblSeccion.Text = centroDeVotacion.Seccion.NombreSeccion;
            lblCircuito.Text=centroDeVotacion.Circuito.NombreCircuito;
        }


    }
}
