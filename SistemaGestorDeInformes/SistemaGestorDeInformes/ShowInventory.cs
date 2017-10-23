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
    public partial class ShowInventory : Form
    {
        private ReceptionController receptionController;
        public ShowInventory()
        {
            InitializeComponent();
            receptionController = new ReceptionController();
        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();//para volver atras
            this.Hide();
            principal.Show();
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();//para volver atras
            this.Hide();
            principal.Show();
        }

        private void registrarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazRegistrarFactura RegisterInvoiceForm = new InterfazRegistrarFactura();
            RegisterInvoiceForm.Show();
            this.Hide();
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.Show();
            this.Hide();
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct main = new RegisterProduct();
            this.Hide();
            main.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts ShowProducts1 = new ShowProducts();
            ShowProducts1.Show();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }

        private void registrarEntradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputOfProvitions InputOfProvitions1 = new InputOfProvitions();
            this.Hide();
            InputOfProvitions1.Show();
        }

        private void registrarSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OutputOfProvitions Interfaz = new OutputOfProvitions();
            this.Hide();
            Interfaz.Show();
        }

        private void ShowInventory_Load(object sender, EventArgs e)
        {
            chargeData();
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
            this.Hide();
            Interfaz.Show();
        }
    }
}
