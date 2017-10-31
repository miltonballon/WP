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
using EntityLibrary;

namespace SistemaGestorDeInformes
{
    public partial class ModifyProduct : Form
    {
        ProductController pc;
        Product product;
        public ModifyProduct()
        {
            InitializeComponent();
            pc = new ProductController();
            product = new Product();
        }
        public void registerClassProduct()
        {
            product.Name = Product_TextBox.Text;
            product.Provider = Provider_TextBox.Text;
            product.Unit = Unit_TextBox.Text;
        }
        private void atrasButton_Click(object sender, EventArgs e)
        {
            registerClassProduct();

            pc.insertProduct(product);
            pc.addReferencesToTableProduct_Provider_Unit(product);
            ShowProducts ShowProducts1 = new ShowProducts();
            ShowProducts1.WindowState = this.WindowState;
            this.Hide();
            ShowProducts1.Show();
        }




        private void FreshRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            product.Clasification = "Fresco";
        }

        private void DryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            product.Clasification = "Seco";
        }

        private void Registrar_Button_Click(object sender, EventArgs e)
        {
            registerClassProduct();
            pc.insertProduct(product);
            pc.addReferencesToTableProduct_Provider_Unit(product);
            MessageBox.Show("Editado exitosamente");
            ShowProducts main = new ShowProducts();
            main.WindowState = this.WindowState;
            main.Show();
            this.Hide();
        }
    }
}
