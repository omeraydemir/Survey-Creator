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
            this.lstSoru = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSecenek = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSecenek = new System.Windows.Forms.TextBox();
            this.btnSecenek = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSoru
            // 
            this.lstSoru.FormattingEnabled = true;
            this.lstSoru.Location = new System.Drawing.Point(355, 1);
            this.lstSoru.Name = "lstSoru";
            this.lstSoru.Size = new System.Drawing.Size(385, 485);
            this.lstSoru.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru Başlığı";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Soru Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kısa Metin Sorusu",
            "Uzun Metin Sorusu",
            "Seçenekli Soru",
            "Puanlı Soru"});
            this.comboBox1.Location = new System.Drawing.Point(117, 90);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Soru Tipi";
            // 
            // lblSecenek
            // 
            this.lblSecenek.AutoSize = true;
            this.lblSecenek.Location = new System.Drawing.Point(30, 120);
            this.lblSecenek.Name = "lblSecenek";
            this.lblSecenek.Size = new System.Drawing.Size(83, 13);
            this.lblSecenek.TabIndex = 6;
            this.lblSecenek.Text = "Seçenek Başlığı";
            this.lblSecenek.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Soru Açıklaması";
            // 
            // txtSecenek
            // 
            this.txtSecenek.Location = new System.Drawing.Point(117, 117);
            this.txtSecenek.Name = "txtSecenek";
            this.txtSecenek.Size = new System.Drawing.Size(121, 20);
            this.txtSecenek.TabIndex = 9;
            this.txtSecenek.Visible = false;
            // 
            // btnSecenek
            // 
            this.btnSecenek.Location = new System.Drawing.Point(244, 115);
            this.btnSecenek.Name = "btnSecenek";
            this.btnSecenek.Size = new System.Drawing.Size(94, 23);
            this.btnSecenek.TabIndex = 10;
            this.btnSecenek.Text = "Seçenek Ekle";
            this.btnSecenek.UseVisualStyleBackColor = true;
            this.btnSecenek.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(97, 181);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(241, 303);
            this.listBox1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Seçenekler";
            this.label3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSecenek);
            this.Controls.Add(this.txtSecenek);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSecenek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSoru);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Anket Oluşturucu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSecenek;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSecenek;
        private System.Windows.Forms.Button btnSecenek;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
    }
}

