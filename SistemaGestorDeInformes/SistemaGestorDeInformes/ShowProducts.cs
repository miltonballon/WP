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
            products = p.showProducts();
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
            p.searchProduct(dataGridView1,textBox1.Text);
          
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
                RegisterProduct editar = new RegisterProduct();
                editar.Show();
                this.Hide();
                editar.ProductTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                editar.ProviderTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                editar.Unit.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                editar.RegistrarButton.Text = "Editar";
              
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
            }
        }
        
    }
}
