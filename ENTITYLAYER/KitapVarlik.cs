using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    //diger katmanlardan kolaylıkla erisim saglanabilir
    //veritabanı elemanlarını veritabanına bağlı olmadan nesneler halinde kullanmamızı sağlar.
    //Access veritabanındaki Kitap tablosundaki sütunların tanımlamalari su sekildedir
    public class KitapVarlik
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public string YazarAdi { get; set; }
        public string YayinEvi { get; set; }

        public int SayfaSayisi { get; set; }
        public int BaskiYili { get; set; }

        public string KitapTuru { get; set; }
        public int StokSayisi { get; set; }
        public string KitapAciklama { get; set; }
    }
}
