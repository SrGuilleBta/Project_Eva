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
    public partial class ActualizaroEliminarT : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");
        public ActualizaroEliminarT()
        {
            InitializeComponent();
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            InfoTrabajadores abrirInfoT = new InfoTrabajadores();
            abrirInfoT.Show();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (rbActualizar.Checked == true)
            {
                validarformulario();
                if (validarNumT() && validarNombre() && validarcurp() && validarDiraccion() && validartelefono() && validarArea() && validarsalarioH() && validarSueldoHoraExtra() && validarNumServicio())
                {
                    conexion.Open();
                    SqlCommand cmdUpdate = new SqlCommand();
                    cmdUpdate.Connection = conexion;
                    cmdUpdate.CommandText = "UPDATE TRABAJADORES SET nom_apellidos = @param2, curp = @param3, direccion = @param4, telefono = @param5, area_trabajo = @param6, salario_hora = @param7, salario_hora_extra = @param8, num_servicio = @param9 where num_trabajador = @param1";
                    cmdUpdate.Parameters.AddWithValue("@param1", Convert.ToInt32(NumTabajadortxt.Text));
                    cmdUpdate.Parameters.AddWithValue("@param2", Nombretxt.Text);
                    cmdUpdate.Parameters.AddWithValue("@param3", curptxt.Text);
                    cmdUpdate.Parameters.AddWithValue("@param4", Direcciontxt.Text);
                    cmdUpdate.Parameters.AddWithValue("@param5", telefonotxt.Text);
                    cmdUpdate.Parameters.AddWithValue("@param6", areatxt.Text);
                    cmdUpdate.Parameters.AddWithValue("@param7", Convert.ToInt32(sueldoHoratxt.Text));
                    cmdUpdate.Parameters.AddWithValue("@param8", Convert.ToInt32(sueldohoraEtxt.Text));
                    cmdUpdate.Parameters.AddWithValue("@param9", Convert.ToInt32(NumSertxt.Text));
                    cmdUpdate.ExecuteNonQuery();

                    conexion.Close();
                }
            }
            else if (rbEliminar.Checked == true)
            {

                bool numeroTrabajador = validarNumT();
                if (validarNumT())
                {
                    conexion.Open();
                    DialogResult Resultado;
                    SqlCommand cmdDelete = new SqlCommand();
                    cmdDelete.Connection = conexion;
                    cmdDelete.CommandText = "Delete TRABAJADORES where num_trabajador = @param1";
                    cmdDelete.Parameters.AddWithValue("@param1", Convert.ToInt32(NumTabajadortxt.Text));

                    Resultado = MessageBox.Show("Desea eliminar el trabajasor seleccionado?", "Eliminar Trabajador", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (Resultado == DialogResult.Yes)
                    {
                        cmdDelete.ExecuteNonQuery();
                        MessageBox.Show("Trabajador eliminado con exito");
                    }
                    conexion.Close();
                }
                else
                {
                    validarElimnarT();
                }
            }
        }

        private void ActualizaroEliminarT_Load(object sender, EventArgs e)
        {
            rbActualizar.Checked = true;
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            foreach(Control juan in this.Controls)
            {
                if(juan is TextBox)
                {
                    juan.Enabled = false;
                    juan.Text = "";
                }
            }
            NumTabajadortxt.Enabled = true;
        }

        private void rbActualizar_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control juan in this.Controls)
            {
                if (juan is TextBox)
                {
                    juan.Enabled = true;
                }
            }
        }
        private bool validarNumT()
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
                            errorProvider1.SetError(NumTabajadortxt, "");
                            estado = true;
                        }
                        else
                        {
                            errorProvider1.SetError(NumTabajadortxt, "No existe un número de trabajador con ese número");
                            estado = false;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(NumTabajadortxt, "El número de trabajador debe ser mayor a 0");
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

        private void NumTabajadortxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumTabajadortxt_Validating(object sender, CancelEventArgs e)
        {
            validarNumT();
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

        private void Nombretxt_Validating(object sender, CancelEventArgs e)
        {
            validarNombre();
        }

        private void curptxt_Validating(object sender, CancelEventArgs e)
        {
            validarcurp();
        }

        private void Direcciontxt_Validating(object sender, CancelEventArgs e)
        {
            validarDiraccion();
        }

        private bool validartelefono()
        {
            bool estado = true;
            if (telefonotxt.Text == "")
            {
                errorProvider1.SetError(telefonotxt, "Ingresa una telefono ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(telefonotxt, "");
                estado = true;
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
                errorProvider1.SetError(areatxt, "Ingresa un area ");
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
            bool numeroTrabajador = validarNumT();
            bool nombreCompleto = validarNombre();
            bool curp = validarcurp();
            bool direccion = validarDiraccion();
            bool telefono = validartelefono();
            bool area = validarArea();
            bool salarioHora = validarsalarioH();
            bool salarioExtra = validarSueldoHoraExtra();
            bool numeroser = validarNumServicio();

            if (numeroTrabajador && nombreCompleto && curp && direccion && telefono && area && salarioHora && salarioExtra && numeroser)
            {
                MessageBox.Show("Se actualizaron los datos de manera exitosa");
            }
            else
            {
                MessageBox.Show("Ingresa datos correctos");
            }
        }
        private void validarElimnarT()
        {
            bool numeroTrabajador = validarNumT();
            if (numeroTrabajador)
            {

            }
            {
                MessageBox.Show("Ingresa los datos correctos");
            }
        }
    }
}
