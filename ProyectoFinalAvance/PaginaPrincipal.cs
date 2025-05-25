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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void BInfoServicios_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaInfoDServicios abrirInfoServicios = new PantallaInfoDServicios();
            abrirInfoServicios.Show();
        }

        private void BRegisServicios_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistroDServicios2 abrirRDServicios = new RegistroDServicios2();
            abrirRDServicios.Show();
        }

        private void BInfoT_Click(object sender, EventArgs e)
        {
            this.Close();
            InfoTrabajadores abrirInfoT = new InfoTrabajadores();
            abrirInfoT.Show();
        }

        private void BInventario_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario abrirInvnetario = new Inventario();
            abrirInvnetario.Show();
        }

        private void BNuevoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevoCliente abrirNuevoC = new NuevoCliente();
            abrirNuevoC.Show();
        }

        private void BCerrarS_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaDInicio abrirPantallInicio = new PantallaDInicio();
            abrirPantallInicio.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
