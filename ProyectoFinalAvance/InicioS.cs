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
using System.Configuration;

namespace ProyectoFinalAvance
{
    public partial class PantallaDInicio : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");
        public PantallaDInicio()
        {
            InitializeComponent();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            bool validarU = validarUsuario();
            bool validarC = validadContraseña();
            if (validarU && validarC)
            {
                conexion.Open();
                SqlCommand cmdComparar = new SqlCommand();
                cmdComparar.Connection = conexion;
                cmdComparar.CommandText = "Select usuario, contraseña from USUARIO_CONTRASEÑA where usuario = " + Usuariotxt.Text + " and contraseña = '" + Contraseñatxt.Text + "'";

                SqlDataReader dr = cmdComparar.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    PantallaDInicio.AbrirPI();
                }
                else
                {
                    MessageBox.Show("El usuario no existe o la contraseña no es correcta");
                }

                conexion.Close();
            }
            else
            {
                MessageBox.Show("Ingresa los datos correctos");
            }       
            
        }
        static void AbrirPI()
        {
            PaginaPrincipal PaginaP = new PaginaPrincipal();
            //PaginaP.MdiParent = this;
            PaginaP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Usuariotxt_Validating(object sender, CancelEventArgs e)
        {
            validarUsuario();
        }

        private void Contraseñatxt_Validating(object sender, CancelEventArgs e)
        {
            validadContraseña();
        }
        private bool validarUsuario()
        {
            bool estado = true;
            try
            {
                if (Usuariotxt.Text == "")
                {
                    errorProvider1.SetError(Usuariotxt, "Ingresa un usuario");
                    estado = false;
                }
                else
                {
                    int usurionum;
                    usurionum = Convert.ToInt32(Usuariotxt.Text);
                    if(usurionum <= 0)
                    {
                        errorProvider1.SetError(Usuariotxt, "El número de ususario debe ser mayor a 0");
                        estado = false;
                    }
                    else
                    {
                        errorProvider1.SetError(Usuariotxt, "");
                        estado = true;
                    }
                    
                }
            }
            catch
            {
                errorProvider1.SetError(Usuariotxt, "Solo se permiten números");
                estado = false;
            }
            return estado;
        }
        private bool validadContraseña()
        {
            bool estado = true;
            if(Contraseñatxt.Text == "")
            {
                errorProvider1.SetError(Contraseñatxt, "Ingresa una contraseña ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(Contraseñatxt, "");
                estado = true;
            }
            return estado;            
        }

        private void PantallaDInicio_Load(object sender, EventArgs e)
        {
            this.Contraseñatxt.PasswordChar = '*';
        }

        private void btConfiguracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }       
}
