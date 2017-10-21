using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace SistemaGestorDeInformes
{
    
    public partial class RegisterUser : Form
    {
        UserController userController;
        public RegisterUser()
        {
            InitializeComponent();
            userController = new UserController();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            User user = new User(txtEmail.Text, txtName.Text, txtPassword.Text);
            if (userController.CreateUser(user))
            {
                MessageBox.Show("Usuario creado");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un error");
            }
        }

        private Boolean ValidateEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if(ValidateEmail(txtEmail.Text))
            { }
            else
            {
                MessageBox.Show("Dirección de correo electrónico no valida, el correo debe tener el formato: nombre@dominio.com, " + 
                    "por favor seleccione un correo valido", "Validación de correo electrónico", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                txtEmail.SelectAll();
                txtEmail.Focus();
            }
        }

        private void labelCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }        
    }
}
