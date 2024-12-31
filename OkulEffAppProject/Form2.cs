using OkulEffAppProject.Models;
using System.Data;

namespace OkulEffAppProject
{
    public partial class Form2 : Form
    {
        private int selectedOgrenciId;

        public Form2(int ogrenciId)
        {
            InitializeComponent();
            selectedOgrenciId = ogrenciId;
        }

        public void SetOgrenci(string ogrenciAd, string ogrenciSoyad, string ogrenciNumara)
        {
            lblOgrenciBilgileri.Text = $"Ad: {ogrenciAd} Soyad: {ogrenciSoyad} Numara: {ogrenciNumara}";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (var context = new OkulDbContext())
            {
                var dersListesi = context.Dersler
                    .Select(d => new
                    {
                        d.DersId,
                        d.DersAdi
                    })
                    .ToList();

                dataGridViewDersler.DataSource = dersListesi;

                if (!dataGridViewDersler.Columns.Contains("DersSec"))
                {
                    DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn
                    {
                        Name = "DersSec",
                        HeaderText = "Seç",
                        FalseValue = false,
                        TrueValue = true,
                        ReadOnly = false
                    };
                    dataGridViewDersler.Columns.Add(checkboxColumn);
                }

                dataGridViewDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridViewDersler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewDersler.AllowUserToAddRows = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var seciliDersler = new List<int>();

            foreach (DataGridViewRow row in dataGridViewDersler.Rows)
            {
                var isSelected = row.Cells["DersSec"].Value != null && (bool)row.Cells["DersSec"].Value;
                if (isSelected)
                {
                    int dersId = Convert.ToInt32(row.Cells["DersId"].Value);
                    seciliDersler.Add(dersId);
                }
            }

            if (seciliDersler.Count == 0)
            {
                MessageBox.Show("Lütfen en az bir ders seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new OkulDbContext())
            {
                foreach (var dersId in seciliDersler)
                {
                    var ogrenciDers = new OgrenciDers
                    {
                        OgrenciId = selectedOgrenciId,
                        DersId = dersId
                    };

                    context.OgrenciDersler.Add(ogrenciDers);
                }

                int result = context.SaveChanges();
                if (result > 0)
                {
                    MessageBox.Show("Dersler başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ders kaydı sırasında bir sorun oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

