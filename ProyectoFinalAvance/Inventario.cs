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
    public partial class Inventario : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");

        public Inventario()
        {
            InitializeComponent();
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

        private void ListaDServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string servicioS;
            servicioS = ListaDServicios.Text;
            if(servicioS == "Todo")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO ";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;

                conexion.Close();
            }
            else if (servicioS == "Ingenieria")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 9";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
            else if (servicioS == "Cableado")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 1";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
            else if (servicioS == "Audio")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 2";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
            else if (servicioS == "Video")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 3";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
            else if (servicioS == "Control de Iluminación")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 4";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
            else if (servicioS == "Red De Datos")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 5";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
            else if (servicioS == "Telefonia Y Control De Accesos")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 6";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
            else if (servicioS == "Circuito Cerrado")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 8";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
            else if (servicioS == "Control")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from INVENTARIO where num_servicio = 7";

                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                InventarioDG.DataSource = dt;
                conexion.Close();

            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            ListaDServicios.SelectedIndex = 0;
            conexion.Open();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conexion;
            cmdSelect.CommandText = "Select*from INVENTARIO ";

            SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            InventarioDG .DataSource = dt;

            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SolicitudP solicitud = new SolicitudP();
            solicitud.Show();
        }

        private void BTAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarProducto agregarP = new AgregarProducto();
            agregarP.Show();
        }

        private void ActualizarOEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
            ActualizarEliminarP AEP = new ActualizarEliminarP();
            AEP.Show();
        }
    }
}
