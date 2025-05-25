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
    public partial class AgregarT : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");

        public AgregarT()
        {
            InitializeComponent();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            InfoTrabajadores abrirInfoT = new InfoTrabajadores();
            abrirInfoT.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            validarformulario();
            if (valiadarNumT() && validarNombre() && validarcurp() && validarDiraccion() && validartelefono() && validarArea() && validarsalarioH() && validarSueldoHoraExtra() && validarNumServicio())
            {
                conexion.Open();

                SqlCommand cmdInsertar = new SqlCommand();
                cmdInsertar.Connection = conexion;
                cmdInsertar.CommandText = "INSERT INTO TRABAJADORES VALUES (@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9)";
                cmdInsertar.Parameters.AddWithValue("@param1", Convert.ToInt32(NumTabajadortxt.Text));
                cmdInsertar.Parameters.AddWithValue("@param2", Nombretxt.Text);
                cmdInsertar.Parameters.AddWithValue("@param3", curptxt.Text);
                cmdInsertar.Parameters.AddWithValue("@param4", Direcciontxt.Text);
                cmdInsertar.Parameters.AddWithValue("@param5", Convert.ToInt32(telefonotxt.Text));
                cmdInsertar.Parameters.AddWithValue("@param6", areatxt.Text);
                cmdInsertar.Parameters.AddWithValue("@param7", Convert.ToInt32(sueldoHoratxt.Text));
                cmdInsertar.Parameters.AddWithValue("@param8", Convert.ToInt32(sueldohoraEtxt.Text));
                cmdInsertar.Parameters.AddWithValue("@param9", Convert.ToInt32(NumSertxt.Text));
                cmdInsertar.ExecuteNonQuery();


                conexion.Close();
            }
        }
        private bool valiadarNumT()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (NumTabajadortxt.Text == "")
                {
                    errorProvider1.SetError(NumTabajadortxt, "Ingresa el número de trabajador");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(NumTabajadortxt.Text);
                    if (numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select num_trabajador from TRABAJADORES where num_trabajador = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(NumTabajadortxt, "Ya existe un trabajador con ese número de registro");
                            estado = false;
                        }
                        else
                        {
                            errorProvider1.SetError(NumTabajadortxt, "");
                            estado = true;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(NumTabajadortxt, "El numero de trabajador debe ser mayor a 0");
                        estado = false;

                    }

                }

            }
            catch
            {
                errorProvider1.SetError(NumTabajadortxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void NumTabajadortxt_Validating(object sender, CancelEventArgs e)
        {
            valiadarNumT();
        }
        private bool validarNombre()
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
            validarNombre();
        }
        private bool validarcurp()
        {
            bool estado = true;
            if (curptxt.Text == "")
            {
                errorProvider1.SetError(curptxt, "Ingresa un curp ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(curptxt, "");
                estado = true;
            }
            return estado;
        }

        private void curptxt_Validating(object sender, CancelEventArgs e)
        {
            validarcurp();
        }
        private bool validarDiraccion()
        {
            bool estado = true;
            if (Direcciontxt.Text == "")
            {
                errorProvider1.SetError(Direcciontxt, "Ingresa una dirección ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(Direcciontxt, "");
                estado = true;
            }
            return estado;
        }

        private void Direcciontxt_Validating(object sender, CancelEventArgs e)
        {
            validarDiraccion();
        }
        private bool validartelefono()
        {
            bool estado = true;
            try
            {
                if (telefonotxt.Text == "")
                {
                    errorProvider1.SetError(telefonotxt, "Ingresa un número");
                    estado = false;
                }
                else
                {
                    int edad;
                    edad = Convert.ToInt32(telefonotxt.Text);
                    errorProvider1.SetError(telefonotxt, "");
                    if (edad < 0)
                    {
                        errorProvider1.SetError(telefonotxt, "");
                        estado = true;
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(telefonotxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void telefonotxt_Validating(object sender, CancelEventArgs e)
        {
            validartelefono();
        }
        private bool validarArea()
        {
            bool estado = true;
            if (areatxt.Text == "")
            {
                errorProvider1.SetError(areatxt, "Ingresa una area de trabajo ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(areatxt, "");
                estado = true;
            }
            return estado;
        }

        private void areatxt_Validating(object sender, CancelEventArgs e)
        {
            validarArea();
        }
        private bool validarsalarioH()
        {
            bool estado = true;
            try
            {
                if (sueldoHoratxt.Text == "")
                {
                    errorProvider1.SetError(sueldoHoratxt, "Ingresa un sueldo");
                    estado = false;
                }
                else
                {
                    int edad;
                    edad = Convert.ToInt32(sueldoHoratxt.Text);
                    errorProvider1.SetError(sueldoHoratxt, "");
                    if (edad <= 0)
                    {
                        errorProvider1.SetError(sueldoHoratxt, "El salario debe ser mayor a 0");
                        estado = false;
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(sueldoHoratxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void sueldoHoratxt_Validating(object sender, CancelEventArgs e)
        {
            validarsalarioH();
        }
        private bool validarSueldoHoraExtra()
        {
            bool estado = true;
            try
            {
                if (sueldohoraEtxt.Text == "")
                {
                    errorProvider1.SetError(sueldohoraEtxt, "Ingresa un sueldo");
                    estado = false;
                }
                else
                {
                    int edad;
                    edad = Convert.ToInt32(sueldohoraEtxt.Text);
                    errorProvider1.SetError(sueldohoraEtxt, "");
                    if (edad <= 0)
                    {
                        errorProvider1.SetError(sueldohoraEtxt, "El salario debe ser mayor a 0");
                        estado = false;
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(sueldohoraEtxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void sueldohoraEtxt_Validating(object sender, CancelEventArgs e)
        {
            validarSueldoHoraExtra();
        }
        private bool validarNumServicio()
        {
            bool estado = true;
            try
            {
                if (NumSertxt.Text == "")
                {
                    errorProvider1.SetError(NumSertxt, "Ingresa un número de servicio");
                    estado = false;
                }
                else
                {
                    int edad;
                    edad = Convert.ToInt32(NumSertxt.Text);
                    errorProvider1.SetError(NumSertxt, "");
                    if (edad <= 0)
                    {
                        errorProvider1.SetError(NumSertxt, "El número de servicio debe ser mayor a 0");
                        estado = false;
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(NumSertxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }

        private void NumSertxt_Validating(object sender, CancelEventArgs e)
        {
            validarNumServicio();
        }
        private void validarformulario()
        {
            bool numeroTrabajador = valiadarNumT();
            bool nombreCompleto = validarNombre();
            bool curp = validarcurp();
            bool direccion = validarDiraccion();
            bool telefono = validartelefono();
            bool area = validarArea();
            bool salarioHora = validarsalarioH();
            bool salarioExtra = validarSueldoHoraExtra();
            bool numeroser = validarNumServicio();

            if(numeroTrabajador && nombreCompleto && curp && direccion && telefono && area && salarioHora && salarioExtra && numeroser)
            {
                MessageBox.Show("Se agregó el trabajador de manera exitosa");
            }
            else
            {
                MessageBox.Show("Ingresa los datos correctos");
            }

        }
    }
}
