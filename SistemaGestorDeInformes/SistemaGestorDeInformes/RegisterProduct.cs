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
    public partial class RegisterProduct : Form
    {
        ProductController p;
        public RegisterProduct()
        {
            InitializeComponent();
            p = new ProductController();
        }

        private void labelProveedor_Click(object sender, EventArgs e)
        {

        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            InterfazPrincipal main = new InterfazPrincipal();
            this.Hide();
            main.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts main = new ShowProducts();
            this.Hide();
            main.Show();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            p.insertar(ProductoTextBox, ProveedorTextBox, UnidadTextBox);
            p.agregarIndices(ProductoTextBox, ProveedorTextBox, UnidadTextBox);
            cleanTextBox();
            MessageBox.Show("agregado");

        }
        public void cleanTextBox()
        {
            ProductoTextBox.Text = "";
            ProveedorTextBox.Text = "";
            UnidadTextBox.Text = "";
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal intPrincipal = new InterfazPrincipal();
            intPrincipal.Show();
            this.Hide();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura intInterfazRegistrarFactura = new InterfazRegistrarFactura();
            intInterfazRegistrarFactura.Show();
            this.Hide();
        }
    }
}
