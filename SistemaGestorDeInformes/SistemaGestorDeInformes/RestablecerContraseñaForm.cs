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

namespace SistemaGestorDeInformes
{
    public partial class RestablecerContraseñaForm : Form
    { 
        private Restablecer_Contraseña RC;
        private User user;
        public RestablecerContraseñaForm(User user)
        {

            InitializeComponent();
            RC = new Restablecer_Contraseña();
            this.user = user;
        }

        private void cambiarContraseña_Load(object sender, EventArgs e)
        {



        }

        private void confirmar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (camposVacios())
            {
                MessageBox.Show("Todos los campos deben ser llenados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                guardar();
            }*/

        }
        private void guardar()
        {
        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ci_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (camposVacios())
                {
                    MessageBox.Show("Todos los campos deben ser llenados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    guardar();
                }
            }*/
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (camposVacios())
                {
                    MessageBox.Show("Todos los campos deben ser llenados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    guardar();
                }
            }*/
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (camposVacios())
                {
                    MessageBox.Show("Todos los campos deben ser llenados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    guardar();
                }
            }*/
        }

        private void confirmar_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                if (camposVacios())
                {
                    MessageBox.Show("Todos los campos deben ser llenados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    guardar();
                }
            }*/
        }
       

        private void button5_Click_1(object sender, EventArgs e)
        {
            String mail = txtbxCorreo.Text;
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
                Mymessage.Body = "La contraseña es: "+user.Password;
                //sends the email
                MyServer.Send(Mymessage);
                MessageBox.Show("Se envio un correo electronico con la contraseña, por favor revise su correo");
            }
            else
            {
                MessageBox.Show("El correo ingresado no coincide con el del usuario");
            }
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            Login Login1 = new Login();
            this.Hide();
            Login1.Show();
        }
    }
}
