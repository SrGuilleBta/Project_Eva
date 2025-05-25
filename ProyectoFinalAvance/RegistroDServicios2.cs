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
    public partial class RegistroDServicios2 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");

        public RegistroDServicios2()
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

        private void RegistroDServicios2_Load(object sender, EventArgs e)
        {
            rbNombre.Checked = true;
            ListaDFechas.SelectedIndex = 0;
            ListaDServicios.SelectedIndex = 0;
            conexion.Open();
            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = conexion;
            cmdSelect.CommandText = "Select*from REGISTRO_PEDIDO ";

            SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            RegistroSDG.DataSource = dt;

            SqlCommand cmdCliente = new SqlCommand();
            cmdCliente.Connection = conexion;
            cmdCliente.CommandText = "Select num_cliente, nom_residencia, nom_cliente, telefono, correo from CLIENTE";
            SqlDataAdapter da2 = new SqlDataAdapter(cmdCliente);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            ClientesDt.DataSource = dt2;

            conexion.Close();
        }

        private void ListaDServicios_SelectedIndexChanged(object sender, EventArgs e)
        {    
            
        }

        private void ListaDFechas_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            string servicioS;
            string tiempo;
            servicioS = ListaDServicios.Text;
            tiempo = ListaDFechas.Text;

            if (tiempo == "Todo")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                if (servicioS == "Todo")
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO";
                }
                else
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where servicio = @param1";
                    cmdSelect.Parameters.AddWithValue("@param1", servicioS);                    
                }
                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RegistroSDG.DataSource = dt;
                conexion.Close();
            }
            else if (tiempo == "Hace un día")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                if (servicioS == "Todo")
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where fecha between (SELECT DATEADD(dd,DATEDIFF(dd,0,GETDATE()),-1)) and (SELECT GETDATE())";
                }
                else
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where servicio = @param1 and fecha between (SELECT DATEADD(dd,DATEDIFF(dd,0,GETDATE()),-1)) and (SELECT GETDATE())";
                    cmdSelect.Parameters.AddWithValue("@param1", servicioS);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RegistroSDG.DataSource = dt;
                conexion.Close();
            }
            else if (tiempo == "Desde la semana pasada")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                if (servicioS == "Todo")
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where fecha between (SELECT DATEADD(mm,-1,DATEADD(mm,DATEDIFF(mm,0,GETDATE()),0))) and (SELECT GETDATE())";
                }
                else
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where servicio = @param1 and fecha between (SELECT DATEADD(mm,-1,DATEADD(mm,DATEDIFF(mm,0,GETDATE()),0))) and (SELECT GETDATE())";
                    cmdSelect.Parameters.AddWithValue("@param1", servicioS);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RegistroSDG.DataSource = dt;
                conexion.Close();
            }
            else if (tiempo == "Desde el mes pasado")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                if (servicioS == "Todo")
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where fecha between (SELECT DATEADD(mm,-1,DATEADD(mm,DATEDIFF(mm,0,GETDATE()),0)) 'Primer día del mes pasado') and (SELECT GETDATE() 'Hoy')";
                }
                else
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where servicio = @param1 and fecha between (SELECT DATEADD(mm,-1,DATEADD(mm,DATEDIFF(mm,0,GETDATE()),0)) 'Primer día del mes pasado') and (SELECT GETDATE() 'Hoy') ";
                    cmdSelect.Parameters.AddWithValue("@param1", servicioS);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RegistroSDG.DataSource = dt;
                conexion.Close();
            }
            else if (tiempo == "Desde los ultimos tres meses")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                if (servicioS == "Todo")
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where fecha between (SELECT DATEADD(mm,-3,DATEADD(mm,DATEDIFF(mm,0,GETDATE()),0))) and (SELECT GETDATE() )";
                }
                else
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where servicio = @param1 and fecha between (SELECT DATEADD(mm,-3,DATEADD(mm,DATEDIFF(mm,0,GETDATE()),0))) and (SELECT GETDATE() ) ";
                    cmdSelect.Parameters.AddWithValue("@param1", servicioS);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RegistroSDG.DataSource = dt;
                conexion.Close();
            }
            else if (tiempo == "Desde los ultimos seis meses")
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                if (servicioS == "Todo")
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where fecha between (SELECT DATEADD(mm,-6,DATEADD(mm,DATEDIFF(mm,0,GETDATE()),0)) ) and (SELECT GETDATE()) ";
                }
                else
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where servicio = @param1 and fecha between (SELECT DATEADD(mm,-6,DATEADD(mm,DATEDIFF(mm,0,GETDATE()),0)) ) and (SELECT GETDATE()) ";
                    cmdSelect.Parameters.AddWithValue("@param1", servicioS);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RegistroSDG.DataSource = dt;
                conexion.Close();
            }
            else
            {
                conexion.Open();
                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                if (servicioS == "Todo")
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where fecha between (SELECT DATEADD(yy,-1,DATEADD(yy,DATEDIFF(yy,0,GETDATE()),0))) and (SELECT GETDATE()) ";
                }
                else
                {
                    cmdSelect.CommandText = "Select *from REGISTRO_PEDIDO where servicio = @param1 and fecha between (SELECT DATEADD(yy,-1,DATEADD(yy,DATEDIFF(yy,0,GETDATE()),0))) and (SELECT GETDATE())  ";
                    cmdSelect.Parameters.AddWithValue("@param1", servicioS);
                }
                SqlDataAdapter da = new SqlDataAdapter(cmdSelect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                RegistroSDG.DataSource = dt;
                conexion.Close();
            }
            

            
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            this.Close();
            AgregarServicio agregarServicio = new AgregarServicio();
            agregarServicio.Show();
        }

        private void nombretxtx_TextChanged(object sender, EventArgs e)
        {
            if(rbNombre.Checked== true)
            {
                conexion.Open();
                SqlCommand cmdBusqueda = new SqlCommand();
                cmdBusqueda.Connection = conexion;
                cmdBusqueda.CommandText = "Select num_cliente, nom_residencia, nom_cliente, telefono, correo from CLIENTE where nom_cliente like @param1+ '%'";
                cmdBusqueda.Parameters.AddWithValue("@param1", nombretxtx.Text);

                SqlDataAdapter d2 = new SqlDataAdapter(cmdBusqueda);
                DataTable dt2 = new DataTable();
                d2.Fill(dt2);
                ClientesDt.DataSource = dt2;
                conexion.Close();


                conexion.Close();


            }
            else if(rbResidencia.Checked == true)
            {
                conexion.Open();
                SqlCommand cmdBusqueda = new SqlCommand();
                cmdBusqueda.Connection = conexion;
                cmdBusqueda.CommandText = "Select num_cliente, nom_residencia, nom_cliente, telefono, correo from CLIENTE where nom_residencia like @param1+ '%'";
                cmdBusqueda.Parameters.AddWithValue("@param1", nombretxtx.Text);

                SqlDataAdapter d2 = new SqlDataAdapter(cmdBusqueda);
                DataTable dt2 = new DataTable();
                d2.Fill(dt2);
                ClientesDt.DataSource = dt2;
                conexion.Close();


                conexion.Close();
            }
        }
    }
}
