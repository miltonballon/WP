using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaGestorDeInformes
{
    class Restablecer_Contraseña
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCmd;
        private string strCmd;
        public Restablecer_Contraseña()

        {
            //conexionBD BD = new conexionBD();
            //sqlCon = BD.stringConexionBD();
        }
        public bool existeCi(string ci)
        {
            strCmd = "Select * from [usuarios]where ci='" + ci + "'";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
        public bool existeUser(string usuario, string ci)
        {
            strCmd = "Select * from [usuarios]where usuario='" + usuario + "' and ci='" + ci + "'";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            SqlDataReader dr = sqlCmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                return false;
            }
        }
        public void guardar(TextBox confirmar, TextBox ci)
        {
            strCmd = "Update [usuarios] set contraseña='" + confirmar.Text + "'where ci='" + ci.Text + "'";
            sqlCmd = new SqlCommand(strCmd, sqlCon);
            sqlCmd.ExecuteNonQuery();
        }
    }
}
