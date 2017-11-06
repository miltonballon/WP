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
        public Product product;
        int idProduct;
        
        public ModifyProduct(Product p)
        {
            InitializeComponent();
            pc = new ProductController();
            product = p;
            idProduct = pc.searchProduct(product);
            MessageBox.Show("" + product.Name + product.Clasification + product.Provider + product.Unit);
        }
        public void registerClassProduct()
        {
            product.Name = Product_TextBox.Text;
            product.Provider = Provider_TextBox.Text;
            product.Unit = Unit_TextBox.Text;
            if (FreshRadioButton.Checked == true)
            {
                product.Clasification = "Fresco";
            }
            else
            {
                product.Clasification = "Seco";
            }

        }
        private void atrasButton_Click(object sender, EventArgs e)
        {
            /*
            registerClassProduct();

            pc.insertProduct(product);
            pc.addReferencesToTableProduct_Provider_Unit(product);
            */
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
            MessageBox.Show("" + product.Name + product.Clasification + product.Provider + product.Unit);
            pc.updateProduct(product,idProduct);

            MessageBox.Show("Editado exitosamente");
            ShowProducts main = new ShowProducts();
            main.WindowState = this.WindowState;
            main.Show();
            this.Hide();
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
