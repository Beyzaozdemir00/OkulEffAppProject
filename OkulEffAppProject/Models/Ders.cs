using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulEffAppProject.Models
{
    public class Ders 
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
        public ICollection<OgrenciDers> OgrenciDersler { get; set; }
    }
}
