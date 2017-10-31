using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using EntityLibrary;

namespace ControllerLibrary
{
    public class OutputReceptionController
    {
        private Connection c = new Connection();
        private ProductController productController;
        private ReceptionController receptionController;
        private InventoryController inventoryController;

        public OutputReceptionController()
        {
            c.connect();
            productController = new ProductController();
            receptionController = new ReceptionController();
            inventoryController = new InventoryController();
        }
        public void ProductAutoComplete(TextBox Product)
        {
            string query = "SELECT name FROM Product";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Product.AutoCompleteCustomSource.Add(data["name"].ToString());

            }
            c.dataClose();
            data.Close();
        }
        public void ProviderAutoComplete(TextBox Provider)
        {
            string query = "SELECT Provider FROM Provider";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Provider.AutoCompleteCustomSource.Add(data["Provider"].ToString());
            }
            c.dataClose();
            data.Close();
        }
        public void UnitAutoComplete(TextBox Unit)
        {
            string query = "SELECT Type FROM Unit";

            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                Unit.AutoCompleteCustomSource.Add(data["Type"].ToString());
            }
            c.dataClose();
            data.Close();
        }
        /*
        public void RegisterOutputReception(TextBox Product, TextBox Unit,TextBox OutputDate, TextBox Total)
        {
            int idName = getIdName(Product.Text.ToString());
            int idUnit = getIdUnit(Unit.Text.ToString());
            int notExist = -1;
            string queryPPU = "SELECT id FROM Product_Provider_Unit where id_prod='" + idName + "' and id_uni='" + idUnit + "'";
            SQLiteDataReader data = c.query_show(queryPPU);
            
            int resul = -1;
            while (data.Read())
            {
                resul = Int32.Parse(data[0].ToString());
            }
            //c.dataClose();
            data.Close();

            string queryIDReception = "SELECT id FROM Reception where ppu_id='" + resul + "'";
            SQLiteDataReader data2 = c.query_show(queryIDReception);

            int resulReception = -1;
            while (data2.Read())
            {
                resulReception = Int32.Parse(data2[0].ToString());
            }
            c.dataClose();
            data2.Close();

            if (idName != notExist && idUnit != notExist && resul != notExist && resulReception != notExist)
            {
                Reception reception = receptionController.getReceptionById(resulReception);
                reception.Total = reception.Total - Int32.Parse(Total.Text);
                if (reception.Total >= 0)
                {
                    InsertOutputReception(resulReception, OutputDate, Total);
                    receptionController.updateReception(resulReception, reception);
                    MessageBox.Show("Salida registrada correctamente");
                }
                else
                {
                    MessageBox.Show("No se posee tantas reservas en el inventario, retire una suma menor");
                }
            }
            else
            {
                MessageBox.Show("No existe recepcion de dicho producto en el inventario o el producto se acabo, verifique las recepciones o el inventario fisico ");
            }
        }

        */
        public void InsertOutputReceptionAndInventory(OutputReception outputReception)
        {
            int idName = getIdName(outputReception.Reception.Product.Name);

            int idUnit = getIdUnit(outputReception.Reception.Product.Unit);
            int notExist = -1;
            string queryPPU = "SELECT id FROM Product_Provider_Unit where id_prod='" + idName + "' and id_uni='" + idUnit + "'";
            SQLiteDataReader data = c.query_show(queryPPU);
            
            int resul = -1;
            while (data.Read())
            {
                resul = Int32.Parse(data[0].ToString());
            }
            //c.dataClose();
            data.Close();

            string queryIDReception = "SELECT id FROM Reception where ppu_id='" + resul + "'";
            SQLiteDataReader data2 = c.query_show(queryIDReception);

            int resulReception = -1;
            while (data2.Read())
            {
                resulReception = Int32.Parse(data2[0].ToString());
            }
            c.dataClose();
            data2.Close();
            if (idName != notExist && idUnit != notExist && resul != notExist && resulReception != notExist)
            {
                
                if (inventoryController.ifProductIsAvailable(outputReception,resul))
                {
                    InsertOutputReception(resulReception, outputReception);
                    inventoryController.ModifyInventory(resul, outputReception);
                    MessageBox.Show("Salida registrada correctamente");

                }
                else
                {
                    MessageBox.Show("No se posee tantas reservas en el inventario, retire una suma menor");
                }
            }
            
            
            
        }
        public void InsertOutputReception(int id, OutputReception reception)
        {

            string query = "INSERT INTO OutputReception (id_reception,output_total,output_date) values('" + id + "','" + reception.Total + "','" + reception.OutputDate + "')";
            c.executeInsertion(query);
        }
        public int getIdName(string name)
        {
            string NameQuery = "select id FROM Product where name = " + "'" + name + "'";
            return c.FindAndGetID(NameQuery); //-si retorna -1 quiere decir que esta vacio la consulta y no existe el elemento
        }
        public int getIdProvider(string provider)
        {
            string ProviderQuery = "select id FROM Provider where Provider = " + "'" + provider + "'";
            return c.FindAndGetID(ProviderQuery);
        }
        public int getIdUnit(string unit)
        {
            string UnitQuery = "select id FROM Unit where Type = " + "'" + unit + "'";
            return c.FindAndGetID(UnitQuery);
        }
    }
}
