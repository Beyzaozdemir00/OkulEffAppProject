namespace OkulEffAppProject
{
    partial class Form2
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
            dataGridViewDersler = new DataGridView();
            btnKaydet = new Button();
            lblOgrenciBilgileri = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewDersler
            // 
            dataGridViewDersler.AllowUserToAddRows = false;
            dataGridViewDersler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDersler.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridViewDersler.Location = new Point(29, 108);
            dataGridViewDersler.Name = "dataGridViewDersler";
            dataGridViewDersler.RowHeadersWidth = 51;
            dataGridViewDersler.RowTemplate.Height = 29;
            dataGridViewDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDersler.Size = new Size(702, 246);
            dataGridViewDersler.TabIndex = 0;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(305, 370);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(137, 29);
            btnKaydet.TabIndex = 1;
            btnKaydet.Text = "Ders Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lblOgrenciBilgileri
            // 
            lblOgrenciBilgileri.AutoSize = true;
            lblOgrenciBilgileri.Location = new Point(29, 32);
            lblOgrenciBilgileri.Name = "lblOgrenciBilgileri";
            lblOgrenciBilgileri.Size = new Size(116, 20);
            lblOgrenciBilgileri.TabIndex = 2;
            lblOgrenciBilgileri.Text = "Öğrenci Bilgileri";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(lblOgrenciBilgileri);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridViewDersler);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDersler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewDersler;
        private Button btnKaydet;
        private Label lblOgrenciBilgileri;
    }
}