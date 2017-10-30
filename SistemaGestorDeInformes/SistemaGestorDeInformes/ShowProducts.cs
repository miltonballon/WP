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
            Main main = new Main();
            main.WindowState = this.WindowState;
            this.Hide();
            main.Show();
        }

        private void RegisterProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct main = new RegisterProduct();
            main.WindowState = this.WindowState;
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
            Main MainInterface = new Main();
            MainInterface.WindowState = this.WindowState;
            MainInterface.Show();
            this.Hide();
        }

        private void RegisterInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterInvoice RegisterInvoiceForm = new RegisterInvoice();
            RegisterInvoiceForm.WindowState = this.WindowState;
            RegisterInvoiceForm.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>();
            products=pc.searchProduct(textBox1.Text);
            dataGridView1.DataSource = products;
          
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            showUser();            
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.WindowState = this.WindowState;
            ShowBills1.Show();
            this.Hide();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfiguration ReportConfiguration1 = new ReportConfiguration();
            ReportConfiguration1.WindowState = this.WindowState;
            this.Hide();
            ReportConfiguration1.Show();
        }

        private void abrirTrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuarter OpenQuarter1 = new OpenQuarter();
            OpenQuarter1.WindowState = this.WindowState;
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
        

        private void editButton_Click(object sender, EventArgs e)
        {

            Product p = new Product(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString());

            ModifyProduct edit = new ModifyProduct();
            edit.ProductTextBox.Text = p.Name;          
            edit.ProviderTextBox.Text = p.Provider;
            edit.Unit.Text = p.Unit;
            if (p.Clasification == "Fresco")
            {
                edit.FreshRadioButton.Checked = true;
            }
            else
            {
                edit.DryRadioButton.Checked = true;
            }


            //MessageBox.Show("A" + pc.getIdName(p.Name) + "T" + pc.getIdProvider(p.Provider) + "B" + pc.getIdUnit(p.Unit));
            
            //pc.DeleteProduct_Provider_Unit(1,1,1);
            pc.DeleteProduct_Provider_Unit(pc.getIdName(p.Name), pc.getIdProvider(p.Provider), pc.getIdUnit(p.Unit));

            edit.Show();
            this.Close();

        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 70;
            textBox1.ShortcutsEnabled = false;

            KeyPreview = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInventory ShowInventory1 = new ShowInventory();
            ShowInventory1.WindowState = this.WindowState;
            this.Hide();
            ShowInventory1.Show();
        }

        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputOfProvitions InputOfProvitions1 = new InputOfProvitions();
            InputOfProvitions1.WindowState = this.WindowState;
            this.Hide();
            InputOfProvitions1.Show();
        }

        private void registrarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputOfProvitions Interfaz = new OutputOfProvitions();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void generarInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport Interfaz = new GenerateReport();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void ShowProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void ShowProducts_KeyUp(object sender, KeyEventArgs e)
        {
            Main prin = new Main();
            ValidationTextBox tr = new ValidationTextBox();
            tr.KeyEscape(sender, e, this, prin);
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InventoryConfiguration Interfaz = new InventoryConfiguration();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
