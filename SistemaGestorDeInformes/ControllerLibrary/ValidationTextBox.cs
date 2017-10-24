using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControllerLibrary
{
    public class ValidationTextBox
    {
        public void BlockTextbox(object sender, KeyEventArgs e)
        {
            if (e.Control == true)
            {
                MessageBox.Show("Las opciones Cortar/Copiar y Pegar están deshabilitadas");
            }
        }

    }
}
