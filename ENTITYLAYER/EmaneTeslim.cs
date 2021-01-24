using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITYLAYER
{
    //diger katmanlardan kolaylıkla erisim saglanabilir
    //veritabanı elemanlarını veritabanına bağlı olmadan nesneler halinde kullanmamızı sağlar.
    //Access veritabanındaki EmanetTeslim tablosundaki sütunların tanımlamalari su sekildedir
    public class EmaneTeslim
    {
        public int KitapID { get; set; }
        public int OgrenciID { get; set; }
        public string EmanetTarihi { get; set; }
        public string IadeTarihi { get; set; }
        public string IadeEdilenTarih { get; set; }
        public string Borc { get; set; }
        public string IslemTuru { get; set; }
        


    }
}
