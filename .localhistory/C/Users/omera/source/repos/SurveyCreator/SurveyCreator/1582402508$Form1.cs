using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Seçenekli Soru")
            {
                MessageBox.Show(comboBox1.SelectedItem.ToString());
                lblSecenek.Visible = true;
                txtSecenek.Visible = true;
                btnSecenek.Visible = true;

            }
            else if (comboBox1.SelectedItem.ToString() == "Puanlı Soru")
            {
                MessageBox.Show(comboBox1.SelectedItem.ToString());
                lblSecenek.Visible = true;
                txtSecenek.Visible = true;
                btnSecenek.Visible = true;

                lblSecenek.Text = "Puan Başlığı";
                btnSecenek.Text = "Ekle";
            }
        }
    }
}
