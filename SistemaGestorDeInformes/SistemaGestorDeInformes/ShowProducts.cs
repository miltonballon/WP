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
        List<Product> products = new List<Product>();
        ProductController pc; 
        public ShowProducts()
        {
            InitializeComponent();
            pc = new ProductController();
            
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
            products = pc.showProducts();
            dataGridView1.DataSource = products;
            onlyReadRestrictionDataGrid();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            pc.searchProduct(dataGridView1,textBox1.Text);
          
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            showUser();
            
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.Show();
            this.Hide();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfiguration ReportConfiguration1 = new ReportConfiguration();
            this.Hide();
            ReportConfiguration1.Show();
        }

        private void abrirTrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuarter OpenQuarter1 = new OpenQuarter();
            this.Hide();
            OpenQuarter1.Show();
        }
        public void onlyReadRestrictionDataGrid()
        {
            
            dataGridView1.Columns["Name"].ReadOnly = true;
            dataGridView1.Columns["Provider"].ReadOnly = true;
            dataGridView1.Columns["Unit"].ReadOnly = true;
        }
        public void dataSelectedDataGrid()
        {

            dataGridView1.Rows[0].ReadOnly = false;
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                Product p = new Product(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),dataGridView1.SelectedRows[0].Cells[1].Value.ToString(),dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                
                EditProduct edit= new EditProduct();
               
                edit.Show();
                this.Close();
              
               
              
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
        
    }
}
