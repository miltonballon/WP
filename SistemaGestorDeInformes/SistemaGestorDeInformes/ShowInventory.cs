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
    public partial class ShowInventory : Form
    {
        private ReceptionController receptionController;
        public ShowInventory()
        {
            InitializeComponent();
            receptionController = new ReceptionController();
            chargeData();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main principal = new Main();//para volver atras
            principal.WindowState = this.WindowState;
            this.Hide();
            principal.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterInvoice RegisterInvoiceForm = new RegisterInvoice();
            RegisterInvoiceForm.WindowState = this.WindowState;
            RegisterInvoiceForm.Show();
            this.Hide();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.WindowState = this.WindowState;
            ShowBills1.Show();
            this.Hide();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct main = new RegisterProduct();
            main.WindowState = this.WindowState;
            this.Hide();
            main.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts ShowProducts1 = new ShowProducts();
            ShowProducts1.WindowState = this.WindowState;
            ShowProducts1.Show();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
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

        private void ShowInventory_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
        }

        private void chargeData()
        {
            List<Reception> receptions = receptionController.getAllReceptions();
            
            foreach (Reception reception in receptions)
            {
                Product product = reception.Product;
                String productsName = product.Name,
                       unit = product.Unit,
                       total = reception.Total+"";

                String[] row = new String[] { productsName,unit,total};
                dataGridView1.Rows.Add(row);
            }
        
        }

        private void generarInformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateReport Interfaz = new GenerateReport();
            Interfaz.WindowState = this.WindowState;
            this.Hide();
            Interfaz.Show();
        }

        private void ShowInventory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ShowInventory_KeyUp(object sender, KeyEventArgs e)
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

        private void search_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidationTextBox tr = new ValidationTextBox();
            tr.CharacterEspecial(sender, e);
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            List<Reception> receptions = new List<Reception>();
            receptions = receptionController.searchReception(search_Textbox.Text);


            foreach (Reception reception in receptions)
            {
                Product product = reception.Product;
                String productsName = product.Name,
                       unit = product.Unit,
                       total = reception.Total + "";

                String[] row = new String[] { productsName, unit, total };
                dataGridView1.Rows.Add(row);
            }
        }

        private void Clean_Button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            chargeData();
        }

        private void Atras_button_Click(object sender, EventArgs e)
        {
            Main principal = new Main();//para volver atras
            principal.WindowState = this.WindowState;
            this.Hide();
            principal.Show();
        }
    }
}
