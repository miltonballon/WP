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

namespace SistemaGestorDeInformes
{
    public partial class FirstSetup : Form
    {
        UserController userController;
        public FirstSetup()
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

      
        private void FirtsSetup_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!userController.HasUser())
            {
                Application.Exit();
            }
        }
    }
}
