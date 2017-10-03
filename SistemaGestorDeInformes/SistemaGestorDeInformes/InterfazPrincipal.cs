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
    public partial class InterfazPrincipal : Form
    {
        Connection c = new Connection();
        public InterfazPrincipal()
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

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura intRegFac = new InterfazRegistrarFactura();
            this.Hide();
            intRegFac.Show();

        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct main = new RegisterProduct();
            this.Hide();
            main.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts products = new ShowProducts();
            this.Hide();
            products.Show();
        }
    }
}
