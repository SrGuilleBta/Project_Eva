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
    public partial class SolicitudP : Form
    {
        const string usuario = "labs.wall.e@gmail.com";
        const string Password = "Bailarina77";
        public SolicitudP()
        {
            InitializeComponent();
        }

        private void BTSolicitar_Click(object sender, EventArgs e)
        {
            if (validarTexBox())
            {
                string Error = "";
                StringBuilder mensejebuilder = new StringBuilder();
                mensejebuilder.Append(Materialtxt.Text);
                string envio = "labs.wall.e@gmail.com";
                string recibido = "labs.wall.e@gmail.com";
                string asunnto = "Solicitud de material";
                enviarcorreo(mensejebuilder, DateTime.Now, envio, recibido, asunnto, out Error);
            }
            else
            {
                MessageBox.Show("Ingresa la cantidad y el material que va a solicitar");
            }
        }
        public static void enviarcorreo(StringBuilder mensaje, DateTime fecha_envio, string de, string para, string asusnto, out string Error)
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
                Error = "Se ha enviado la solicitud de material de manera exitosa";
                MessageBox.Show(Error);


            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                MessageBox.Show(Error);

                return;
            }
        }

        private void btAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario abrirInvnetario = new Inventario();
            abrirInvnetario.Show();
        }
        private bool validarTexBox()
        {
            bool estado;
            if (Materialtxt.Text == "")
            {
                errorProvider1.SetError(Materialtxt, "Ingresa la cantidad y el material que va a solicitar");
                estado = false;
            }
            else
            {
                estado = true;
            }
            return estado;
        }

        private void Materialtxt_Validating(object sender, CancelEventArgs e)
        {
            validarTexBox();
        }

        private void Materialtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
