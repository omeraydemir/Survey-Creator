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
        ANKET ANKET = new ANKET();
        SORULAR SORULAR;

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
                btnSecenekEkle.Visible = true;

                label3.Visible = true;
                lbSecenekler.Visible = true;

                lblSecenek.Text = "Seçenek";
                btnSecenekEkle.Text = "Seçenek Ekle";

                label3.Text = "Seçenekler";

            }
            else if (cmbSoruTipi.SelectedItem.ToString() == "Puanlı Soru")
            {
                lblSecenek.Visible = true;
                txtSecenek.Visible = true;
                btnSecenekEkle.Visible = true;

                lblSecenek.Text = "Puan Başlığı";
                btnSecenekEkle.Text = "Puan Ekle";

                label3.Visible = true;
                lbSecenekler.Visible = true;

                label3.Text = "Puan Başlıkları";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbSoruTipi.SelectedIndex = cmbSoruTipi.FindStringExact("Kısa Metin Sorusu");

            lvSorular.View = View.Details;
            lvSorular.GridLines = true;
            lvSorular.FullRowSelect = true;

            lvSorular.Columns.Add("Soru Başlığı", 120);
            lvSorular.Columns.Add("Soru Açıklaması", 120);
            lvSorular.Columns.Add("Soru Tipi", 120);
            lvSorular.Columns.Add("Seçenekler", 120);
            lvSorular.Columns.Add("Puanlar Başlıkları", 120);
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            String soruBasligi = txtSoruBasligi.Text;
            String SoruAciklamasi = txtSoruAciklamasi.Text;

            if (soruBasligi == "")
            {
                MessageBox.Show("Soru Başlığını Boş Geçmeyiniz.");
                return;
            }
            else if (cmbSoruTipi.SelectedItem == null)
            {
                MessageBox.Show("Soru Tipi Seçiniz.");
                return;
            }
            else if (cmbSoruTipi.SelectedItem.ToString() == "Seçenekli Soru" && lbSecenekler.Items.Count < 2)
            {
                MessageBox.Show("En Az iki Seçenek Ekleyiniz.");
                return;
            }
            else if (cmbSoruTipi.SelectedItem.ToString() == "Puanlı Soru" && lbSecenekler.Items.Count < 2)
            {
                MessageBox.Show("En Az iki Puan Başlığı Ekleyiniz.");
                return;
            }

            String sorutipi = cmbSoruTipi.SelectedItem.ToString();

            String Secenekler = "";
            String Puanlar = "";
            List<String> lstSecenekler = new List<string>();
            List<String> lstPuanlar = new List<string>();

            foreach (var item in lbSecenekler.Items)
            {
                if (cmbSoruTipi.SelectedItem.ToString() == "Seçenekli Soru")
                {
                    Secenekler += item + ", ";
                    lstSecenekler.Add(item.ToString());
                }
                else if (cmbSoruTipi.SelectedItem.ToString() == "Puanlı Soru")
                {
                    Puanlar += item + ", ";
                    lstPuanlar.Add(item.ToString());
                }
            }

            if (cmbSoruTipi.SelectedItem.ToString() == "Seçenekli Soru")
                Secenekler = Secenekler.Substring(0, Secenekler.Length - 2);
            else if (cmbSoruTipi.SelectedItem.ToString() == "Puanlı Soru")
                Puanlar = Puanlar.Substring(0, Puanlar.Length - 2);

            string[] row = { soruBasligi, SoruAciklamasi, sorutipi, Secenekler, Puanlar };

            var satir = new ListViewItem(row);
            lvSorular.Items.Add(satir);

            lbSecenekler.Items.Clear();
            txtSoruBasligi.Text = "";
            txtSoruAciklamasi.Text = "";
            cmbSoruTipi.SelectedIndex = cmbSoruTipi.FindStringExact("Kısa Metin Sorusu");

            SORULAR = new SORULAR();
            SORULAR.SoruBasligi = soruBasligi;
            SORULAR.SoruAciklamasi = SoruAciklamasi;
            SORULAR.SoruTipi = (enSoruTipleri)Enum.ToObject(typeof(enSoruTipleri), cmbSoruTipi.SelectedIndex);
            SORULAR.Secenekler = lstSecenekler;
            SORULAR.PuanBasliklari = lstPuanlar;

            ANKET.sorular = SORULAR;
        }

        private void btnSecenekEkle_Click(object sender, EventArgs e)
        {
            if (txtSecenek.Text.ToString() != "")
            {
                lbSecenekler.Items.Add(txtSecenek.Text.ToString());
                txtSecenek.Text = "";
            }
            else
                MessageBox.Show("Seçenek eklemek için bir şeyler yazın");
        }

        private void btnAnketiOlustur_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAnketBasligi.Text))
            {
                MessageBox.Show("Anket Başlığını Giriniz");
                return;
            }

            Boolean sayfaSayisiGoster=true;

            ANKET.AketBasligi = txtAnketBasligi.Text;
            ANKET.AnketAciklamasi = txtAnketAciklamasi.Text;
            //enSayfaYonu

            var sayfaSayisi = gbSayfaSayisi.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (sayfaSayisi.Text == "Göster")
                sayfaSayisiGoster = true;
            else
                sayfaSayisiGoster = false;

            ANKET.SayfaSayisiGoster = sayfaSayisiGoster;

            var sayfaYonu = gbSayfaYonu.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);


        }
    }
}
