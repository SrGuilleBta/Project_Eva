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
using System.IO;

namespace ProyectoFinalAvance
{
    public partial class Nomina : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");       
        public Nomina()
        {
            InitializeComponent();
        }

        private void BTvolver_Click(object sender, EventArgs e)
        {
            this.Close();
            InfoTrabajadores abrirInfoT = new InfoTrabajadores();
            abrirInfoT.Show();
        }

        private void btGenerar_Click(object sender, EventArgs e)
        {
            if (validarNumT())
            {
                foreach (Control Juan in GBDatos.Controls)
                {
                    if (Juan is TextBox)
                    {
                        Juan.Text = "";
                    }
                }
                int numT;
                conexion.Open();
                numT = Int16.Parse(TrabajadorNtxt.Text);

                SqlCommand cmdSelect = new SqlCommand();
                cmdSelect.Connection = conexion;
                cmdSelect.CommandText = "Select*from TRABAJADORES where num_trabajador = @param1";
                cmdSelect.Parameters.AddWithValue("@param1", numT);
                SqlDataReader dr = cmdSelect.ExecuteReader();
                if (dr.Read())
                {
                    NombreTxt.Text = dr["nom_apellidos"].ToString();
                    SxHtxt.Text = dr["salario_hora"].ToString();
                    SxHEtxt.Text = dr["salario_hora_extra"].ToString();
                }
                RabajePoFtxt.Text = "0";
                HEtxt.Text = "0";
                CantidadHtxt.Text = "0";
                Sueldotxt.Text = "0";
                conexion.Close();                
                Generartxt.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingresa el dato de manera adecuada");
            }
        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            TrabajadorNtxt.Select();
            FechaHoy.MaxDate = DateTime.Today;
        }

        private void CantidadHtxt_TextChanged(object sender, EventArgs e)
        {
            if (SxHtxt.Text == "" || CantidadHtxt.Text == "")
            {
                
            }
            else
            {
                double horas, horasT, sueldoN;
                horas = double.Parse(SxHtxt.Text);
                horasT = double.Parse(CantidadHtxt.Text);
                sueldoN = horas * horasT;
                Sueldotxt.Text = sueldoN.ToString();
            }
        }

        private void SxHtxt_TextChanged(object sender, EventArgs e)
        {
            if (SxHtxt.Text == ""  || CantidadHtxt.Text == "")
            {
                
            }
            else
            {
                double horas, horasT, sueldoN;
                horas = double.Parse(SxHtxt.Text);
                horasT = double.Parse(CantidadHtxt.Text);
                sueldoN = horas * horasT;
                Sueldotxt.Text = sueldoN.ToString();                
            }
        }

        private void HEtxt_TextChanged(object sender, EventArgs e)
        {
            if (HEtxt.Text == "" || SxHEtxt.Text == "")
            {
                
            }
            else
            {
                double horasE, horasTE, sueldoE;
                horasE = double.Parse(SxHEtxt.Text);
                horasTE = double.Parse(HEtxt.Text);
                sueldoE = horasE * horasTE;
                SxHEFtxt.Text = sueldoE.ToString();
                HEtxt.Text = horasTE.ToString();
            }
        }

        private void SxHEFtxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SxHEtxt_TextChanged(object sender, EventArgs e)
        {
            if (HEtxt.Text == "" || SxHEtxt.Text == "")
            {                
                if (HEtxt.Text == "")
                {
                   
                }
            }
            else
            {
                double horasE, horasTE, sueldoE;
                horasE = double.Parse(SxHEtxt.Text);
                horasTE = double.Parse(HEtxt.Text);
                sueldoE = horasE * horasTE;
                SxHEFtxt.Text = sueldoE.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sueldotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RabajePoFtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void CantRecibidatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha, nombreT, numeroT;
            numeroT = TrabajadorNtxt.Text;
            nombreT = NombreTxt.Text;

            fecha = FechaHoy.Text;
            StreamWriter nomina = File.CreateText(@"" + nombreT + "_" + numeroT + "_" + fecha + ".txt");
            nomina.WriteLine("Recibo nomina                             " + fecha);
            nomina.WriteLine("\n\n\nNombre del Empleado: " + nombreT);
            nomina.WriteLine("\n\nSueldo por hora: $" + SxHtxt.Text + "           Sueldo por hora extra: $" + SxHEtxt.Text);
            nomina.WriteLine("\nSueldo semanal: $" + Sueldotxt.Text);
            nomina.WriteLine("\nTiempo extra: " + HEtxt.Text + "h        Total: $" + SxHEFtxt.Text);
            nomina.WriteLine("\nRebaje: $" + RabajePoFtxt.Text);
            nomina.WriteLine("\n\n                    Recibido: $" + CantRecibidatxt.Text);
            nomina.WriteLine("\n\n\n\n\n      __________________________________");
            nomina.WriteLine("                    FIRMA");
            nomina.Close();

        }

        private void Generartxt_Click(object sender, EventArgs e)
        {
            validarNumT();
            if (validarNumT())
            {


                double sueldoNormal, sueldoExtra, Rebaje, NetoRecibido;
                if (Sueldotxt.Text == "")
                {
                    Sueldotxt.Text = "0";
                    sueldoNormal = 0;
                }
                else
                {
                    sueldoNormal = double.Parse(Sueldotxt.Text);
                }
                sueldoExtra = double.Parse(SxHEFtxt.Text);
                if (RabajePoFtxt.Text == "")
                {
                    RabajePoFtxt.Text = "0";
                    Rebaje = 0;
                }
                else
                {
                    Rebaje = double.Parse(RabajePoFtxt.Text);
                }
                if (CantidadHtxt.Text == "")
                {
                    CantidadHtxt.Text = "0";
                }
                if (HEtxt.Text == "")
                {
                    HEtxt.Text = "0";
                }
                NetoRecibido = sueldoExtra + sueldoNormal - Rebaje;
                CantRecibidatxt.Text = NetoRecibido.ToString();
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ingresa el número de usuario");
            }

           

        }
        private bool validarNumT()
        {
            bool estado = true;
            try
            {
                if (TrabajadorNtxt.Text == "")
                {
                    errorProvider1.SetError(TrabajadorNtxt, "Ingresa el numero de trabajador");
                    estado = false;
                }
                else
                {
                    int numero;
                    numero = Convert.ToInt32(TrabajadorNtxt.Text);
                    errorProvider1.SetError(TrabajadorNtxt, "");
                    if (numero <=0)
                    {
                        errorProvider1.SetError(TrabajadorNtxt, "El numero debe se mayor que 0");
                        estado = false;
                    }
                }
            }
            catch
            {
                errorProvider1.SetError(TrabajadorNtxt, "Por favor ingresa solo números");
                estado = false;
            }
            return estado;
        }

        private void TrabajadorNtxt_Validating(object sender, CancelEventArgs e)
        {
            validarNumT();
        }

        private void GBDatos_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TrabajadorNtxt_TextChanged(object sender, EventArgs e)
        {
            if(TrabajadorNtxt.Text == "")
            {
                button1.Enabled = false;
                Generartxt.Enabled = false;
                foreach (Control Juan in GBDatos.Controls)
                {
                    if (Juan is TextBox)
                    {
                        Juan.Text = "";
                    }
                }
            }
        }

        private void CantidadHtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (!Char.IsControl(e.KeyChar))) e.Handled = true;
        }

        private void HEtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (!Char.IsControl(e.KeyChar))) e.Handled = true;
        }

        private void RabajePoFtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (!Char.IsControl(e.KeyChar))) e.Handled = true;
        }
    }
}
