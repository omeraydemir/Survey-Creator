namespace SurveyCreator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.cmbSoruTipi = new System.Windows.Forms.ComboBox();
            this.txtSoruBasligi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSecenek = new System.Windows.Forms.Label();
            this.txtSoruAciklamasi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecenek = new System.Windows.Forms.TextBox();
            this.btnSecenekEkle = new System.Windows.Forms.Button();
            this.lbSecenekler = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAnketBasligi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAnketAciklamasi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbSayfaSayisi = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbSayfaYonu = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAltBilgi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUstBilgi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lvSorular = new System.Windows.Forms.ListView();
            this.btnAnketiOlustur = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbSayfaSayisi.SuspendLayout();
            this.gbSayfaYonu.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru Başlığı";
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSoruEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSoruEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoruEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSoruEkle.Location = new System.Drawing.Point(21, 411);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(337, 42);
            this.btnSoruEkle.TabIndex = 2;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // cmbSoruTipi
            // 
            this.cmbSoruTipi.FormattingEnabled = true;
            this.cmbSoruTipi.Items.AddRange(new object[] {
            "Kısa Metin Sorusu",
            "Uzun Metin Sorusu",
            "Seçenekli Soru",
            "Puanlı Soru"});
            this.cmbSoruTipi.Location = new System.Drawing.Point(119, 87);
            this.cmbSoruTipi.Name = "cmbSoruTipi";
            this.cmbSoruTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbSoruTipi.TabIndex = 3;
            this.cmbSoruTipi.SelectedValueChanged += new System.EventHandler(this.cmbSoruTipi_SelectedValueChanged);
            // 
            // txtSoruBasligi
            // 
            this.txtSoruBasligi.Location = new System.Drawing.Point(119, 35);
            this.txtSoruBasligi.Name = "txtSoruBasligi";
            this.txtSoruBasligi.Size = new System.Drawing.Size(121, 20);
            this.txtSoruBasligi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soru Tipi";
            // 
            // lblSecenek
            // 
            this.lblSecenek.AutoSize = true;
            this.lblSecenek.Location = new System.Drawing.Point(32, 117);
            this.lblSecenek.Name = "lblSecenek";
            this.lblSecenek.Size = new System.Drawing.Size(83, 13);
            this.lblSecenek.TabIndex = 6;
            this.lblSecenek.Text = "Seçenek Başlığı";
            this.lblSecenek.Visible = false;
            // 
            // txtSoruAciklamasi
            // 
            this.txtSoruAciklamasi.Location = new System.Drawing.Point(119, 61);
            this.txtSoruAciklamasi.Name = "txtSoruAciklamasi";
            this.txtSoruAciklamasi.Size = new System.Drawing.Size(121, 20);
            this.txtSoruAciklamasi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soru Açıklaması";
            // 
            // txtSecenek
            // 
            this.txtSecenek.Location = new System.Drawing.Point(119, 114);
            this.txtSecenek.Name = "txtSecenek";
            this.txtSecenek.Size = new System.Drawing.Size(121, 20);
            this.txtSecenek.TabIndex = 9;
            this.txtSecenek.Visible = false;
            // 
            // btnSecenekEkle
            // 
            this.btnSecenekEkle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSecenekEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecenekEkle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSecenekEkle.Location = new System.Drawing.Point(246, 112);
            this.btnSecenekEkle.Name = "btnSecenekEkle";
            this.btnSecenekEkle.Size = new System.Drawing.Size(94, 23);
            this.btnSecenekEkle.TabIndex = 10;
            this.btnSecenekEkle.Text = "Seçenek Ekle";
            this.btnSecenekEkle.UseVisualStyleBackColor = true;
            this.btnSecenekEkle.Visible = false;
            this.btnSecenekEkle.Click += new System.EventHandler(this.btnSecenekEkle_Click);
            // 
            // lbSecenekler
            // 
            this.lbSecenekler.FormattingEnabled = true;
            this.lbSecenekler.Location = new System.Drawing.Point(119, 141);
            this.lbSecenekler.Name = "lbSecenekler";
            this.lbSecenekler.Size = new System.Drawing.Size(221, 251);
            this.lbSecenekler.TabIndex = 11;
            this.lbSecenekler.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seçenekler";
            this.label3.Visible = false;
            // 
            // txtAnketBasligi
            // 
            this.txtAnketBasligi.Location = new System.Drawing.Point(108, 30);
            this.txtAnketBasligi.Name = "txtAnketBasligi";
            this.txtAnketBasligi.Size = new System.Drawing.Size(239, 20);
            this.txtAnketBasligi.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Anket Başlığı";
            // 
            // txtAnketAciklamasi
            // 
            this.txtAnketAciklamasi.Location = new System.Drawing.Point(108, 56);
            this.txtAnketAciklamasi.Multiline = true;
            this.txtAnketAciklamasi.Name = "txtAnketAciklamasi";
            this.txtAnketAciklamasi.Size = new System.Drawing.Size(239, 45);
            this.txtAnketAciklamasi.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Anket açıklaması";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.gbSayfaSayisi);
            this.groupBox1.Controls.Add(this.gbSayfaYonu);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtAltBilgi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtUstBilgi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAnketAciklamasi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAnketBasligi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 459);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sayfa Özellikleri";
            // 
            // gbSayfaSayisi
            // 
            this.gbSayfaSayisi.Controls.Add(this.radioButton3);
            this.gbSayfaSayisi.Controls.Add(this.radioButton4);
            this.gbSayfaSayisi.Location = new System.Drawing.Point(108, 197);
            this.gbSayfaSayisi.Name = "gbSayfaSayisi";
            this.gbSayfaSayisi.Size = new System.Drawing.Size(239, 36);
            this.gbSayfaSayisi.TabIndex = 27;
            this.gbSayfaSayisi.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 17);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Göster";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(68, 13);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 17);
            this.radioButton4.TabIndex = 26;
            this.radioButton4.Text = "Gösterme";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gbSayfaYonu
            // 
            this.gbSayfaYonu.Controls.Add(this.radioButton1);
            this.gbSayfaYonu.Controls.Add(this.radioButton2);
            this.gbSayfaYonu.Location = new System.Drawing.Point(108, 104);
            this.gbSayfaYonu.Name = "gbSayfaYonu";
            this.gbSayfaYonu.Size = new System.Drawing.Size(239, 36);
            this.gbSayfaYonu.TabIndex = 18;
            this.gbSayfaYonu.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 25;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dikey";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(64, 13);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 26;
            this.radioButton2.Text = "Yatay";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Sayfa Sayısı";
            // 
            // txtAltBilgi
            // 
            this.txtAltBilgi.Location = new System.Drawing.Point(108, 175);
            this.txtAltBilgi.Name = "txtAltBilgi";
            this.txtAltBilgi.Size = new System.Drawing.Size(239, 20);
            this.txtAltBilgi.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Alt Bilgi";
            // 
            // txtUstBilgi
            // 
            this.txtUstBilgi.Location = new System.Drawing.Point(108, 149);
            this.txtUstBilgi.Name = "txtUstBilgi";
            this.txtUstBilgi.Size = new System.Drawing.Size(239, 20);
            this.txtUstBilgi.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Üst Bilgi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sayfa Yönü";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSoruBasligi);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnSoruEkle);
            this.groupBox4.Controls.Add(this.lbSecenekler);
            this.groupBox4.Controls.Add(this.cmbSoruTipi);
            this.groupBox4.Controls.Add(this.btnSecenekEkle);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtSecenek);
            this.groupBox4.Controls.Add(this.lblSecenek);
            this.groupBox4.Controls.Add(this.txtSoruAciklamasi);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(384, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 459);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Soru Ekle";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lvSorular);
            this.groupBox5.Location = new System.Drawing.Point(12, 477);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(752, 209);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sorular";
            // 
            // lvSorular
            // 
            this.lvSorular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSorular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSorular.HideSelection = false;
            this.lvSorular.Location = new System.Drawing.Point(3, 16);
            this.lvSorular.Name = "lvSorular";
            this.lvSorular.Size = new System.Drawing.Size(746, 190);
            this.lvSorular.TabIndex = 0;
            this.lvSorular.UseCompatibleStateImageBehavior = false;
            // 
            // btnAnketiOlustur
            // 
            this.btnAnketiOlustur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnketiOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnketiOlustur.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAnketiOlustur.Location = new System.Drawing.Point(12, 692);
            this.btnAnketiOlustur.Name = "btnAnketiOlustur";
            this.btnAnketiOlustur.Size = new System.Drawing.Size(752, 54);
            this.btnAnketiOlustur.TabIndex = 20;
            this.btnAnketiOlustur.Text = "Anketi Oluştur ve Kaydet";
            this.btnAnketiOlustur.UseVisualStyleBackColor = true;
            this.btnAnketiOlustur.Click += new System.EventHandler(this.btnAnketiOlustur_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Logo";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(108, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Resim Seç";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(776, 758);
            this.Controls.Add(this.btnAnketiOlustur);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anket Oluşturucu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSayfaSayisi.ResumeLayout(false);
            this.gbSayfaSayisi.PerformLayout();
            this.gbSayfaYonu.ResumeLayout(false);
            this.gbSayfaYonu.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.ComboBox cmbSoruTipi;
        private System.Windows.Forms.TextBox txtSoruBasligi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSecenek;
        private System.Windows.Forms.TextBox txtSoruAciklamasi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecenek;
        private System.Windows.Forms.Button btnSecenekEkle;
        private System.Windows.Forms.ListBox lbSecenekler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAnketBasligi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAnketAciklamasi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAltBilgi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUstBilgi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbSayfaSayisi;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox gbSayfaYonu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAnketiOlustur;
        private System.Windows.Forms.ListView lvSorular;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
    }
}

