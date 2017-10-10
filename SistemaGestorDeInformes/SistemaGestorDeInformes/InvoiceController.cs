using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    class InvoiceController
    {
        private ProviderController providerController;
        private ProductController productController;
        public Connection c = new Connection();
        public InvoiceController()
        {
            c.connect();
            providerController = new ProviderController();
            productController = new ProductController();
        }

        public void addInvoice(Invoice invoice)
        {
            int nInvoice = invoice.getNInvoice(),
                nAutorization = invoice.getNAutorization(),
                idProvider = searchProvider(invoice.getProvider());
            DateTime date = invoice.getDate();
            String query = "INSERT INTO Invoice(n_invoice, n_autorization, id_provider, nit, date) VALUES (";
            query += nInvoice+", ";
            query += nAutorization + ", ";
            query += idProvider + ", ";
            query += invoice.getProvider().getNit() + ", '";
            query += date.ToShortDateString()+"')";
           
            try
            {
                
                c.executeInsertion(query);
                //MessageBox.Show(c.buscarYDevolverId("select id_proveedor FROM Factura where n_invoice = " + nInvoice) + "");
                MessageBox.Show("Informacion Basica de la factura agregado satisfactoriamente","INFORME");
                registerInvoicesRows(invoice);
            }
            catch (Exception)
            {
                MessageBox.Show("El 'N. Factura' introducido ya existe.\nPor favor revise los datos introducidos.", "Error");
            }
        }

        public int searchProvider(Provider provider)
        {
            int id=providerController.findProviderIdByName(provider.getName());
            if (id < 0)
            {
                providerController.insertProvider(provider);
            }
            return id;
        }

        public void registerInvoicesRows(Invoice invoice)
        {
            int counter = 0;
            foreach (InvoiceRow row in invoice.getInvoiceRows())
            {
                registerInvoiceRow(row,invoice);
                counter++;
            }
            MessageBox.Show(counter+" filas de la facturas insertadas","INFORME");
        }

        public void registerInvoiceRow(InvoiceRow row,Invoice invoice)
        {
            String quantity = row.getQuantity() + ""
                , unitPrice= row.getUnitPrice() + ""
                , total=row.getTotal()+"";
            searchProduct(row.getProduct());
            int idPpu = insertProduct(row.getProduct());
            String queryInsertion = "INSERT INTO invoice_row (n_invoice, id_ppu, quantity, unit_price, total) VALUES(";
            queryInsertion += invoice.getNInvoice() + ", ";
            queryInsertion += idPpu + ", ";
            queryInsertion += "'"+quantity + "', ";
            queryInsertion += "'"+unitPrice + "', ";
            queryInsertion += "'"+total+"')" ;
            c.executeInsertion(queryInsertion);
        }

        private int insertProduct(Product product)
        {
            string nameQuery = "select id FROM Product where Name = " + "'" + product.Name.ToString() + "'";
            string providerQuery = "select id FROM Provider where Provider = " + "'" + product.Provider.ToString() + "'";
            string unitQuery = "select id FROM Unit where Type = " + "'" + product.Unit.ToString() + "'";
            int idProd = c.FindAndGetID(nameQuery)
                , idProv = c.FindAndGetID(providerQuery)
                , idUni = c.FindAndGetID(unitQuery);
            return searchPPU(idProd, idProv, idUni);
        }

        private int searchPPU(int idProd, int idProv, int idUni)
        {
            String query = "SELECT id FROM Product_Provider_Unit WHERE "
                + "id_prod="+idProd+" and id_prov="+idProv+" and id_uni="+idUni+"";
            return c.FindAndGetID(query);
        }

        private void searchProduct(Product product)
        {
            TextBox name = new TextBox();
            name.Text = product.Name;
            TextBox proveedor = new TextBox();
            proveedor.Text = product.Provider;
            TextBox unidad = new TextBox();
            unidad.Text = product.Unit;
            int affected = productController.insertProduct(name, proveedor, unidad);
            if (affected > 0)
            {
                productController.addReferencesToTableProduct_Provider_Unit(name, proveedor, unidad);
            }
        }

        public List<Invoice> getAllInvoices()
        {
            List<Invoice> output = new List<Invoice>();
            string query = "SELECT * FROM Invoice";
            try
            {
                SQLiteDataReader data = c.query_show(query);
                while (data.Read())
                {
                    int nInvoice = Int32.Parse(data[0].ToString()),
                        provId = Int32.Parse(data[2].ToString()),
                        nAut = Int32.Parse(data[1].ToString());
                    DateTime date = getDate(data[4].ToString());
                    Provider provider = providerController.getProviderById(provId);
                    Invoice invoice = new Invoice(provider, nInvoice, nAut, date);
                    List<InvoiceRow> invoiceRows = getAllInvoicesRowByNInvoice(invoice.getNInvoice());
                    invoice.setInvoiceRows(invoiceRows);
                    output.Add(invoice);
                }
            }
            catch (Exception)
            { }
            
            return output;
        }

        public List<InvoiceRow> getAllInvoicesRowByNInvoice(int numInvoice)
        {
            List<InvoiceRow> output = new List<InvoiceRow>();
            string query = "SELECT * FROM invoice_row";
            try
            {
                SQLiteDataReader data = c.query_show(query);
                while (data.Read())
                {
                    int ppuId = Int32.Parse(data[2].ToString());
                    double quantity = Double.Parse(data[3].ToString()),
                        unitPrice= Double.Parse(data[4].ToString()),
                        total= Double.Parse(data[5].ToString());
                    Product product = productController.showProductByPPUId(ppuId);
                    InvoiceRow invoiceRow = new InvoiceRow(product, quantity, unitPrice, total);
                    output.Add(invoiceRow);
                }
            }
            catch (Exception)
            { }

            return output;
        }

        private DateTime getDate(String dateString)
        {
            DateTime date;
            string[] dates = dateString.Split('/');
            int day = Int32.Parse(dates[0])
                , month= Int32.Parse(dates[1])
                , year = Int32.Parse(dates[2]);
            date = new DateTime(year, month, day);
            return date;
        }
    }
}
