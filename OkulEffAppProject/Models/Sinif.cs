using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulEffAppProject.Models
{
    public class Sinif // internal yerine public olmalı inconsistent accesbility (tutarsız erişim hatası)
    {
        public int SinifId { get; set; }
        public string SinifAdi { get; set; }
        public int Kontenjan { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}

