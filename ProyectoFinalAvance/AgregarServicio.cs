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
    public partial class AgregarServicio : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");
        public AgregarServicio()
        {
            InitializeComponent();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistroDServicios2 abrirRDServicios = new RegistroDServicios2();
            abrirRDServicios.Show();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (rbClienteExistente.Checked == true)
            {
                validarformularioClienteExisitente();
                bool numPedido = validarnumpedido();
                bool servicio = validarnumservicio();
                bool fecha = validarFecha();
                bool numCliente = validarNumServicioClienteExistente();
                bool numServicio = validarnumservicio();
                if (numPedido && servicio && fecha && numCliente && numServicio)
                {

                    conexion.Open();

                    SqlCommand cmdInsertar = new SqlCommand();
                    cmdInsertar.Connection = conexion;
                    cmdInsertar.CommandText = "INSERT INTO REGISTRO_PEDIDO VALUES (@param1, @param2, @param3, @param4, @param5)";
                    cmdInsertar.Parameters.AddWithValue("@param1", Convert.ToInt32(NumPedidotxt.Text));
                    cmdInsertar.Parameters.AddWithValue("@param2", Servciotxt.Text);
                    cmdInsertar.Parameters.AddWithValue("@param3", Fechatxt.Text);
                    cmdInsertar.Parameters.AddWithValue("@param4", Convert.ToInt32(NumClientetxt.Text));
                    cmdInsertar.Parameters.AddWithValue("@param5", Convert.ToInt32(NumServicio.Text));
                    cmdInsertar.ExecuteNonQuery();



                    conexion.Close();
                }
            }
            else if(rbClienteNuevo.Checked == true)
            {
                validarFormularioNuevoCliente();
                bool numPedido = validarnumpedido();
                bool servicio = validarservicio();
                bool fecha = validarFecha();
                bool numCliente = numClienteNuevo();
                bool numServicio = validarnumservicio();
                bool residencia = validarResidencia();
                bool nombreCliente = validarNomCliente();
                bool telefono = validartelefono();
                bool correo = validarCorreo();
                if (numPedido && servicio && fecha && numCliente && numServicio && residencia && nombreCliente && telefono && correo)
                {

                    conexion.Open();

                    SqlCommand cmdInsertar = new SqlCommand();
                    cmdInsertar.Connection = conexion;
                    cmdInsertar.CommandText = "INSERT INTO REGISTRO_PEDIDO VALUES (@param1, @param2, @param3, @param4, @param5)";
                    cmdInsertar.Parameters.AddWithValue("@param1", Convert.ToInt32(NumPedidotxt.Text));
                    cmdInsertar.Parameters.AddWithValue("@param2", Servciotxt.Text);
                    cmdInsertar.Parameters.AddWithValue("@param3", Fechatxt.Text);
                    cmdInsertar.Parameters.AddWithValue("@param4", Convert.ToInt32(NumClientetxt.Text));
                    cmdInsertar.Parameters.AddWithValue("@param5", Convert.ToInt32(NumServicio.Text));
                    cmdInsertar.ExecuteNonQuery();
                    SqlCommand cmdInsertarCliente = new SqlCommand();
                    cmdInsertarCliente.Connection = conexion;
                    cmdInsertarCliente.CommandText = "INSERT INTO CLIENTE VALUES (@param1, @param2, @param3, @param4, @param5, '', '')";
                    cmdInsertarCliente.Parameters.AddWithValue("@param1", Convert.ToInt32(NumClientetxt.Text));
                    cmdInsertarCliente.Parameters.AddWithValue("@param2", residenciatxt.Text);
                    cmdInsertarCliente.Parameters.AddWithValue("@param3", nombreclientetxt.Text);
                    cmdInsertarCliente.Parameters.AddWithValue("@param4", telefonotxt.Text);
                    cmdInsertarCliente.Parameters.AddWithValue("@param5", correotxt.Text);

                    cmdInsertarCliente.ExecuteNonQuery();
                    
                    conexion.Close();
                }
            }
        }
        private bool validarnumpedido()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (NumPedidotxt.Text == "")
                {
                    errorProvider1.SetError(NumPedidotxt, "Ingresa el número de pedido");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(NumPedidotxt.Text);
                    if (numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select num_pedido from REGISTRO_PEDIDO where num_pedido = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(NumPedidotxt, "Ya existe un pedido con ese número de registro");
                            estado = false;
                        }
                        else
                        {
                            errorProvider1.SetError(NumPedidotxt, "");
                            estado = true;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(NumPedidotxt, "El numero de servicio debe ser mayor a 0");
                        estado = false;

                    }

                }

            }
            catch
            {
                errorProvider1.SetError(NumPedidotxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void NumPedidotxt_Validating(object sender, CancelEventArgs e)
        {
            validarnumpedido();
        }
        private bool validarservicio()
        {
            bool estado = true;
            if (Servciotxt.Text == "")
            {
                errorProvider1.SetError(Servciotxt, "Ingresa un servicio ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(Servciotxt, "");
                estado = true;
            }
            return estado;
        }

        private void Servciotxt_Validating(object sender, CancelEventArgs e)
        {
            validarservicio();
        }
        private bool validarFecha()
        {

            bool estado = true;
            if (Fechatxt.Text == "")
            {
                errorProvider1.SetError(Fechatxt, "Ingresa una fecha ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(Fechatxt, "");
                estado = true;
            }
            return estado;
        }

        private void Fechatxt_Validating(object sender, CancelEventArgs e)
        {
            validarFecha();
        }
        private bool validarNumServicioClienteExistente()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (NumClientetxt.Text == "")
                {
                    errorProvider1.SetError(NumClientetxt, "Ingresa el número de cliente");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(NumClientetxt.Text);
                    if (numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select num_cliente from CLIENTE where num_cliente = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(NumClientetxt, "");
                            estado = true;
                        }
                        else
                        {
                            errorProvider1.SetError(NumClientetxt, "No existe un cliente con ese número");
                            estado = false;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(NumClientetxt, "El numero de cliente debe ser mayor a 0");
                        estado = false;

                    }

                }

            }
            catch
            {
                errorProvider1.SetError(NumClientetxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void NumClientetxt_Validating(object sender, CancelEventArgs e)
        {
            if (rbClienteExistente.Checked == true)
            {
                validarNumServicioClienteExistente();
            }
            else if(rbClienteNuevo.Checked == true)
            {
                numClienteNuevo();
            }
        }
        private bool validarnumservicio()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (NumServicio.Text == "")
                {
                    errorProvider1.SetError(NumServicio, "Ingresa el número de servicio");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(NumServicio.Text);
                    if (numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select num_servicio from SERVICIOS where num_servicio = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(NumServicio, "");
                            estado = true;
                        }
                        else
                        {
                            errorProvider1.SetError(NumServicio, "No existe un servicio con ese número");
                            estado = false;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(NumServicio, "El numero de servicio debe ser mayor a 0");
                        estado = false;

                    }

                }

            }
            catch
            {
                errorProvider1.SetError(NumServicio, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void NumServicio_Validating(object sender, CancelEventArgs e)
        {
            validarnumservicio();
        }
        private void validarformularioClienteExisitente()
        {
            bool  numPedido = validarnumpedido();
            bool servicio = validarservicio();
            bool fecha = validarFecha();
            bool numCliente = validarNumServicioClienteExistente();
            bool numServicio = validarnumservicio();
            if(numPedido && servicio && fecha && numCliente && numServicio)
            {
                MessageBox.Show("Se agregó el servicio de manera exitosa");
            }
            else
            {
                MessageBox.Show("Ingresa los datos correctos");
            }
        }

        private void AgregarServicio_Load(object sender, EventArgs e)
        {
            rbClienteExistente.Checked = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rbClienteExistente_CheckedChanged(object sender, EventArgs e)
        {
            residenciatxt.Enabled = false;
            nombreclientetxt.Enabled = false;
            telefonotxt.Enabled = false;
            correotxt.Enabled = false;
        }

        private void rbClienteNuevo_CheckedChanged(object sender, EventArgs e)
        {
            residenciatxt.Enabled = true;
            nombreclientetxt.Enabled = true;
            telefonotxt.Enabled = true;
            correotxt.Enabled = true;
        }
        private bool numClienteNuevo()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (NumClientetxt.Text == "")
                {
                    errorProvider1.SetError(NumClientetxt, "Ingresa el número de cliente");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(NumClientetxt.Text);
                    if (numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select num_cliente from CLIENTE where num_cliente = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(NumClientetxt, "Ya existe un cliente con ese número");
                            estado = false;
                        }
                        else
                        {
                            errorProvider1.SetError(NumClientetxt, "");
                            estado = true;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(NumClientetxt, "El numero de cliente debe ser mayor a 0");
                        estado = false;

                    }

                }

            }
            catch
            {
                errorProvider1.SetError(NumClientetxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }
        private bool validarResidencia()
        {
            bool estado = true;
            if (residenciatxt.Text == "")
            {
                errorProvider1.SetError(residenciatxt, "Ingresa una residencia");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(residenciatxt, "");
                estado = true;
            }
            return estado;
        }

        private void residenciatxt_Validating(object sender, CancelEventArgs e)
        {
            validarResidencia();
        }
        private bool validarNomCliente()
        {
            bool estado = true;
            if (nombreclientetxt.Text == "")
            {
                errorProvider1.SetError(nombreclientetxt, "Ingresa un nombre de cliente");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(nombreclientetxt, "");
                estado = true;
            }
            return estado;
        }

        private void nombreclientetxt_Validating(object sender, CancelEventArgs e)
        {
            validarNomCliente();
        }
        private bool validartelefono()
        {
            bool estado = true;
            if (telefonotxt.Text == "")
            {
                errorProvider1.SetError(telefonotxt, "Ingresa un telefono");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(telefonotxt, "");
                estado = true;
            }
            return estado;
        }
        private bool validarCorreo()
        {
            bool estado = true;
            if (correotxt.Text == "")
            {
                errorProvider1.SetError(correotxt, "Ingresa un correo");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(correotxt, "");
                estado = true;
            }
            return estado;
        }

        private void telefonotxt_Validating(object sender, CancelEventArgs e)
        {
            validartelefono();
        }

        private void correotxt_Validating(object sender, CancelEventArgs e)
        {
            validarCorreo();
        }
        private void validarFormularioNuevoCliente()
        {
            bool numPedido = validarnumpedido();
            bool servicio = validarservicio();
            bool fecha = validarFecha();
            bool numCliente = numClienteNuevo();
            bool numServicio = validarnumservicio();
            bool residencia = validarResidencia();
            bool nombreCliente = validarNomCliente();
            bool telefono = validartelefono();
            bool correo = validarCorreo();
            if(numPedido && servicio && fecha && numCliente && numServicio && residencia && nombreCliente && telefono && correo)
            {
                MessageBox.Show("Se agregó el servicio y el cliente de manera exitosa");
            }
            else
            {
                MessageBox.Show("Ingresa los datos correctos o faltantes");
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NumClientetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
