using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace SistemaGestorDeInformes
{
    public class ReceptionController
    {

        private Connection c = new Connection();
        private ProductController productController;
        public ReceptionController()
        {
            c.connect();
            productController = new ProductController();
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
        public void RegisterReception(TextBox Product, TextBox Provider, TextBox Unit, DateTimePicker ExpirationDate, DateTimePicker ReceptionDate, TextBox Total)
        {
            int idName = getIdName(Product.Text.ToString());
            int idProvider = getIdProvider(Provider.Text.ToString());
            int idUnit = getIdUnit(Unit.Text.ToString());
            int notExist=-1;
            string queryPPU= "SELECT id FROM Product_Provider_Unit where id_prod='"+idName+"' and id_prov='"+idProvider+"' and id_uni='"+idUnit+"'";
            SQLiteDataReader data = c.query_show(queryPPU);
            int resul = -1;
            while (data.Read())
            {
                resul = Int32.Parse(data[0].ToString());   
            }
            c.dataClose();
            data.Close();
            if (idName != notExist && idProvider != notExist && idUnit != notExist && resul != notExist)
            {
                InsertReception(resul, ExpirationDate, ReceptionDate, Total);
                MessageBox.Show("Registrado Correctamente");
            }
            else
            {
                MessageBox.Show("El producto no existe, registre el producto previamente");
            }
        }

        public void InsertReception(int id, DateTimePicker expiration, DateTimePicker reception, TextBox total)
        {
            string query = "INSERT INTO Reception (ppu_id,receptionDate,expirationDate,total) values('" + id + "','" + expiration.Text + "','" + reception.Text + "','" + Int32.Parse(total.Text) + "')";
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

        public List<Reception> getAllReceptions()
        {
            List<Reception> receptions = new List<Reception>();
            string query = "SELECT * FROM Reception";
            try
            {
                SQLiteDataReader data = c.query_show(query);
                while (data.Read())
                {
                    int ppuId=Int32.Parse(data[1].ToString()), 
                        total= Int32.Parse(data[4].ToString());
                    String recDate=data[2].ToString(), 
                           expDate= data[3].ToString();
                    Product product = productController.getProductByPPUId(ppuId);
                    Reception reception = new Reception(product,recDate,expDate,total);
                    receptions.Add(reception);
                }
            }
            catch (Exception)
            { }
            c.dataClose();
            return receptions;
        }

        public Reception getReceptionById(int id)
        {
            Reception reception=null;
            String query = "SELECT * FROM Reception WHERE id="+id;
            SQLiteDataReader data = c.query_show(query);
            while (data.Read())
            {
                int ppuId = Int32.Parse(data[1].ToString()),
                    total = Int32.Parse(data[4].ToString());
                String recDate = data[2].ToString(),
                       expDate = data[3].ToString();
                Product product = productController.getProductByPPUId(ppuId);
                reception = new Reception(product, recDate, expDate, total);
            }
            c.dataClose();
            return reception;
        }

        public void updateReception(int idReception, Reception reception)
        {
            String expDate=reception.ExpirationDate;
            int total=reception.Unit;
            String query = "UPDATE Reception SET total="+total+", expirationDate='"+expDate+"' WHERE id="+idReception;
            c.executeInsertion(query);
        }
   
    }
}
