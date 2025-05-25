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
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {
            PantallaDInicio Ingreso = new PantallaDInicio();
            Ingreso.MdiParent = this;
            Ingreso.Show();           
        }
    }
}
