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

namespace SistemaGestorDeInformes
{
    public partial class RestablecerContraseñaForm : Form
    { 
        private Restablecer_Contraseña RC;
        public RestablecerContraseñaForm()
        {

            InitializeComponent();
            RC = new Restablecer_Contraseña();

        }

        private void cambiarContraseña_Load(object sender, EventArgs e)
        {



        }

        private void confirmar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (camposVacios())
            {
                MessageBox.Show("Todos los campos deben ser llenados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                guardar();
            }

        }
        private void guardar()
        {

            if (RC.existeCi(ci.Text))
            {
                if (RC.existeUser(user.Text, ci.Text))
                {
                    if (contraseña.Text == confirmar.Text)
                    {
                        RC.guardar(confirmar, ci);
                        MessageBox.Show("La contraseña se modifico correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas ingresadas no son iguales por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        contraseña.Text = null;
                        confirmar.Text = null;
                    }
                }
                else
                {
                    MessageBox.Show("El nombre de usuario no pertenece a este CI por favor verifique", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user.Text = null;
                    contraseña.Text = null;
                    confirmar.Text = null;
                }
            }
            else
            {
                MessageBox.Show("No se encontro el CI ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ci.Text = null;
                user.Text = null;
                contraseña.Text = null;
                confirmar.Text = null;
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ci_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            }
        }

        private void user_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            }
        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            }
        }

        private void confirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
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
            }
        }
        private bool camposVacios()
        {
            if (ci.Text == ("") || user.Text == ("") || confirmar.Text == ("") || contraseña.Text == (""))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
