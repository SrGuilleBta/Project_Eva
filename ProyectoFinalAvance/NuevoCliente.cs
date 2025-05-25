using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalAvance
{
    public partial class NuevoCliente : Form
    {
        
        const string usuario = "labs.wall.e@gmail.com";
        const string Password = "Bailarina77";
        public NuevoCliente()
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

        private void BEnviarAC_Click(object sender, EventArgs e)
        {
            int contador = 0;
            validarFormulario();    
            foreach(Control juan in ListaServicios.Controls )
            {
                if(juan is CheckBox)
                {
                    if(((CheckBox)juan).Checked)
                    {
                        contador ++;
                    }
                }
            }
            if (contador > 0)
            {
                errorProvider1.SetError(label5, "");
                if (validarNombreCoR() && validarNombreEn() && validarTel() && validarCorreo())
                {

                    string Error = "";
                    StringBuilder mensejebuilder = new StringBuilder();
                    mensejebuilder.Append("Datos Cliente \n");
                    mensejebuilder.Append("Nombre de Recidencia o Comercio: " + NombreRoCtxt.Text);
                    mensejebuilder.Append("\nNombre del cliente que encargo el servicio: " + NombreClientetxt.Text);
                    mensejebuilder.Append("\nTelefono: " + Telefonotxt.Text);
                    mensejebuilder.Append("\nCorreo: " + Correotxt.Text);
                    mensejebuilder.Append("\nServicios: ");
                    if (IngeCheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + IngeCheck.Text);
                    }
                    if (CableadoCheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + CableadoCheck.Text);
                    }
                    if (AudioCheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + AudioCheck.Text);
                    }
                    if (VideoCheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + VideoCheck.Text);
                    }
                    if (ControlICheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + ControlICheck.Text);
                    }
                    if (RedCheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + RedCheck.Text);
                    }
                    if (TelefoniaCheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + TelefoniaCheck.Text);
                    }
                    if (CircuitoCheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + CircuitoCheck.Text);
                    }
                    if (ControlICheck.Checked)
                    {
                        mensejebuilder.Append("\n- " + ControlCheckl.Text);
                    }
                    if (EquipoAdicionaltxt.Text == "")
                    {

                    }
                    else
                    {
                        mensejebuilder.Append("\nEquipo Adicional: " + EquipoAdicionaltxt.Text);
                        mensejebuilder.Append(" " + CantidadEA.Text);
                    }
                    string envio = "labs.wall.e@gmail.com";
                    string recibido = "labs.wall.e@gmail.com";
                    string asunnto = "Cliente nuevo";

                    enviarcorreo(mensejebuilder, DateTime.Now, envio, recibido, asunnto, out Error);
                }
            }
            else
            {
                errorProvider1.SetError(label5, "Seleciona por lo menos un servicio");
            }
        }
        public static void enviarcorreo(StringBuilder mensaje, DateTime fecha_envio, string de, string para, string asusnto, out string  Error)
        {
            Error = "";
            try
            {
                mensaje.Append(Environment.NewLine);                
                mensaje.Append(string.Format("\n\n\nEste correo ha sido enviado el dia {0: dd/MM/yyyy} a las {0:HH:mm:ss} hrs: \n\n\n", fecha_envio));
                mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(de);
                mail.To.Add(para);
                mail.Subject = asusnto;
                mail.Body = mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(usuario, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "El nuevo cliente se a mandado correctamente";
                MessageBox.Show(Error);


            }
            catch(Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);

                return;                
            }
        }

        private void EquipoAdicionaltxt_TextChanged(object sender, EventArgs e)
        {
            if(EquipoAdicionaltxt.Text == "")
            {
                CantidadEA.Enabled = false;
            }
            else
            {
                CantidadEA.Enabled = true;
            }
        }
        private bool validarNombreCoR()
        {
            bool estado = true;
            if(NombreRoCtxt.Text == "")
            {
                errorProvider1.SetError(NombreRoCtxt, "Ingresa un nombre de recidencia o comercio ");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(NombreRoCtxt, "");
                estado = true;
            }
            return estado;
        }

        private void NombreRoCtxt_Validating(object sender, CancelEventArgs e)
        {
            validarNombreCoR();
        }
        private bool validarNombreEn()
        {
            bool estado = true;
            if (NombreClientetxt.Text == "")
            {
                errorProvider1.SetError(NombreClientetxt, "Ingresa un nombre");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(NombreClientetxt, "");
                estado = true;
            }
            return estado;
        }

        private void NombreClientetxt_Validating(object sender, CancelEventArgs e)
        {
            validarNombreEn();
        }
        private bool validarTel()
        {
            bool estado = true;
            try
            {
                if (Telefonotxt.Text == "")
                {
                    errorProvider1.SetError(Telefonotxt, "Ingresa un telefono");
                    estado = false;
                }
                else
                {
                    int telefono;
                    telefono = Convert.ToInt32(Telefonotxt.Text);
                    errorProvider1.SetError(Telefonotxt, "");
                    if (telefono<= 0)
                    {
                        errorProvider1.SetError(Telefonotxt, "");
                        estado = true;
                    }                   
                }
            }
            catch
            {
                errorProvider1.SetError(Telefonotxt, "Ingresa solo numeros");
                estado = false;
            }
            return estado;
        }

        private void Telefonotxt_Validating(object sender, CancelEventArgs e)
        {
            validarTel();
        }
        private bool validarCorreo()
        {
            bool estado = true;
            if (Correotxt.Text == "")
            {
                errorProvider1.SetError(Correotxt, "Ingresa un correo");
                estado = false;
            }
            else
            {
                errorProvider1.SetError(Correotxt, "");
                estado = true;
            }
            return estado;
        }

        private void Correotxt_Validating(object sender, CancelEventArgs e)
        {
            validarCorreo();
        }
        private void validarFormulario()
        {
            bool nombreR = validarNombreCoR();
            bool nombreEn = validarNombreEn();
            bool telefono = validarTel();
            bool correo = validarCorreo();
            if (nombreR && nombreEn && telefono && correo)
            {

            }
            else
            {
                MessageBox.Show("Ingresa los datos correctos o faltantes");
            }
        }

        private void NombreCliente_Enter(object sender, EventArgs e)
        {

        }

        private void VideoCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Telefonotxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
