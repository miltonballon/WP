using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestorDeInformes
{
    class Inicio_Sesion
    {
        public Connection c = new Connection();
        public Inicio_Sesion()
        {
            c.connect();
        }
      
        public void start(TextBox usuario, TextBox contraseña, int admin)
        {
            if (admin == 1)
            {
                InterfazPrincipal Index = new InterfazPrincipal();
                Index.ShowDialog();
                contraseña.Text = "";

            }
            else
            {
                
                }

            }
        }
        
       
        
    }
