using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulaması.Veri_Tabanı
{
    public class Calisan:BaseEntity
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string rutbe { get; set; }
        public int departmanId { get; set; }
        public Departman departman { get; set; }

    }
}
