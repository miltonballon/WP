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

     


        public event EventHandler ThresholdReached;
        public virtual void KeyEscape(object sender, KeyEventArgs e, Form form1, Form form2)
        {
            EventHandler handler = ThresholdReached;
            if (e.KeyCode == Keys.Escape)
            {
                form2.Show();
                form1.Hide();
            }
        }


    }
}
