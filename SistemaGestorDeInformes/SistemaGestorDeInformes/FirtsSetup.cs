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
    public partial class FirtsSetup : Form
    {
        UserController userController;
        public FirtsSetup()
        {
            InitializeComponent();
            userController = new UserController();
        }

        private void FirtsSetup_Load(object sender, EventArgs e)
        {
            if (userController.HasUser())
            {
                this.Close();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterUser register = new RegisterUser();
            register.WindowState = this.WindowState;
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FirtsSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!userController.HasUser())
            {
                Application.Exit();
            }
        }
    }
}
