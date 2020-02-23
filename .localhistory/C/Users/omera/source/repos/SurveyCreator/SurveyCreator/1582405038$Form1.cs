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
                lblSecenek.Visible = true;
                txtSecenek.Visible = true;
                btnSecenek.Visible = true;

                label3.Visible = true;
                listBox1.Visible = true;

                lblSecenek.Text = "Seçenek";
                btnSecenek.Text = "Seçenek Ekle";

                label3.Text = "Seçenekler";

            }
            else if (comboBox1.SelectedItem.ToString() == "Puanlı Soru")
            {
                lblSecenek.Visible = true;
                txtSecenek.Visible = true;
                btnSecenek.Visible = true;

                lblSecenek.Text = "Puan Başlığı";
                btnSecenek.Text = "Puan Ekle";

                label3.Visible = true;
                listBox1.Visible = true;

                label3.Text = "Puan Başlıkları";
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
