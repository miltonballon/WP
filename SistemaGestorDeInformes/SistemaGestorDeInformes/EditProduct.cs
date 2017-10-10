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
            pc.insertProduct(textBox1, textBox2, textBox3);
            pc.addReferencesToTableProduct_Provider_Unit(textBox1, textBox2, textBox3);


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
