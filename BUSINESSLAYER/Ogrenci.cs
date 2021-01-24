using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAACCESSLAYER;
using ENTITYLAYER;
using System.Data;
using System.Data.OleDb;

namespace BUSINESSLAYER
{
    public class Ogrenci
    {
        DATAACCESSLAYER.DataAccessLayer data = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data nesnesi oluşturma 
        public List<OgrenciVarlik> ogrenci_goster() 
            //ogrenci goster fonksiyonunu entity katmanindaki OgrenciVarlik sınıfından 
            //koleksiyon(liste) şeklinde olusturuyor
        {
          
            OleDbDataReader dr = data.DRVeriCek("SELECT * FROM Ogrenci", CommandType.Text);
            //veritabanından Ogrenci tablosundaki değerleri çekiyoruz.
            if (dr.HasRows)
            //DATAACCESSLAYER'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<OgrenciVarlik> ogrenciler = new List<OgrenciVarlik>();
                while (dr.Read())
                {
                    //entity katmanindaki Ogrencivarlik uzerinden ogrenci adinda nesne olusturuyor
                    //Ogrencvarlik'da tanimladigimiz elemanlari türlerine göre stringe donusturme islemi
                    OgrenciVarlik ogrenci = new OgrenciVarlik { OgrenciID = int.Parse(dr["OgrenciID"].ToString()), 
                        Isim = dr["Isim"].ToString(), Soyisim = dr["Soyisim"].ToString(), 
                        TC = dr["TC"].ToString(), OgrenciNo = dr["OgrenciNo"].ToString(), 
                        Bolum = dr["Bolum"].ToString(), Sinif = int.Parse(dr["Sinif"].ToString()),
                        Telefon = dr["Telefon"].ToString(), Mail = dr["Mail"].ToString(),
                        Adres = dr["Adres"].ToString(), KayitTarihi = dr["KayitTarihi"].ToString() };
                    ogrenciler.Add(ogrenci);//Ogrenciler koleksiyonuna(listesine) yeni girilen ogrenci bilgilerini ekler
                }
                return ogrenciler; //koleksiyon icin olusturulan ogrenciler nesnesi geri donduruluyor
            }

            return null;
        }

        DATAACCESSLAYER.DataAccessLayer data1 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data1 nesnesi oluşturma 
        public List<OgrenciVarlik> ogrenci_goster(string OgrenciNo)
        //ogrenci goster fonksiyonunu entity katmanindaki OgrenciVarlik sınıfından 
        //koleksiyon(liste) şeklinde olusturuyor
        {
            OleDbDataReader dr = data1.DRVeriCek("SELECT * FROM Ogrenci WHERE OgrenciNo='" + OgrenciNo + "'", CommandType.Text);
            //veritabanından ogrenci tablosundaki değerleri çekiyoruz.
            if (dr.HasRows)
            //DATAACCESSLAYER'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise
            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                List<OgrenciVarlik> ogrenciler = new List<OgrenciVarlik>();
                while (dr.Read())
                {
                   //entity katmanindaki Ogrencivarlik uzerinden ogrenci adinda nesne olusturuyor
                    //Ogrencvarlik'da tanimladigimiz elemanlari türlerine göre stringe donusturme islemi
                    OgrenciVarlik ogrenci = new OgrenciVarlik { OgrenciID = int.Parse(dr["OgrenciID"].ToString()), 
                        Isim = dr["Isim"].ToString(), Soyisim = dr["Soyisim"].ToString(), TC = dr["TC"].ToString(),
                        OgrenciNo = dr["OgrenciNo"].ToString(), Bolum = dr["Bolum"].ToString(),
                        Sinif = int.Parse(dr["Sinif"].ToString()), Telefon = dr["Telefon"].ToString(),
                        Mail = dr["Mail"].ToString(), Adres = dr["Adres"].ToString(),
                        KayitTarihi = dr["KayitTarihi"].ToString() };
                    ogrenciler.Add(ogrenci); 
                    //Ogrenciler koleksiyonuna(listesine) yeni girilen ogrenci bilgilerini ekler
                }
                return ogrenciler;//koleksiyon icin olusturulan ogrenciler nesnesi geri donduruluyor
            }
         return null;
        }


        DATAACCESSLAYER.DataAccessLayer data2 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data2 nesnesi oluşturma 
        public int ogr_ekle(string OgrenciID,  string Isim, string Soyisim, string TC,string OgrenciNo,string Bolum,int Sinif,string Telefon,
            string Mail,string Adres,string KayitTarihi)
            //eklenecek olan her veri tabanindaki  alan veri tipleri ile birlikte paremetrenin icerisine eklendi
        {
            //öğrenci eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data2.EkleSilGuncelle("INSERT into Ogrenci (OgrenciID,Isim,Soyisim,TC,OgrenciNo,Bolum,Sinif,Telefon,Mail,Adres,KayitTarihi)" +
                " VALUES ('"+ OgrenciID+"','" + Isim + "','" + Soyisim + "','" + TC + "','"+ OgrenciNo+"','"+ Bolum+"','"+ Sinif+"','"+ Telefon+"'," +
                "'"+ Mail+"','"+ Adres+"','"+ KayitTarihi+"')", System.Data.CommandType.Text);
            //Veri tabanindaki Ogrenci tablosuna entityde tanimli alanların eklenmesi islemi
            return sonuc;//sonuc degeri donduruluyor
        }


        DATAACCESSLAYER.DataAccessLayer data3 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data3 nesnesi oluşturma 
        public int ogr_guncelle(int OgrenciID, string Isim, string Soyisim, string TC, string OgrenciNo, string Bolum, int Sinif, string Telefon,
            string Mail, string Adres, string KayitTarihi)
        //eklenecek olan her veri tabanindaki  alan veri tipleri ile birlikte paremetrenin icerisine eklendi

        {
            //öğrenci güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data3.EkleSilGuncelle("UPDATE Ogrenci SET Isim='" + Isim + "', Soyisim='" + Soyisim + "', TC='" + TC + "'," +
                "OgrenciNo='"+ OgrenciNo+ "',Bolum='"+ Bolum+ "',Sinif='"+ Sinif+ "',Telefon='"+ Telefon+ "',Mail='"+ Mail+ "',Adres='"+ Adres+ "'" +
                ",KayitTarihi='"+ KayitTarihi+"' WHERE OgrenciID=" + OgrenciID + "", System.Data.CommandType.Text);
            //Veri tabanindaki Ogrenci tablosuna entityde tanimli alanların guncelleme islemi

            return sonuc;//sonuc degeri donduruluyor
        }

        DATAACCESSLAYER.DataAccessLayer data4 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data4 nesnesi oluşturma 
        public int ogr_sil(int OgrenciID)
            //Silme islemini ogrenciId gore yapilmaktadir
        {
            //öğrenciyi silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data4.EkleSilGuncelle("DELETE from Ogrenci where OgrenciID =" + OgrenciID + "", System.Data.CommandType.Text);
            return sonuc;//sonuc degerini donduruyor
        }

    }
}
