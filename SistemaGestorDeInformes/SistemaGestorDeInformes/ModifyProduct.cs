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
        ProductController pc;
        public ModifyProduct()
        {
            InitializeComponent();
            pc = new ProductController();
        }

        private void atrasButton_Click(object sender, EventArgs e)
        {
            pc.insertProduct(ProductTextBox, ProviderTextBox, Unit);
            pc.addReferencesToTableProduct_Provider_Unit(ProductTextBox, ProviderTextBox, Unit);
            ShowProducts ShowProducts1 = new ShowProducts();
            this.Hide();
            ShowProducts1.Show();
        }

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            pc.insertProduct(ProductTextBox, ProviderTextBox, Unit);
            pc.addReferencesToTableProduct_Provider_Unit(ProductTextBox, ProviderTextBox, Unit);
            MessageBox.Show("Editado exitosamente");
            ShowProducts main = new ShowProducts();
            main.Show();
            this.Hide();
        }
    }
}
