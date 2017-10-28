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
    public partial class EditProduct : Form
    {
        ProductController pc;
      
        public EditProduct()
        {
            InitializeComponent();
            pc = new ProductController();
        }
       
        private void EditButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("A"+pc.getIdName(pro.Name)+ "T"+pc.getIdProvider(pro.Provider)+"B"+ pc.getIdUnit(pro.Unit));
            Product product = new Product(textBox1.Text, textBox2.Text, textBox3.Text);
            pc.insertProduct(product);
            pc.addReferencesToTableProduct_Provider_Unit(product);


            MessageBox.Show("Borrado");

            ShowProducts main = new ShowProducts();
            main.Show();
            this.Hide();
            
        }
        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ShowProducts main = new ShowProducts();
            main.Show();
            this.Close();
        }
    }
}
