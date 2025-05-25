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
    public partial class ActualizarEliminarP : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source = DESKTOP-4DRCMQF\\SQLEXPRESS;Initial Catalog = WALLE_LABS; Integrated Security = True");

        public ActualizarEliminarP()
        {
            InitializeComponent();
        }

        private void ActualizarEliminarP_Load(object sender, EventArgs e)
        {
            rbActualizar.Checked = true;
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario abrirInvnetario = new Inventario();
            abrirInvnetario.Show();
        }

        private void rbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            cantidadNUD.Enabled = false;
        }

        private void rbActualizar_CheckedChanged(object sender, EventArgs e)
        {
            cantidadNUD.Enabled = true;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (validarNumMaterial())
            {
                if (rbActualizar.Checked == true)
                {
                    conexion.Open();

                    //int cantidad = Convert.ToInt32(cantidadNUD.Value);
                    SqlCommand cmdUpdate = new SqlCommand();
                    cmdUpdate.Connection = conexion;
                    cmdUpdate.CommandText = "UPDATE INVENTARIO SET cantidad = @param1 where num_material = @param2";
                    cmdUpdate.Parameters.AddWithValue("@param1", Convert.ToInt32(cantidadNUD.Value));
                    cmdUpdate.Parameters.AddWithValue("@param2", Convert.ToInt32(NumPro.Text));

                    cmdUpdate.ExecuteNonQuery();
                    MessageBox.Show("Producto actualizado con exito");

                    conexion.Close();
                }
                else if (rbEliminar.Checked == true)
                {
                    conexion.Open();
                    DialogResult Resultado;
                    SqlCommand cmdDelete = new SqlCommand();
                    cmdDelete.Connection = conexion;
                    cmdDelete.CommandText = "Delete INVENTARIO where num_material = @param1";
                    cmdDelete.Parameters.AddWithValue("@param1", Convert.ToInt32(NumPro.Text));

                    Resultado = MessageBox.Show("Desea eliminar el producto seleccionado?", "Eliminar Producto", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (Resultado == DialogResult.Yes)
                    {
                        cmdDelete.ExecuteNonQuery();
                        MessageBox.Show("Producto eliminado con exito");
                    }
                    conexion.Close();
                }
            }
        }

        private void NumPro_Validating(object sender, CancelEventArgs e)
        {
            validarNumMaterial();
        }
        private bool validarNumMaterial()
        {
            bool estado = true;
            try
            {
                estado = true;
                if (NumPro.Text == "")
                {
                    errorProvider1.SetError(NumPro, "Ingresa el número de material");
                    estado = false;
                }
                else
                {
                    estado = true;
                    int numMaterial;
                    numMaterial = Convert.ToInt32(NumPro.Text);
                    if (numMaterial > 0)
                    {
                        conexion.Open();
                        SqlCommand cmdComparar = new SqlCommand();
                        cmdComparar.Connection = conexion;
                        cmdComparar.CommandText = "Select num_material from INVENTARIO where num_material = " + numMaterial;

                        SqlDataReader dr = cmdComparar.ExecuteReader();
                        if (dr.Read())
                        {
                            errorProvider1.SetError(NumPro, "");
                            estado = true;
                        }
                        else
                        {
                            errorProvider1.SetError(NumPro, "No existe un producto con ese número");
                            estado = false;
                        }
                        conexion.Close();
                    }
                    else
                    {
                        errorProvider1.SetError(NumPro, "El numero de material debe ser mayor a 0");
                        estado = false;

                    }

                }

            }
            catch
            {
                errorProvider1.SetError(NumPro, "Por favor ingrese un número y no letras");
                estado = false;
            }
            return estado;
        }
    }
}
