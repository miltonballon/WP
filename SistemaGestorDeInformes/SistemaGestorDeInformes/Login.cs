using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerLibrary;
using EntityLibrary;

namespace SistemaGestorDeInformes
{
    public partial class Login : Form
    {
        private UserController usercontroller;
        private User user;
        public Login()
        {
            InitializeComponent();
            usercontroller = new UserController();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Usuario_Textbox.ShortcutsEnabled = false;
            Contraseña_Textbox.ShortcutsEnabled = false;
        }


        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                String user = Usuario_Textbox.Text;
                String pass = Contraseña_Textbox.Text;
                if (user != "" && pass != "")
                {
                    if (usercontroller.verify(user, pass))
                    {
                        Main prin = new Main();
                        prin.WindowState = this.WindowState;
                        this.Hide();
                        prin.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe o la contraseña es incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor llene todos los campos");
                }
            }
        }

        private void Entrar_Button_Click(object sender, EventArgs e)
        {
            String user = Usuario_Textbox.Text;
            String pass = Contraseña_Textbox.Text;
            if (user != "" && pass != "")
            {
                if (usercontroller.verify(user, pass))
                {
                    Main prin = new Main();
                    prin.WindowState = this.WindowState;
                    this.Hide();
                    prin.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no existe o la contraseña es incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos");
            }
        }

        private void Cancelar_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void Contrasena_linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String username = Usuario_Textbox.Text;
            if (username != "")
            {
                User user = usercontroller.getUserByUsername(username);
                if (user != null)
                {
                    this.Hide();
                    ForgotPassword CC = new ForgotPassword(user);
                    CC.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario inexistente");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un nombre de usuario");
            }
        }
    }
}
