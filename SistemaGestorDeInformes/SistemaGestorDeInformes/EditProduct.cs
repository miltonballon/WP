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
          
               // pc.DeleteProduct_Provider_Unit(1, 1, 1);
                MessageBox.Show("Borrado");
            
            
        }
        

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ShowProducts main = new ShowProducts();
            main.Show();
            this.Close();
        }
    }
}
