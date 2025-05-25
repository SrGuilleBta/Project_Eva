using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProyectoFinalAvance
{
    public partial class InfoTrabajadores : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");

        public InfoTrabajadores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Nomina abrirGN = new Nomina();
            abrirGN.Show();
        }

        private void BInfoServicios_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaInfoDServicios abrirInfoServicios = new PantallaInfoDServicios();
            abrirInfoServicios.Show();
        }

        private void BPaginaPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
            PaginaPrincipal PaginaP = new PaginaPrincipal();
            PaginaP.Show();
        }

        private void InfoTrabajadores_Load(object sender, EventArgs e)
        {            
            ListaDServicios.SelectedIndex = 0;
            conexion.Open();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conexion;
            cmdSelect.CommandText = "Select*from TRABAJADORES ";

            SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TrabajadoresDG.DataSource = dt;

            conexion.Close();
        }

        private void nombretxt_TextChanged(object sender, EventArgs e)
        {
            string servicioS;            
            servicioS = ListaDServicios.Text;
            conexion.Open();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conexion;
            if (servicioS == "Todo")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%'";
            }
            else if (servicioS == "Ingenieria")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 9";
            }
            else if (servicioS == "Cableado")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 1";
            }
            else if (servicioS == "Audio")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 2";
            }
            else if (servicioS == "Video")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 3";
            }
            else if (servicioS == "Control de Iluminación")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 4";
            }
            else if (servicioS == "Red De Datos")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 5";
            }
            else if (servicioS == "Telefonia Y Control De Accesos")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 6";
            }
            else if (servicioS == "Circuito Cerrado")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 8";
            }
            else if (servicioS == "Control")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 7";
            }

            cmdSelect.Parameters.AddWithValue("@param1", nombretxt.Text);

            
            SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TrabajadoresDG.DataSource = dt;
            conexion.Close();

        }

        private void ListaDServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string servicioS;
            servicioS = ListaDServicios.Text;
            conexion.Open();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conexion;
            if (servicioS == "Todo")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%'";
            }
            else if (servicioS == "Ingenieria")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 9";
            }
            else if (servicioS == "Cableado")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 1";
            }
            else if (servicioS == "Audio")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 2";
            }
            else if (servicioS == "Video")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 3";
            }
            else if (servicioS == "Control de Iluminación")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 4";
            }
            else if (servicioS == "Red De Datos")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 5";
            }
            else if (servicioS == "Telefonia Y Control De Accesos")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 6";
            }
            else if (servicioS == "Circuito Cerrado")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 8";
            }
            else if (servicioS == "Control")
            {
                cmdSelect.CommandText = "Select *from TRABAJADORES where nom_apellidos like @param1+ '%' and num_servicio = 7";
            }

            cmdSelect.Parameters.AddWithValue("@param1", nombretxt.Text);


            SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            TrabajadoresDG.DataSource = dt;
            conexion.Close();
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarT agregar = new AgregarT();
            agregar.Show();
        }

        private void ActualizarOEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualizaroEliminarT actuEli = new ActualizaroEliminarT();
            actuEli.Show();
        }

        private void TrabajadoresDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
