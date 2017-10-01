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
        public InterfazRegistrarFactura()
        {
            InitializeComponent();
            this.textBoxNit.KeyPress += new KeyPressEventHandler(textBoxNit_TextChanged);//Para impedir que se pongan letras y espacios en el NIT
            this.textBoxNFactura.KeyPress += new KeyPressEventHandler(textBoxNFactura_TextChanged);//Para impedir que se pongan letras y espacios en el N.FACTURA
            this.textBoxNAutorizacion.KeyPress += new KeyPressEventHandler(textBoxNAutorizacion_TextChanged);//Para impedir que se pongan letras y espacios en el N.AUTORIZACION
        }

        private void InterfazRegistrarFactura_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNit_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);//Para impedir que se pongan letras y espacios en el NIT
        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNFactura_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);//Para impedir que se pongan letras y espacios en el N.FACTURA
        }

        private void textBoxNAutorizacion_TextChanged(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);//Para impedir que se pongan letras y espacios en el N.AUTORIZACION
        }
    }
}
