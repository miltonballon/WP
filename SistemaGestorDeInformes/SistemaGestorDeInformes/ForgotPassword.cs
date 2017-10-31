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
using System.Net.Mail;
using System.Net;
using EntityLibrary;
using ControllerLibrary;

namespace SistemaGestorDeInformes
{
    public partial class ForgotPassword : Form
    { 
        private User user;
        public ForgotPassword(User user)
        {
            InitializeComponent();
            this.user = user;
        }
                
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                            

        private void atrasButton_Click(object sender, EventArgs e)
        {
            Login Login1 = new Login();
            this.Hide();
            Login1.Show();
        }

        private void Enviar_button_Click(object sender, EventArgs e)
        {
            String mail = Correo_textbox.Text;
            if (user.Email.Equals(mail))
            {

                //created object of SmtpClient details and provides server details
                SmtpClient MyServer = new SmtpClient();
                MyServer.Host = "smtp-mail.outlook.com";
                MyServer.Port = 587;
                MyServer.EnableSsl = true;
                //Server Credentials
                NetworkCredential NC = new NetworkCredential();
                NC.UserName = "juanpa0603@hotmail.com";
                NC.Password = "1pao2la3";
                //assigned credetial details to server
                MyServer.Credentials = NC;
                //create sender address
                MailAddress from = new MailAddress("juanpa0603@hotmail.com", "Sistema Gestor de Informes");
                //create receiver address
                MailAddress receiver = new MailAddress("jprodriguez60@gmail.com", "Responsable de Recursos");
                MailMessage Mymessage = new MailMessage(from, receiver);
                Mymessage.Subject = "Recuperacion de Contraseña";
                Mymessage.Body = "La contraseña es: " + user.Password;
                //sends the email
                MyServer.Send(Mymessage);
                MessageBox.Show("Se envio un correo electronico con la contraseña, por favor revise su correo");
            }
            else
            {
                MessageBox.Show("El correo ingresado no coincide con el del usuario");
            }
        }

        private void Correo_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32) || (e.KeyChar == 64) || (e.KeyChar == 46) || (e.KeyChar == 95))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
