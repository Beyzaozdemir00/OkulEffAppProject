using Microsoft.EntityFrameworkCore;
using OkulEffAppProject.Models;

namespace OkulEffAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridViewOgrenciler_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciler.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewOgrenciler.SelectedRows[0];
                txtAd.Text = selectedRow.Cells["Ad"].Value.ToString();
                txtSoyad.Text = selectedRow.Cells["Soyad"].Value.ToString();
                comboBoxSinif.SelectedValue = selectedRow.Cells["SinifId"].Value;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new OkulDbContext())
            {
                comboBoxSinif.DataSource = context.Siniflar.ToList();
                comboBoxSinif.DisplayMember = "SinifAdi";
                comboBoxSinif.ValueMember = "SinifId";   

                
                dataGridViewOgrenciler.DataSource = context.Ogrenciler
                    .Include(o => o.Sinif)
                    .Select(o => new
                    {
                        o.OgrenciId,
                        o.Ad,
                        o.Soyad,
                        SinifAdi = o.Sinif.SinifAdi 
                    })
                    .ToList();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Bo� alan kontrol�
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad alanlar� bo� b�rak�lamaz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (comboBoxSinif.SelectedValue == null)
            {
                MessageBox.Show("L�tfen bir s�n�f se�in!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new OkulDbContext())
            {
                // Se�ilen s�n�f�n ID'sini al
                int selectedSinifId = (int)comboBoxSinif.SelectedValue;

                // S�n�f�n mevcut ��renci say�s�n� ve kontenjan�n� kontrol et
                var sinif = context.Siniflar
                    .Include(s => s.Ogrenciler)
                    .FirstOrDefault(s => s.SinifId == selectedSinifId);

                if (sinif != null && sinif.Ogrenciler.Count >= sinif.Kontenjan)
                {
                    MessageBox.Show("Bu s�n�f�n kontenjan� dolu! L�tfen ba�ka bir s�n�f se�in.", "Kontenjan Doldu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                
                var yeniOgrenci = new Ogrenci
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Numara = txtNumara.Text.Trim(),
                    SinifId = selectedSinifId
                };

                context.Ogrenciler.Add(yeniOgrenci);
                context.SaveChanges(); 

                MessageBox.Show("��renci ba�ar�yla kaydedildi!", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                Form1_Load(sender, e);
            }
        }




        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (var context = new OkulDbContext())
            {
              
                int selectedId = (int)dataGridViewOgrenciler.SelectedRows[0].Cells["OgrenciId"].Value;
                var ogrenci = context.Ogrenciler.Find(selectedId);

                if (ogrenci != null)
                {
                    ogrenci.Ad = txtAd.Text;
                    ogrenci.Soyad = txtSoyad.Text;
                    ogrenci.SinifId = (int)comboBoxSinif.SelectedValue;

                    context.SaveChanges(); // G�ncellemeleri kaydet
                    MessageBox.Show("��renci ba�ar�yla g�ncellendi!");
                    Form1_Load(sender, e); // Verileri yenile
                }
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            using (var context = new OkulDbContext())
            {
                
                string ogrenciNumara = txtNumara.Text.Trim();

                if (!string.IsNullOrEmpty(ogrenciNumara)) 
                {
                   
                    var ogrenci = context.Ogrenciler
                        .Include(o => o.Sinif)
                        .FirstOrDefault(o => o.Numara == ogrenciNumara);

                    if (ogrenci != null)
                    {
                    
                        txtAd.Text = ogrenci.Ad;
                        txtSoyad.Text = ogrenci.Soyad;
                        comboBoxSinif.SelectedValue = ogrenci.SinifId;
                    }
                    else
                    {
                        MessageBox.Show("��renci bulunamad�!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Ge�erli bir numara girin!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void btnDersSec_Click(object sender, EventArgs e)
        {
            if (dataGridViewOgrenciler.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewOgrenciler.SelectedRows[0].Cells["OgrenciId"].Value;

                Form2 form2 = new Form2(selectedId);
                form2.SetOgrenci(txtAd.Text, txtSoyad.Text, txtNumara.Text);
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("L�tfen bir ��renci se�in!");
            }
        }

    }


}