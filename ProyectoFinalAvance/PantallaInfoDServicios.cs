using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAvance
{
    public partial class PantallaInfoDServicios : Form
    {
        public PantallaInfoDServicios()
        {
            InitializeComponent();
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevoCliente abrirNuevoC = new NuevoCliente();
            abrirNuevoC.Show();
        }

        private void BPaginaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            PaginaPrincipal PaginaP = new PaginaPrincipal();            
            PaginaP.Show();
        }

        private void ListaDServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaDServicios.SelectedIndex == 0)
            {
                InfoDeTrabajadoresTxt.Text = "Levantamiendo y cuantificación de materiales, diseños de planos con trayectorias e infrestructura para cableado estrcturado.";
            }
            else if (ListaDServicios.SelectedIndex == 1)
            {
                InfoDeTrabajadoresTxt.Text = "Cableado estrcuturado para voz, datos, audio, CCTV, video.";
            }
            else if (ListaDServicios.SelectedIndex == 2)
            {
                InfoDeTrabajadoresTxt.Text = "Suministro e instalación de equipo ambiental: bocinas, amplificadores, fuentes de audio, etc.";
            }
            else if (ListaDServicios.SelectedIndex == 3)
            {
                InfoDeTrabajadoresTxt.Text = "Suminsitro e instalción de equipo de distribucion de video: matriciales de video, extenders de video, fuentes de video e interconexion de equipos.";
            }
            else if(ListaDServicios.SelectedIndex == 4)
            {
                InfoDeTrabajadoresTxt.Text = "Suministro e instalación de equipos de control de iluminacion: diners, switches, módulos de potencia de fase adaptiva, procesadores y antenas expansoras.";
            }
            else if(ListaDServicios.SelectedIndex == 5)
            {
                InfoDeTrabajadoresTxt.Text = "Suministro e instalación de equipo para distribucion de internet: switches, Access points, cables de parcheo, interconexion y configuracion de equipos.";
            }
            else if (ListaDServicios.SelectedIndex == 6)
            {
                InfoDeTrabajadoresTxt.Text = "Suministro e instalación de equipos de telefonia: conmutadores analógicas e ip, porteros y video porteros. Suministro e instalacion de equipos de instalacion de accesos y assitencia: cerraduras de saguridad y botones de salida.";
            }
            else if (ListaDServicios.SelectedIndex== 7)
            {
                InfoDeTrabajadoresTxt.Text = "Suministro e instalación de equipos de circuito cerrado: cámaras analógicas e ip. DVR.NVR. monitores.";
            }
            else
            {
                InfoDeTrabajadoresTxt.Text = "Suministro e instalación de equipos de automatización: proesadores, emisores y receptores de infrarrojo, controladores via e interfaces a equipos de video, audio y control de iluminación.";
            }
            
        }

        private void PantallaInfoDServicios_Load(object sender, EventArgs e)
        {
            ListaDServicios.SelectedIndex = 0;
            InfoDeTrabajadoresTxt.Text = "Levantamiendo y cuantificación de materiales, diseños de planos con trayectorias e infrestructura para cableado estrcturado.";
        }
    }
}
