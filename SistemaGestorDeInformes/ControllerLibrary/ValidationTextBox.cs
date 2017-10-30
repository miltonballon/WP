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


        public virtual void CharacterEspecial(object sender, KeyPressEventArgs e, Form form1, Form form2)
        {
            EventHandler handler = ThresholdReached;
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8) || (e.KeyChar == 32))
                e.Handled = false;
            else
                e.Handled = true;
        }

        public void CharacterEspecial(object sender, KeyPressEventArgs e, global::SistemaGestorDeInformes.RegisterUser registerUser)
        {
            throw new NotImplementedException();
        }
    }
}
