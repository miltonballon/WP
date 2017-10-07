using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    class InvoiceController
    {
        public Connection c = new Connection();
        public InvoiceController()
        {
            c.connect();
        }

        public void addInvoice(Invoice invoice)
        {
            int nInvoice = invoice.getNInvoice(),
                nAutorization = invoice.getNAutorization(),
                nit = invoice.getNit(),
                idProvider = searchProvider(invoice.getProvider());
            DateTime date = invoice.getDate();
            String query = "INSERT INTO Invoice(n_invoice, n_autorization, id_provider, nit, date) VALUES (";
            query += nInvoice+", ";
            query += nAutorization + ", ";
            query += idProvider + ", ";
            query += nit + ", ";
            query += date.ToString("dd/MM/yyyy")+")";
            //MessageBox.Show(query);
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

        public int searchProvider(String providerName)//refactorizar
        {
            String query = "select id FROM Provider where Provider = '" + providerName + "'";
            int id = c.FindAndGetID(query);

    
            if (id < 0)
            {
                query = "insert into Provider (Provider) values('" + providerName + "')";
                c.executeInsertion(query);
                query = "select id FROM Provider where Provider = '" + providerName + "'";
                id = c.FindAndGetID(query);
                MessageBox.Show("Nuevo proveedor registrado en el programa: " + providerName, "Nuevo Proveedor");
            }
            return id;
        }

        public void registerInvoicesRows(Invoice invoice)
        {
            int counter = 0;
            foreach (InvoiceRow row in invoice.getInvoiceRows())
            {
                registerInvoiceRow(row,invoice.getNInvoice());
                counter++;
            }
            MessageBox.Show(counter+" filas de la facturas insertadas","INFORME");
        }

        public void registerInvoiceRow(InvoiceRow row,int nFact)
        {
            String quantity = row.getQuantity() + ""
                , unitPrice= row.getUnitPrice() + ""
                , total=row.getTotal()+"";
            searchProduct(row.getProduct());
            int idPpu = insertProduct(row.getProduct());
            String queryInsertion = "INSERT INTO invoice_row (n_invoice, id_ppu, quantity, unit_price, total) VALUES(";
            queryInsertion += nFact + ", ";
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
                + "id_prod="+idProd+" and id_prov="+idProv+" and id_uni="+idUni+")";
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
            ProductController productController = new ProductController();
            int affected = productController.insertProduct(name, proveedor, unidad);
            if (affected > 0)
            {
                productController.addReferencesToTableProduct_Provider_Unit(name, proveedor, unidad);
            }
        }
    }
}
