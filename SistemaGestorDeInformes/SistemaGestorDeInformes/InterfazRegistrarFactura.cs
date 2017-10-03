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
        private ControladorFactura controladorFactura;
        public InterfazRegistrarFactura()
        {
            InitializeComponent();
            this.textBoxNit.KeyPress += new KeyPressEventHandler(textBoxNit_TextChanged);//Para impedir que se pongan letras y espacios en el NIT
            this.textBoxNFactura.KeyPress += new KeyPressEventHandler(textBoxNFactura_TextChanged);//Para impedir que se pongan letras y espacios en el N.FACTURA
            this.textBoxNAutorizacion.KeyPress += new KeyPressEventHandler(textBoxNAutorizacion_TextChanged);//Para impedir que se pongan letras y espacios en el N.AUTORIZACION
            controladorFactura = new ControladorFactura();
        }

        private void InterfazRegistrarFactura_Load(object sender, EventArgs e)
        {

        }

        private void textBoxProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNit_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el NIT
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != 08 && e.KeyChar != 22 && e.KeyChar != 3 && e.KeyChar != 24)
                e.Handled = true;
        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNFactura_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el N.FACTURA
            if(e.KeyChar!='1' && e.KeyChar!= '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != 08 && e.KeyChar != 22 && e.KeyChar != 3 && e.KeyChar != 24)
                e.Handled = true;
        }

        private void textBoxNAutorizacion_TextChanged(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios en el N.AUTORIZACION
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != 08 && e.KeyChar != 22 && e.KeyChar != 3 && e.KeyChar != 24)
                e.Handled = true;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if ((dataGridView1.CurrentCell.ColumnIndex == 2)||(dataGridView1.CurrentCell.ColumnIndex == 3)) //Busca las columnas Cantidad y Precio Unitario del dataGridView1
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells[dataGridView1.Columns["PrecioTotal"].Index].Value = (Convert.ToDouble(row.Cells[dataGridView1.Columns["PrecioUnitario"].Index].Value) * Convert.ToDouble(row.Cells[dataGridView1.Columns["Cantidad"].Index].Value));//Caclula el Precio Total sumando la columna Cantidad con la columna Precio Unidad
            }
        }

        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para impedir que se pongan letras y espacios a excepcion de: ., copiar, pegar, cortar
            if (e.KeyChar != '1' && e.KeyChar != '2' && e.KeyChar != '3' && e.KeyChar != '4' && e.KeyChar != '5' && e.KeyChar != '6' && e.KeyChar != '7' && e.KeyChar != '8' && e.KeyChar != '9' && e.KeyChar != '0' && e.KeyChar != 08 && e.KeyChar != '.' && e.KeyChar != 22 && e.KeyChar != 3 && e.KeyChar != 24)
                e.Handled = true;
        }

        private void pantallaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();
            principal.Show();
            this.Hide();
        }

        private void buttonAtrás_Click_1(object sender, EventArgs e)
        {
            InterfazPrincipal principal = new InterfazPrincipal();//para volver atras
            this.Hide();
            principal.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Factura factura = crearFactura();
            controladorFactura.insertarFactura(factura);
        }

        private Factura crearFactura()
        {
            int nFactura = Int32.Parse(textBoxNFactura.Text),
                nAutorizacion = Int32.Parse(textBoxNAutorizacion.Text),
                nit = Int32.Parse(textBoxNit.Text);
            String proveedor = textBoxProveedor.Text;
            DateTime fecha = dateFecha.Value;
            Factura factura = new Factura(proveedor, nit, nFactura, nAutorizacion, fecha);
            return factura;
        }
    }
}
