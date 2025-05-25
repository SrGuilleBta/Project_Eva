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
    public partial class Configuracion : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");
        public Configuracion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PantallaDInicio pantallaDInicio = new PantallaDInicio();
            pantallaDInicio.Show();
        }

        private void BAceptar_Click(object sender, EventArgs e)
        {
            if(rbAgregar.Checked == true)
            {
                
                bool usuario = validarUsuarioNuevo();
                bool contraseña = validarContraseña();
                if (usuario && contraseña)
                {

                    conexion.Open();

                    SqlCommand cmdInsert = new SqlCommand();
                    cmdInsert.Connection = conexion;
                    cmdInsert.CommandText = "INSERT INTO USUARIO_CONTRASEÑA VALUES (@param1, @param2)";
                    cmdInsert.Parameters.AddWithValue("@param1", Convert.ToInt32(Usuariotxt.Text));
                    cmdInsert.Parameters.AddWithValue("@param2", Contraseñatxt.Text);
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Usuario y Contraseña agregada con exito");

                    conexion.Close();
                }
                else
                {
                    validarFormularioAgregar();
                }

            }
            else if(rbActualizar.Checked == true)
            {                
                
                bool usuario = validarUsuarioActualizarEliminar();
                bool contraseña = validarContraseña();
                if (usuario && contraseña)
                {
                    conexion.Open();

                    SqlCommand cmdUpdate = new SqlCommand();
                    cmdUpdate.Connection = conexion;
                    cmdUpdate.CommandText = "UPDATE USUARIO_CONTRASEÑA SET contraseña = @param2 where usuario = @param1";
                    cmdUpdate.Parameters.AddWithValue("@param1", Convert.ToInt32(Usuariotxt.Text));
                    cmdUpdate.Parameters.AddWithValue("@param2", Contraseñatxt.Text);

                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Contraseña actualizada con exito");

                    conexion.Close();
                }
                else
                {
                    validarFormularioActualizarOeliminar();
                }
            }
            else if(rbEliminar.Checked == true)
            {
               
                bool usuario = validarUsuarioActualizarEliminar();
                bool contraseña = validarContraseña();
                if (usuario && contraseña)
                {
                    conexion.Open();
                    DialogResult Resultado;
                    SqlCommand cmdDelete = new SqlCommand();
                    cmdDelete.Connection = conexion;
                    cmdDelete.CommandText = "Delete USUARIO_CONTRASEÑA where usuario = @param1 and contraseña = @param2";
                    cmdDelete.Parameters.AddWithValue("@param1", Convert.ToInt32(Usuariotxt.Text));
                    cmdDelete.Parameters.AddWithValue("@param2", Contraseñatxt.Text);

                    Resultado = MessageBox.Show("Desea eliminar el usuario seleccionado?", "Eliminar Usuario", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (Resultado == DialogResult.Yes)
                    {
                        cmdDelete.ExecuteNonQuery();
                        MessageBox.Show("Usuario eliminado con exito");
                    }
                    conexion.Close();
                }
                else
                {
                    validarFormularioActualizarOeliminar();
                }
            }
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            rbAgregar.Checked = true;
        }
        private bool validarUsuarioNuevo()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (Usuariotxt.Text == "")
                {
                    errorProvider1.SetError(Usuariotxt, "Ingresa el usuario");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(Usuariotxt.Text);
                    if (numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select usuario from USUARIO_CONTRASEÑA where usuario = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(Usuariotxt, "Ya existe un usuario con ese número");
                            estado = false;
                        }
                        else
                        {
                            errorProvider1.SetError(Usuariotxt, "");
                            estado = true;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(Usuariotxt, "El usuario debe ser mayor a 0");
                        estado = false;

                    }

                }

            }
            catch
            {
                errorProvider1.SetError(Usuariotxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }
        private bool validarContraseña()
        {
            bool estado = true;
            if (Contraseñatxt.Text == "")
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

        private void Usuariotxt_Validating(object sender, CancelEventArgs e)
        {
            if (rbAgregar.Checked == true)
            {
                validarUsuarioNuevo();
            }
            else
            {
                validarUsuarioActualizarEliminar();
            }
        }
        private bool validarUsuarioActualizarEliminar()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (Usuariotxt.Text == "")
                {
                    errorProvider1.SetError(Usuariotxt, "Ingresa el usuario");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(Usuariotxt.Text);
                    if (numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select usuario from USUARIO_CONTRASEÑA where usuario = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(Usuariotxt, "");
                            estado = true;
                        }
                        else
                        {
                            errorProvider1.SetError(Usuariotxt, "No existe un usuario con ese número");
                            estado = false;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(Usuariotxt, "El usuario debe ser mayor a 0");
                        estado = false;

                    }

                }

            }
            catch
            {
                errorProvider1.SetError(Usuariotxt, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }
        

        private void Contraseñatxt_Validating(object sender, CancelEventArgs e)
        {
            validarContraseña();
        }
        private void validarFormularioAgregar()
        {
            bool usuario = validarUsuarioNuevo();
            bool contraseña = validarContraseña();
            if(usuario && contraseña)
            {

            }
            {
                MessageBox.Show("Ingresa los datos correctos o faltantes");
            }
        }
        private void validarFormularioActualizarOeliminar()
        {
            bool usuario = validarUsuarioActualizarEliminar();
            bool contraseña = validarContraseña();
            if (usuario && contraseña)
            {

            }
            {
                MessageBox.Show("Ingresa los datos correctos o faltantes");
            }
        }

        private void Usuariotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Usuario_Click(object sender, EventArgs e)
        {

        }

        private void Contraseñatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Contraseña_Click(object sender, EventArgs e)
        {

        }

        private void rbActualizar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
