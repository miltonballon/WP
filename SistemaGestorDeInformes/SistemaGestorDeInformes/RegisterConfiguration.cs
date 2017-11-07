using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLibrary;
using ControllerLibrary;
namespace SistemaGestorDeInformes
{
   
    public partial class RegisterConfiguration : Form
    {
        ConfigurationController configurationController;
        public RegisterConfiguration()
        {
            InitializeComponent();
            configurationController = new ConfigurationController();
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Configuration configuration = new Configuration(Convert.ToInt32(NumberOfScholarships_textBox.Text), Convert.ToInt32(NumberOGames_textBox.Text), Convert.ToInt32(DaysToBeat_textBox.Text), Convert.ToInt32(MinimumNumberOfScholarships_textBox.Text));
            configurationController.insertConfiguration(configuration);
            MessageBox.Show("Registro guardado con éxito");

            NumberOfScholarships_textBox.Text = "";
            NumberOGames_textBox.Text = "";
            DaysToBeat_textBox.Text = "";
            MinimumNumberOfScholarships_textBox.Text = "";
            NumberOfScholarships_textBox.Focus();
            this.Hide();

            Main mos = new Main();
            mos.Show();


        }

        private void Skip_button_Click(object sender, EventArgs e)
        {
            Login mos = new Login();
            mos.Show();
        }
    }
}
