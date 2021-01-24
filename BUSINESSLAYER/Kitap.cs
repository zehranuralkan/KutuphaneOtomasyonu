using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
using System.Data;
using System.Data.OleDb;



namespace BUSINESSLAYER
{
  public class Kitap
    {


        DATAACCESSLAYER.DataAccessLayer data = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data nesnesi oluşturma 

        public List<KitapVarlik> kitap_goster()
        //Kitap goster fonksiyonunu entity katmanindaki KitapVarlik sınıfından 
        //koleksiyon(liste) şeklinde olusturuyor
        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = data.DRVeriCek("SELECT * FROM Kitap", CommandType.Text);
                if (dr.HasRows)
            //DATAACCESSLAYER'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                //bu değerleri bir liste ile geri döndürüyoruz.
                List<KitapVarlik> kitaplar = new List<KitapVarlik>();
                    while (dr.Read())
                //entity katmanindaki Kitapvarlik uzerinden kitaplar adinda nesne olusturuyor
                //Kitapvarlik'da tanimladigimiz elemanlari türlerine göre stringe donusturme islemi

                {
                    KitapVarlik ktp = new KitapVarlik { KitapID = int.Parse(dr["KitapID"].ToString()),
                        KitapAdi = dr["KitapAdi"].ToString(), YazarAdi = dr["YazarAdi"].ToString(), 
                        YayinEvi = dr["YayinEvi"].ToString(), SayfaSayisi = int.Parse(dr["SayfaSayisi"].ToString()),
                        BaskiYili = int.Parse(dr["BaskiYili"].ToString()), KitapTuru = dr["KitapTuru"].ToString(),
                        StokSayisi = int.Parse(dr["StokSayisi"].ToString()),
                        KitapAciklama = dr["KitapAciklama"].ToString() };

                    kitaplar.Add(ktp);    //Kitaplar koleksiyonuna(listesine) yeni girilen kitap bilgilerini ekler

                }
                return kitaplar;  //koleksiyon icin olusturulan kitaplar nesnesi geri donduruluyor

            }

            return null;
            }
        DATAACCESSLAYER.DataAccessLayer data1 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data1 nesnesi oluşturma 

        public List<KitapVarlik> kitap_goster(string deger, string konum)
        //Kitap goster fonksiyonunu entity katmanindaki KitapVarlik sınıfından 
        //koleksiyon(liste) şeklinde olusturuyor
        //kitapgoster islemi parametre olarak deger ve konum aldigi icin bu islem bu parametrelere baglidir

        {
            //veritabanından kitap tablosundaki değerleri çekiyoruz.
            OleDbDataReader dr = data1.DRVeriCek("SELECT * FROM Kitap WHERE " + konum + " ='" + deger + "'", CommandType.Text);
                if (dr.HasRows)
                {
                    //bu değerleri bir liste ile geri döndürüyoruz.
                    //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
                    List<KitapVarlik> kitaplar = new List<KitapVarlik>();
                    while (dr.Read())
                    {
                    KitapVarlik ktp = new KitapVarlik { KitapID = int.Parse(dr["KitapID"].ToString()),
                        KitapAdi = dr["KitapAdi"].ToString(), YazarAdi = dr["YazarAdi"].ToString(), 
                        YayinEvi = dr["YayinEvi"].ToString(), SayfaSayisi = int.Parse(dr["SayfaSayisi"].ToString()),
                        BaskiYili = int.Parse(dr["BaskiYili"].ToString()), KitapTuru = dr["KitapTuru"].ToString(),
                        StokSayisi = int.Parse(dr["StokSayisi"].ToString()), KitapAciklama = dr["KitapAciklama"].ToString() };
                        kitaplar.Add(ktp);// Kitaplar koleksiyonuna(listesine) yeni girilen kitap bilgilerini ekler

                    }
                return kitaplar;//koleksiyon icin olusturulan kitaplar nesnesi geri donduruluyor

            }

            return null;
            }

        DATAACCESSLAYER.DataAccessLayer data2= new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data2 nesnesi oluşturma 

        public int ktp_ekle(int KitapID,string KitapAdi, string YazarAdi, string YayinEvi, int SayfaSayisi, int BaskiYili,
            string KitapTuru,int StokSayisi, string KitapAciklama)
        //eklenecek olan her veri tabanindaki  alan veri tipleri ile birlikte parametrenin icerisine eklendi

        {
            //kitap eklemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data2.EkleSilGuncelle("insert into Kitap(KitapID,KitapAdi,YazarAdi,YayinEvi,SayfaSayisi,BaskiYili," +
                "KitapTuru,StokSayisi,KitapAciklama) values ('"+ KitapID+"','" + KitapAdi + "','" + YazarAdi + "'," +
                "'" + YayinEvi + "','" + SayfaSayisi + "','" + BaskiYili + "','" + KitapTuru + "','" + StokSayisi + "'," +
                "'" + KitapAciklama + "')", System.Data.CommandType.Text);
            //Veri tabanindaki Kitap tablosuna entityde tanimli alanların eklenmesi islemi

            return sonuc;//sonuc degeri donduruluyor
        }

        DATAACCESSLAYER.DataAccessLayer data3 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data3 nesnesi oluşturma 

        public int ktp_guncelle(int KitapID, string KitapAdi, string YazarAdi, string YayinEvi, int SayfaSayisi,int BaskiYili,
            string KitapTuru,int StokSayisi,string KitapAciklama)
        //guncellenecek olan her veri tabanindaki  alan veri tipleri ile birlikte paremetrenin icerisine eklendi

        {
            //kitap güncellemek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data3.EkleSilGuncelle("update Kitap set KitapAdi='" + KitapAdi + "', YazarAdi='" + YazarAdi + "'," +
                " YayinEvi='" + YayinEvi + "', SayfaSayisi='" + SayfaSayisi + "', BaskiYili='" + BaskiYili + "'," +
                " KitapTuru='" + KitapTuru + "', StokSayisi='" + StokSayisi + "', KitapAciklama='" + KitapAciklama + "' " +
                "WHERE KitapID=" + KitapID + "", System.Data.CommandType.Text);
            //Veri tabanindaki Kitap tablosuna entityde tanimli alanların guncelleme islemi bu islem KitapID'ye göre yapilmaktadir

            return sonuc;//sonuc degeri donduruluyor
        }

        DATAACCESSLAYER.DataAccessLayer data4 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data4 nesnesi oluşturma 

        public int ktp_sil(int KitapID)
            {
            //Silme islemini KitapId gore yapilmaktadir

            //kitap silmek için sorgumuzu fonksiyona değerler ile birlikte gönderiyoruz.
            int sonuc = data4.EkleSilGuncelle("DELETE from Kitap where KitapID =" + KitapID + "", System.Data.CommandType.Text);
                return sonuc;//sonuc degerini donduruyor
        }
        }
    }

