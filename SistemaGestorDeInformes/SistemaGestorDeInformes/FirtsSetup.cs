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
            if(userController.HasUser())
            {
                this.Close();
            }
            else
            {
                RegisterUser register = new RegisterUser();
                this.Hide();
                register.ShowDialog();
                this.Close();
               
            }
        }
    }
}
