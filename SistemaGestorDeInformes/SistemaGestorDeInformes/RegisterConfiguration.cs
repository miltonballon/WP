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
           // int numero = Convert.ToInt32(NumberOfScholarships_textBox.Text);
            Configuration configuration = new Configuration(Convert.ToInt32(NumberOfScholarships_textBox.Text), Convert.ToInt32(NumberOGames_textBox.Text), Convert.ToInt32(DaysToBeat_textBox.Text), Convert.ToInt32(MinimumNumberOfScholarships_textBox.Text));
            configurationController.insertConfiguration(configuration);


        }
    }
}
