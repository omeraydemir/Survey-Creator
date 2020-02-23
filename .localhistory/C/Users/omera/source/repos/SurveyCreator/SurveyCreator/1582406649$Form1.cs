﻿using System;
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



        private void cmbSoruTipi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbSoruTipi.SelectedItem.ToString() == "Seçenekli Soru")
            {
                lblSecenek.Visible = true;
                txtSecenek.Visible = true;
                btnSecenek.Visible = true;

                label3.Visible = true;
                lbSecenekler.Visible = true;

                lblSecenek.Text = "Seçenek";
                btnSecenek.Text = "Seçenek Ekle";

                label3.Text = "Seçenekler";

            }
            else if (cmbSoruTipi.SelectedItem.ToString() == "Puanlı Soru")
            {
                lblSecenek.Visible = true;
                txtSecenek.Visible = true;
                btnSecenek.Visible = true;

                lblSecenek.Text = "Puan Başlığı";
                btnSecenek.Text = "Puan Ekle";

                label3.Visible = true;
                lbSecenekler.Visible = true;

                label3.Text = "Puan Başlıkları";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvSorular.View = View.Details;
            lvSorular.GridLines = true;
            //lvSorular.FullRowSelect = true;

            lvSorular.Columns.Add("Soru Başlığı",120);
            lvSorular.Columns.Add("Soru Açıklaması",120);
            lvSorular.Columns.Add("Soru Tipi",120);
            lvSorular.Columns.Add("Seçenekler",120);
            lvSorular.Columns.Add("Puanlar Başlıkları",120);
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            String soruBasligi = txtSoruBasligi.Text;
            String SoruAciklamasi = txtSoruAciklamasi.Text;
            String sorutipi = cmbSoruTipi.SelectedItem.ToString();
            

            string[] row = { txtSoruBasligi.Text, txtSoruAciklamasi.Text, textBox3.Text };
            var satir = new ListViewItem(row);
            lvSorular.Items.Add(satir);
        }
    }
}