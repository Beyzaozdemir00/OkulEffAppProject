namespace OkulEffAppProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewOgrenciler = new DataGridView();
            lblad = new Label();
            lblsoyad = new Label();
            lblnumara = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNumara = new TextBox();
            lblsınıf = new Label();
            comboBoxSinif = new ComboBox();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            btnBul = new Button();
            btnDersSec = new Button();
            grpogrenciekle = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).BeginInit();
            grpogrenciekle.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOgrenciler
            // 
            dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciler.Location = new Point(0, 366);
            dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            dataGridViewOgrenciler.RowHeadersWidth = 51;
            dataGridViewOgrenciler.RowTemplate.Height = 29;
            dataGridViewOgrenciler.Size = new Size(646, 115);
            dataGridViewOgrenciler.TabIndex = 0;
            // 
            // lblad
            // 
            lblad.AutoSize = true;
            lblad.Location = new Point(100, 53);
            lblad.Name = "lblad";
            lblad.Size = new Size(28, 20);
            lblad.TabIndex = 1;
            lblad.Text = "Ad";
            // 
            // lblsoyad
            // 
            lblsoyad.AutoSize = true;
            lblsoyad.Location = new Point(78, 91);
            lblsoyad.Name = "lblsoyad";
            lblsoyad.Size = new Size(50, 20);
            lblsoyad.TabIndex = 2;
            lblsoyad.Text = "Soyad";
            // 
            // lblnumara
            // 
            lblnumara.AutoSize = true;
            lblnumara.Location = new Point(78, 133);
            lblnumara.Name = "lblnumara";
            lblnumara.Size = new Size(62, 20);
            lblnumara.TabIndex = 3;
            lblnumara.Text = "Numara\r\n";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(153, 50);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(153, 88);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(153, 130);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(150, 27);
            txtNumara.TabIndex = 6;
            // 
            // lblsınıf
            // 
            lblsınıf.AutoSize = true;
            lblsınıf.Location = new Point(52, 171);
            lblsınıf.Name = "lblsınıf";
            lblsınıf.Size = new Size(88, 20);
            lblsınıf.TabIndex = 7;
            lblsınıf.Text = "Sınıf Seçiniz";
            // 
            // comboBoxSinif
            // 
            comboBoxSinif.FormattingEnabled = true;
            comboBoxSinif.Items.AddRange(new object[] { "", "" });
            comboBoxSinif.Location = new Point(153, 171);
            comboBoxSinif.Name = "comboBoxSinif";
            comboBoxSinif.Size = new Size(151, 28);
            comboBoxSinif.TabIndex = 8;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(119, 288);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(94, 29);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(254, 288);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnBul
            // 
            btnBul.Location = new Point(382, 288);
            btnBul.Name = "btnBul";
            btnBul.Size = new Size(94, 29);
            btnBul.TabIndex = 11;
            btnBul.Text = "Bul";
            btnBul.UseVisualStyleBackColor = true;
            btnBul.Click += btnBul_Click;
            // 
            // btnDersSec
            // 
            btnDersSec.Location = new Point(238, 323);
            btnDersSec.Name = "btnDersSec";
            btnDersSec.Size = new Size(132, 37);
            btnDersSec.TabIndex = 12;
            btnDersSec.Text = "Ders Seçimi";
            btnDersSec.UseVisualStyleBackColor = true;
            btnDersSec.Click += btnDersSec_Click;
            // 
            // grpogrenciekle
            // 
            grpogrenciekle.Controls.Add(lblad);
            grpogrenciekle.Controls.Add(txtAd);
            grpogrenciekle.Controls.Add(lblsoyad);
            grpogrenciekle.Controls.Add(txtSoyad);
            grpogrenciekle.Controls.Add(lblnumara);
            grpogrenciekle.Controls.Add(comboBoxSinif);
            grpogrenciekle.Controls.Add(txtNumara);
            grpogrenciekle.Controls.Add(lblsınıf);
            grpogrenciekle.Location = new Point(85, 29);
            grpogrenciekle.Name = "grpogrenciekle";
            grpogrenciekle.Size = new Size(448, 253);
            grpogrenciekle.TabIndex = 13;
            grpogrenciekle.TabStop = false;
            grpogrenciekle.Text = "Öğrenci Ekleme";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 479);
            Controls.Add(grpogrenciekle);
            Controls.Add(btnDersSec);
            Controls.Add(btnBul);
            Controls.Add(btnKaydet);
            Controls.Add(btnGuncelle);
            Controls.Add(dataGridViewOgrenciler);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).EndInit();
            grpogrenciekle.ResumeLayout(false);
            grpogrenciekle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewOgrenciler;
        private Label lblad;
        private Label lblsoyad;
        private Label lblnumara;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNumara;
        private Label lblsınıf;
        private ComboBox comboBoxSinif;
        private Button btnGuncelle;
        private Button btnKaydet;
        private Button btnBul;
        private Button btnDersSec;
        private GroupBox grpogrenciekle;
    }
}