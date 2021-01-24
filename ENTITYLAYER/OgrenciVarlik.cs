using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    //diger katmanlardan kolaylıkla erisim saglanabilir
    //veritabanı elemanlarını veritabanına bağlı olmadan nesneler halinde kullanmamızı sağlar.
    public class OgrenciVarlik
    {

        //Access veritabanındaki öğrenciler tablosundaki sütunların tanımlamalari su sekildedir
        public int OgrenciID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
        public string TC { get; set; }
        public string OgrenciNo { get; set; }
        public string Bolum { get; set; }
        public int Sinif { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string KayitTarihi { get; set; }
        
    }
}
