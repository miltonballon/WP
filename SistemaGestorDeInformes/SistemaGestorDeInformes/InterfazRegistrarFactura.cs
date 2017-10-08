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

        private void textBoxProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNit_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el NIT
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != 08 && e.KeyChar != 22 && e.KeyChar != 3 && e.KeyChar != 24)
                e.Handled = true;
        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNFactura_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el N.FACTURA
            if(e.KeyChar!='1' && e.KeyChar!= '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != 08 && e.KeyChar != 22 && e.KeyChar != 3 && e.KeyChar != 24)
                e.Handled = true;
        }

        private void textBoxNAutorizacion_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el N.AUTORIZACION
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != 08 && e.KeyChar != 22 && e.KeyChar != 3 && e.KeyChar != 24)
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
            List<Product> products=productController.showAllProductsByProvider(provider.getName());
            provider.setProducts(products);
            foreach (Product product in products)
            {
                output.Add(product.Name);
            }
            return output;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns["Unidad"].Index].Value = getUnitByNameOfProvidersProducts(Convert.ToString(row.Cells[dataGridView1.Columns["Nombre"].Index].Value));
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns["PrecioTotal"].Index].Value = (Convert.ToDouble(row.Cells[dataGridView1.Columns["PrecioUnitario"].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns["Cantidad"].Index].Value));//Caclula el Precio Total sumando la columna Cantidad con la columna Precio Unidad
            }
        }

        private String getUnitByNameOfProvidersProducts(String name)
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
            return output;
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios a excepcion de: ., copiar, pegar, cortar
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != 08 && e.KeyChar != '.' && e.KeyChar != 22 && e.KeyChar != 3 && e.KeyChar != 24)
                e.Handled = true;
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();
            principal.Show();
            this.Hide();
        }

        private void buttonAtrás_Click_1(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();//para volver atras
            this.Hide();
            principal.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            invoice = createInvoice();
            createAndAddProducts();
            invoiceController.addInvoice(invoice);
            MessageBox.Show(invoice.ToString());
        }

        private Invoice createInvoice()
        {
            int nInvoice = Int32.Parse(textBoxNFactura.Text),
                nAutorization = Int32.Parse(textBoxNAutorizacion.Text),
                nit = Int32.Parse(textBoxNit.Text);
            String proveedor = textBoxProveedor.Text;
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
            this.Hide();
        }

        private void textBoxProveedor_Leave(object sender, EventArgs e)
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
                textBoxNit.Text ="";
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
    }
}
