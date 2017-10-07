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
    public partial class ShowProducts : Form
    {
        ProductController p; 
        public ShowProducts()
        {
            InitializeComponent();
            p = new ProductController();
            showUser();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            InterfazPrincipal main = new InterfazPrincipal();
            this.Hide();
            main.Show();
        }

        private void RegisterProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct main = new RegisterProduct();
            this.Hide();
            main.Show();
        }

        public void showUser()
        {
            p.showProducts(dataGridView1);
        }

        private void MainFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal MainInterface = new InterfazPrincipal();
            MainInterface.Show();
            this.Hide();
        }

        private void RegisterInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura RegisterInvoiceForm = new InterfazRegistrarFactura();
            RegisterInvoiceForm.Show();
            this.Hide();
        }
    }
}
