using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    public partial class Login : Form
    {
        private UserController usercontroller;
        public Login()
        {
            InitializeComponent();
            usercontroller = new UserController();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RestablecerContraseñaForm CC = new RestablecerContraseñaForm();
            CC.ShowDialog();
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String user = txtUsuario.Text;
            String pass = txtContraseña.Text;
            if (user != "" && pass != "")
            {
                if (usercontroller.verify(user, pass))
                {
                    InterfazPrincipal prin = new InterfazPrincipal();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
