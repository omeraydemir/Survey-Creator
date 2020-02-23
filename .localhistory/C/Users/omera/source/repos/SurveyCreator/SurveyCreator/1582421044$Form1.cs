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
                lblSecenek.Enabled = true;
                txtSecenek.Enabled = true;
                btnSecenekEkle.Enabled = true;

                label3.Enabled = true;
                lbSecenekler.Enabled = true;

                lblSecenek.Text = "Seçenek";
                btnSecenekEkle.Text = "Seçenek Ekle";

                label3.Text = "Seçenekler";

            }
            else if (cmbSoruTipi.SelectedItem.ToString() == "Puanlı Soru")
            {
                lblSecenek.Enabled = true;
                txtSecenek.Enabled = true;
                btnSecenekEkle.Enabled = true;

                lblSecenek.Text = "Puan Başlığı";
                btnSecenekEkle.Text = "Puan Ekle";

                label3.Enabled = true;
                lbSecenekler.Enabled = true;

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

            lblSecenek.Enabled = false;
            txtSecenek.Enabled = false;
            btnSecenekEkle.Enabled = false;

            label3.Enabled = false;
            lbSecenekler.Enabled = false;

            lblSecenek.Text = "Seçenek";
            btnSecenekEkle.Text = "Seçenek Ekle";

            label3.Text = "Seçenekler";

            SORULAR = new SORULAR();
            SORULAR.SoruBasligi = soruBasligi;
            SORULAR.SoruAciklamasi = SoruAciklamasi;
            SORULAR.SoruTipi = (enSoruTipleri)Enum.ToObject(typeof(enSoruTipleri), cmbSoruTipi.SelectedIndex);
            SORULAR.Secenekler = lstSecenekler;
            SORULAR.PuanBasliklari = lstPuanlar;

            ANKET.sorular.Add(SORULAR);
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

            ANKET.AketBasligi = txtAnketBasligi.Text;
            ANKET.AnketAciklamasi = txtAnketAciklamasi.Text;
            ANKET.UstBilgi = txtUstBilgi.Text;
            ANKET.AltBilgi = txtAltBilgi.Text;

            Boolean sayfaSayisiGoster = true;
            var sayfaSayisi = gbSayfaSayisi.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (sayfaSayisi.Text == "Gösterme")
                sayfaSayisiGoster = false;

            ANKET.SayfaSayisiGoster = sayfaSayisiGoster;

            Boolean soruSayiniYaz = true;
            var soruSayininiYazRDB = gbSayfaSayisi.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (soruSayininiYazRDB.Text == "Yazma")
                soruSayiniYaz = false;

            ANKET.SoruSayisiniYaz = soruSayiniYaz;

            MigraDoc.DocumentObjectModel.Orientation sayfaYonu = MigraDoc.DocumentObjectModel.Orientation.Portrait;
            var sayfaYonuRDB = gbSoruSayisi.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (sayfaYonuRDB.Text == "Yatay")
                sayfaYonu = MigraDoc.DocumentObjectModel.Orientation.Landscape;

            ANKET.SayfaYonu = sayfaYonu;

            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "pdf";

            save.Filter = "Pdf Files|*.pdf";
            save.FileName = ANKET.AketBasligi + " Anketi";

            PDF PDF = new PDF(ANKET);

            PDF.OLUSTUR();

            if (save.ShowDialog() == DialogResult.OK)
            {
                PDF.KAYDET(save.FileName);
                //MessageBox.Show("Anketiniz Kaydedildi.");
                System.Diagnostics.Process.Start(@save.FileName);
            }   

        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
        }
    }
}
