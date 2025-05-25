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
    public partial class AgregarProducto : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");

        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario abrirInvnetario = new Inventario();
            abrirInvnetario.Show();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            validarFormulario();
            if (validarNumMaterial() && validadNombre() && validarCantidad() && validadArea() && validarNumServicio())
            {
                conexion.Open();

                SqlCommand cmdInsertar = new SqlCommand();
                cmdInsertar.Connection = conexion;
                cmdInsertar.CommandText = "Insert INTO INVENTARIO values (@param1, @param2, @param3, @param4, @param5)";
                cmdInsertar.Parameters.AddWithValue("@param1", Convert.ToInt32(NumMateriatxt.Text));
                cmdInsertar.Parameters.AddWithValue("@param2", Nombretxt.Text);
                cmdInsertar.Parameters.AddWithValue("@param3", Convert.ToInt32(cantidadtxt.Text));
                cmdInsertar.Parameters.AddWithValue("@param4", Areatxt.Text);
                cmdInsertar.Parameters.AddWithValue("@param5", Convert.ToInt32(SerNumtxt.Text));
                cmdInsertar.ExecuteNonQuery();

                conexion.Close();
            }
            
        }
        private bool validarNumMaterial()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (NumMateriatxt.Text == "")
                {
                    errorProvider1.SetError(NumMateriatxt, "Ingresa el número de material");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(NumMateriatxt.Text);                                        
                    if(numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select num_material from INVENTARIO where num_material = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(NumMateriatxt, "Ya existe un producto con ese número de registro");
                            estado = false;
                        }
                        else
                        {
                            errorProvider1.SetError(NumMateriatxt, "");
                            estado = true;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(NumMateriatxt, "El numero de material debe ser mayor a 0");
                        estado = false;

                    }
                    
                }
                
            }
            catch
            {
                errorProvider1.SetError(NumMateriatxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void NumMateriatxt_Validating(object sender, CancelEventArgs e)
        {
            validarNumMaterial();
        }
        private bool validadNombre()
        {
            bool estado = true;
            if (Nombretxt.Text == "")
            {
                errorProvider1.SetError(Nombretxt, "Ingresa un nombre ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(Nombretxt, "");
                estado = true;
            }
            return estado;
        }

        private void Nombretxt_Validating(object sender, CancelEventArgs e)
        {
            validadNombre();
        }
        private bool validarCantidad()
        {
            bool estado = true;
            try
            {
                if (cantidadtxt.Text == "")
                {
                    errorProvider1.SetError(cantidadtxt, "Ingresa una cantidad");
                    estado = false;
                }
                else
                {
                    int cant;
                    cant = Convert.ToInt32(cantidadtxt.Text);
                    errorProvider1.SetError(cantidadtxt, "");
                    if (cant < 0)
                    {
                        errorProvider1.SetError(cantidadtxt, "La cantidad debe de ser superior a 0");
                        estado = false;
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(cantidadtxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void cantidadtxt_Validating(object sender, CancelEventArgs e)
        {
            validarCantidad();
        }
        private bool validadArea()
        {
            bool estado = true;
            if (Areatxt.Text == "")
            {
                errorProvider1.SetError(Areatxt, "Ingresa el area de pertenencia ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(Areatxt, "");
                estado = true;
            }
            return estado;
        }

        private void Areatxt_Validating(object sender, CancelEventArgs e)
        {
            validadArea();
        }
        private bool validarNumServicio()
        {
            bool estado = true;
            try
            {
                if (SerNumtxt.Text == "")
                {
                    errorProvider1.SetError(SerNumtxt, "Ingresa un número de servicio");
                    estado = false;
                }
                else
                {
                    int edad;
                    edad = Convert.ToInt32(SerNumtxt.Text);
                    errorProvider1.SetError(SerNumtxt, "");
                    if (edad < 0)
                    {
                        errorProvider1.SetError(SerNumtxt, "El número debe ser superior a 0");
                        estado = false;
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(SerNumtxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void SerNumtxt_Validating(object sender, CancelEventArgs e)
        {
            validarNumServicio();
        }
        private void validarFormulario()
        {
            bool numpro = validarNumMaterial();
            bool nompro = validadNombre();
            bool cant = validarCantidad();
            bool area = validadArea();
            bool numser = validarNumServicio();
            if (numpro && nompro && cant && area && numser)
            {
                MessageBox.Show("Producto agregado con exito");
            }
            else
            {
                MessageBox.Show("Ingresa los datos correctos o faltantes");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
