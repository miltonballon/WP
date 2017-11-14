using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLibrary;
using ControllerLibrary;
namespace SistemaGestorDeInformes

{
    public partial class HistoricReceptions : Form
    {
        ReceptionController receptionController;
        OutputReceptionController outputReceptionController;
        InventoryController inventoryController;
        public HistoricReceptions()
        {
            InitializeComponent();
            receptionController = new ReceptionController();
            inventoryController = new InventoryController();
            outputReceptionController = new OutputReceptionController();
        }

        private void HistoricReceptions_Load(object sender, EventArgs e)
        {
            chargeData();
            chargeOutputs();
        }
        private void chargeData()
        {
            List<Reception> products = receptionController.getAllReceptions();
            
            foreach (Reception inventory in products)
            {
                Product product = inventory.Product;
                String productsName = product.Name,
                       provider = product.Provider,
                       unit = product.Unit,
                       reception= inventory.ReceptionDate,
                       expiration = inventory.ExpirationDate,
                       total = inventory.Total + "";

                String[] row = new String[] { productsName,provider, unit,reception,expiration, total };
                dataGridView1.Rows.Add(row);
                
            }

        }

        private void chargeOutputs()
        {
           
            List<OutputReception> products = outputReceptionController.getAllOutputReceptions();


            if (products != null)
            {
                foreach (OutputReception inventory in products)
                {
                    //Product product = inventory.Product;

                    Reception rec = inventory.Reception;

                    String productsName = rec.Product.Name,
                           unit = rec.Product.Unit,

                           outputDate = inventory.OutputDate,
                           total = inventory.Total + "";

                    String[] row = new String[] { productsName, unit, total, outputDate };

                    dataGridView2.Rows.Add(row);

                }
            }
            

        }
        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputOfProvitions Interfaz = new InputOfProvitions();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.WindowState = this.WindowState;
            this.Hide();
            main.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterInvoice Interfaz = new RegisterInvoice();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills Interfaz = new ShowBills();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct Interfaz = new RegisterProduct();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts Interfaz = new ShowProducts();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void registrarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputOfProvitions Interfaz = new OutputOfProvitions();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInventory Interfaz = new ShowInventory();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void registrarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProvider Interfaz = new RegisterProvider();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void verProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProviders Interfaz = new ShowProviders();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportConfiguration Interfaz = new ReportConfiguration();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            InventoryConfiguration Interfaz = new InventoryConfiguration();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void abrirTrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenQuarter Interfaz = new OpenQuarter();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login Interfaz = new Login();
            this.Hide();
            Interfaz.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void inputReceptionsByDate()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            List<Reception> products = receptionController.getReceptionsByDate(dateTimePicker1.Value.ToString("dd/MM/yyyy"));

            foreach (Reception inventory in products)
            {
                Product product = inventory.Product;
                String productsName = product.Name,
                       provider = product.Provider,
                       unit = product.Unit,
                       reception = inventory.ReceptionDate,
                       expiration = inventory.ExpirationDate,
                       total = inventory.Total + "";

                String[] row = new String[] { productsName, provider, unit, reception, expiration, total };
                dataGridView1.Rows.Add(row);

            }
        }
        private void outputReceptionsByDate()
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            List<OutputReception> products = outputReceptionController.getOutputReceptionsByDate(dateTimePicker1.Value.ToString("dd/MM/yyyy"));


            if (products != null)
            {
                foreach (OutputReception inventory in products)
                {
                    //Product product = inventory.Product;

                    Reception rec = inventory.Reception;

                    String productsName = rec.Product.Name,
                           unit = rec.Product.Unit,

                           outputDate = inventory.OutputDate,
                           total = inventory.Total + "";

                    String[] row = new String[] { productsName, unit, total, outputDate };

                    dataGridView2.Rows.Add(row);

                }
            }


        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            inputReceptionsByDate();
            outputReceptionsByDate();

        }
    }
}
