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
    public partial class OutputOfProvitions : Form
    {
        public OutputOfProvitions()
        {
            InitializeComponent();
        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {
            InterfazPrincipal main = new InterfazPrincipal();
            this.Hide();
            main.Show();
        }
    }
}
