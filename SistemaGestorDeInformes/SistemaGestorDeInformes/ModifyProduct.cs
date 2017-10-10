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
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            ShowProducts ShowProducts1 = new ShowProducts();
            this.Hide();
            ShowProducts1.Show();
        }
    }
}
