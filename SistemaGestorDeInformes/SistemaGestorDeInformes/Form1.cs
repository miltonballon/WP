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
    public partial class Form1 : Form
    {
        Connection c = new Connection();
        public Form1()
        {
            InitializeComponent();
         
            c.connect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura InterfazRegistrarFactura1=new InterfazRegistrarFactura();
            InterfazRegistrarFactura1.Show();
        }
    }
}
