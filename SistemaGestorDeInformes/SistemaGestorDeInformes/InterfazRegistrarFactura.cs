using ControllerLibrary;
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
    public partial class InterfazRegistrarFactura : Form
    {
        private InvoiceController invoiceController;
        ProviderController providerController;
        ProductController productController;
        private Invoice invoice;
        private Provider provider;
        private List<Provider> providers;
        private bool modifying;

        public InterfazRegistrarFactura()
        {
            InitializeComponent();
            this.textBoxNit.KeyPress += new KeyPressEventHandler(textBoxNit_TextChanged);//Para impedir que se pongan letras y espacios en el NIT
            this.textBoxNFactura.KeyPress += new KeyPressEventHandler(textBoxNFactura_TextChanged);//Para impedir que se pongan letras y espacios en el N.FACTURA
            this.textBoxNAutorizacion.KeyPress += new KeyPressEventHandler(textBoxNAutorizacion_TextChanged);//Para impedir que se pongan letras y espacios en el N.AUTORIZACION 
            invoiceController = new InvoiceController();
            providerController = new ProviderController();
            productController = new ProductController();
            loadProviders();
            modifying = false;
        }

        public InterfazRegistrarFactura(Invoice invoice)
        {
            InitializeComponent();
            this.invoice = invoice;
            this.provider = invoice.getProvider();
            this.textBoxNit.KeyPress += new KeyPressEventHandler(textBoxNit_TextChanged);//Para impedir que se pongan letras y espacios en el NIT
            this.textBoxNFactura.KeyPress += new KeyPressEventHandler(textBoxNFactura_TextChanged);//Para impedir que se pongan letras y espacios en el N.FACTURA
            this.textBoxNAutorizacion.KeyPress += new KeyPressEventHandler(textBoxNAutorizacion_TextChanged);//Para impedir que se pongan letras y espacios en el N.AUTORIZACION 
            invoiceController = new InvoiceController();
            providerController = new ProviderController();
            productController = new ProductController();
            loadProviders();
            modifying = true;
            fillTextBoxes();
        }

        private void fillTextBoxes()
        {
            textBoxProveedor.Text = invoice.getProvider().getName();
            textBoxNit.Text = invoice.getProvider().getNit()+"";
            textBoxNFactura.Text = invoice.getNInvoice() + "";
            textBoxNAutorizacion.Text = invoice.getNAutorization() + "";
            dateFecha.Value = invoice.getDate();
        }

        private void loadProviders()
        {
            providers=providerController.getAllProviders();
        }

        private void InterfazRegistrarFactura_Load(object sender, EventArgs e)
        {
            textBoxProveedor.AutoCompleteCustomSource = providersNames();
            textBoxProveedor.AutoCompleteMode= AutoCompleteMode.Suggest;
            textBoxProveedor.AutoCompleteSource= AutoCompleteSource.CustomSource;


            textBoxProveedor.MaxLength = 65;
            textBoxNit.MaxLength = 10;
            textBoxNFactura.MaxLength = 10;
            textBoxNAutorizacion.MaxLength = 10;

            KeyPreview = true;
        }

        private AutoCompleteStringCollection providersNames()
        {
            AutoCompleteStringCollection output = new AutoCompleteStringCollection();
            foreach (Provider p in providers)
            {
                output.Add(p.getName());
            }
            return output;
        }

        private void textBoxNit_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el NIT
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0')
                e.Handled = true;
        }


        private void textBoxNFactura_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el N.FACTURA
            if(e.KeyChar!='1' && e.KeyChar!= '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0')
                e.Handled = true;
        }

        private void textBoxNAutorizacion_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el N.AUTORIZACION
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0')
                e.Handled = true;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if ((dataGridView1.CurrentCell.ColumnIndex == 2)||(dataGridView1.CurrentCell.ColumnIndex == 3)) //Busca las columnas Cantidad y Precio Unitario del dataGridView1
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
            
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                TextBox autoText = e.Control as TextBox;
                if (autoText != null)
                {
                    autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
                    autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    autoText.AutoCompleteCustomSource = providersProducts();
                }
            }
        }

        private AutoCompleteStringCollection providersProducts()
        {
            AutoCompleteStringCollection output = new AutoCompleteStringCollection();
            if (provider != null)
            {
                List<Product> products = productController.showAllProductsByProvider(provider.getName());
                provider.setProducts(products);
                foreach (Product product in products)
                {
                    output.Add(product.Name);
                }
            }
            return output;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (provider != null)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Cells[dataGridView1.Columns["Unidad"].Index].Value = getUnitByNameOfProvidersProducts(Convert.ToString(row.Cells[dataGridView1.Columns["Nombre"].Index].Value), row.Cells[dataGridView1.Columns["Unidad"].Index].Value);
                }
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns["PrecioTotal"].Index].Value = (Convert.ToDouble(row.Cells[dataGridView1.Columns["PrecioUnitario"].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns["Cantidad"].Index].Value));//Caclula el Precio Total sumando la columna Cantidad con la columna Precio Unidad
            }
        }

        private String getUnitByNameOfProvidersProducts(String name,Object value)
        {
            String output = "";
            foreach (Product p in provider.getProducts())
            {
                if (p.Name.Equals(name))
                {
                    output = p.Unit;
                    break;
                }
            }
            if (output.Equals("")&&value!=null)
            {
                output = value.ToString();
            }
            return output;
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios a excepcion de: ., copiar, pegar, cortar
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != '.')
                e.Handled = true;
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();
            principal.Show();
            principal.WindowState = this.WindowState;
            this.Hide();
        }

        private void buttonAtrás_Click_1(object sender, EventArgs e)
        {
            if (modifying)
            {
                ShowBills sb = new ShowBills();
                sb.WindowState = this.WindowState;
                this.Hide();
                sb.Show();
            }
            else
            {
                InterfazPrincipal principal = new InterfazPrincipal();//para volver atras
                principal.WindowState = this.WindowState;
                this.Hide();
                principal.Show();
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (modifying)
            {
                modifyInvoice();
            }
            else
            {
                saveNewInvoice();
            }
        }

        private void modifyInvoice()
        {
            int nInvoice = Int32.Parse(textBoxNFactura.Text),
                nAutorization = Int32.Parse(textBoxNAutorizacion.Text),
                id=invoiceController.getInvoiceIdByObjectInvoice(invoice);
            DateTime date = dateFecha.Value;
            invoice.setNInvoice(nInvoice);
            invoice.setNAutorization(nAutorization);
            invoice.setProvider(provider);
            invoice.setDate(date);
            invoiceController.updateInvoice(invoice,id);
            MessageBox.Show("Se logro actualizar los datos de la Factura");
            changeToShowBills();
        }

        private void changeToShowBills()
        {
            ShowBills sb = new ShowBills();
            sb.WindowState = this.WindowState;
            this.Hide();
            sb.Show();
        }

        private void saveNewInvoice()
        {
            if (provider == null)
            {
                newProvider();
                providerController.insertProvider(provider);
            }
            invoice = createInvoice();
            createAndAddProducts();
            int res=invoiceController.insertInvoice(invoice);
            messages(res);
        }

        private void messages(int cod)
        {
            switch (cod)
            {
                case -1:
                    String providersName = invoice.getProvider().getName();
                    MessageBox.Show("El 'N. Factura' introducido con este proveedor: '" + providersName + "' ya existe.\nPor favor revise los datos introducidos.", "Error");
                    break;
                case -2:
                    MessageBox.Show("No existe ningun Trimestre abierto.\nPor favor cree uno.", "Error");
                    break;
                default:
                    MessageBox.Show("Informacion Basica de la factura agregado satisfactoriamente", "INFORME");
                    MessageBox.Show(cod + " filas de la facturas insertadas", "INFORME");
                    break;
            }
        }

        private void newProvider()
        {
            String name = textBoxProveedor.Text;
            int nit = Int32.Parse(textBoxNit.Text);
            provider = new Provider(name, nit);
        }

        private Invoice createInvoice()
        {
            int nInvoice = Int32.Parse(textBoxNFactura.Text),
                nAutorization = Int32.Parse(textBoxNAutorizacion.Text);
            DateTime date = dateFecha.Value;
            invoice = new Invoice(provider, nInvoice, nAutorization, date);
            return invoice;
        }

        private void createAndAddProducts()
        {
            int tamaño = (dataGridView1.Rows.Count)-1;
            Object[] datos = new Object[5];
            String proveedor = textBoxProveedor.Text;
            for (int i = 0; i < tamaño ; i++)
            {
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    datos[j]=dataGridView1.Rows[i].Cells[j].Value;
                }
                InvoiceRow fila = new InvoiceRow(datos,proveedor);
                invoice.addInvoiceRow(fila);
            }
        }

        private void registrarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterProduct intRegisterProduct = new RegisterProduct();
            intRegisterProduct.Show();
            this.Hide();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProducts intShowProducts = new ShowProducts();
            intShowProducts.Show();
            intShowProducts.WindowState = this.WindowState;
            this.Hide();
        }

        private void textBoxProveedor_Leave(object sender, EventArgs e)
        {
            setProvider();
        }

        private void setProvider()
        {
            Provider provider = getProviderByName(textBoxProveedor.Text);
            if (provider != null)
            {
                this.provider = provider;
                textBoxNit.Text = provider.getNit() + "";
            }
            else
            {
                this.provider = null;
                textBoxNit.Text = "";
            }
        }

        private Provider getProviderByName(String name)
        {
            Provider output = null;
            foreach (Provider p in providers)
            {
                if (p.getName().Equals(name))
                {
                    output = p;
                    break;
                }
            }
            return output;
        }

        private void verFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.Show();
            ShowBills1.WindowState = this.WindowState;
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

        private void verFacturasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowBills ShowBills1 = new ShowBills();
            ShowBills1.WindowState = this.WindowState;
            this.Hide();
            ShowBills1.Show();
        }

        private void verInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInventory ShowInventory1 = new ShowInventory();
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

        private void InterfazRegistrarFactura_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }            

        
        private void InterfazRegistrarFactura_KeyUp(object sender, KeyEventArgs e)
        {
            InterfazPrincipal prin = new InterfazPrincipal();
            ValidationTextBox tr = new ValidationTextBox();
            tr.KeyEscape(sender, e, this, prin);
        }
    }
}
