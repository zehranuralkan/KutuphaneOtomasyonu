using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATAACCESSLAYER;
using System.Data;
using System.Data.OleDb;
using ENTITYLAYER;

namespace BUSINESSLAYER
{
    public class Kitap_Alim_İade
    {
        DATAACCESSLAYER.DataAccessLayer data = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data nesnesi oluşturma 

        public List<EmaneTeslim> iade_alim_yukle()
        {
            //iade alim yukle fonksiyonunu entity katmanindaki EmaneTeslim sınıfından 
            //koleksiyon(liste) şeklinde olusturuyor

            OleDbDataReader dr = data.DRVeriCek("Select * from EmaneTeslim", CommandType.Text); 
            //DAL katmanı yardımıyla almaverme tablosundaki verilerimizi çekiyoruz.
            if (dr.HasRows)//DATAACCESSLAYER'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                List<EmaneTeslim> islem_kayit = new List<EmaneTeslim>();//bu değerleri bir liste ile geri döndürüyoruz.

                while (dr.Read())
                {
                    //tablodaki verileri çekip yukle listesine ekliyoruz. 
                    EmaneTeslim yukle = new EmaneTeslim { KitapID = int.Parse(dr["KitapID"].ToString()), 
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()), EmanetTarihi = dr["EmanetTarihi"].ToString(),
                        IadeTarihi = dr["IadeTarihi"].ToString(), IadeEdilenTarih = dr["IadeEdilenTarih"].ToString(), 
                        Borc = dr["Borc"].ToString(), IslemTuru = dr["IslemTuru"].ToString() };

                    islem_kayit.Add(yukle);//islem_kayit koleksiyonuna(listesine) yeni girilen emanet bilgilerini ekler

                }
                return islem_kayit; //listeyi geri yolluyoruz.
            }

            return null;
        }

        DATAACCESSLAYER.DataAccessLayer data1 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data1 nesnesi oluşturma 

        public int tablo_iade_duzenleme(int KitapID, int OgrenciID, string IslemTuru)
        {
            //almaverme tablosundaki verileri güncellemek için sorgumuzu OgrenciID ve KitapID'ye  gore gönderiyoruz.
            int Sonuc = data1.EkleSilGuncelle("update EmaneTeslim set IslemTuru='" + IslemTuru + "' " +
                "where OgrenciID=" + OgrenciID + " and KitapID = " + KitapID + "", System.Data.CommandType.Text);

            return Sonuc;//sonuc degerini donduruyor
        }


        public List<EmaneTeslim> kayit_listeleme1(int OgrenciNo)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = data1.DRVeriCek("Select * from EmaneTeslim where OgrenciID in " +
                "(select OgrenciID from Ogrenci where OgrenciNo ='" + OgrenciNo + "') ", CommandType.Text);

            if (dr.HasRows)//DATAACCESSLAYER'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EmaneTeslim> islem_kayit = new List<EmaneTeslim>();
                while (dr.Read())//tablodaki verileri çekip yukle listesine ekliyoruz. 

                {



                    EmaneTeslim kaydet = new EmaneTeslim { KitapID = int.Parse(dr["KitapID"].ToString()), 
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()), EmanetTarihi = dr["EmanetTarihi"].ToString(),
                        IadeTarihi = dr["IadeTarihi"].ToString(), IadeEdilenTarih = dr["IadeEdilenTarih"].ToString(),
                        Borc = dr["Borc"].ToString(), IslemTuru = dr["IslemTuru"].ToString() };
                    //tablodaki verileri çekip yukle listesine ekliyoruz. 

                    islem_kayit.Add(kaydet); //islem_kayit koleksiyonuna(listesine) yeni girilen emanet bilgilerini kaydeder
                }
                return islem_kayit;//listeyi geri yolluyoruz.
            }

            return null;
        }

        DATAACCESSLAYER.DataAccessLayer data2 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data2 nesnesi oluşturma 

        public int emanet_islemi(int KitapID, int OgrenciID, DateTime EmanetTarihi, DateTime IadeTarihi, string IslemTuru)
        //eklenecek olan her veri tabanindaki  alan veri tipleri ile birlikte parametrenin icerisine eklendi

        {

            //emanet vermek için almaverme tablosuna gerekli verileri yolluyoruz.
            int Sonuc = data2.EkleSilGuncelle("insert into EmaneTeslim (KitapID,OgrenciID,EmanetTarihi,IadeTarihi,IslemTuru) " +
                "values (" + KitapID + "," + OgrenciID + ",'" + EmanetTarihi + "','" + IadeTarihi + "','" + IslemTuru + "')",
                System.Data.CommandType.Text);
            return Sonuc;//sonuc degerini dondurur
        }



        DATAACCESSLAYER.DataAccessLayer data3 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data3 nesnesi oluşturma 

        public List<EmaneTeslim> ogrenci_emanet_iade_listele(string deger)
        {
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            OleDbDataReader dr = data3.DRVeriCek("Select * from EmaneTeslim where OgrenciID in" +
                " (Select OgrenciID from Ogrenci where OgrenciNo='" + deger + "')", CommandType.Text);
            //Verileri EmaneTeslim ve Ogrenci tablosundan cekiyor
            if (dr.HasRows) //DATAACCESSLAYER'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EmaneTeslim> islem_kayit = new List<EmaneTeslim>();
                while (dr.Read())//tablodaki verileri çekip yukle listesine ekliyoruz. 

                {
                    EmaneTeslim kayit_etme = new EmaneTeslim { KitapID = int.Parse(dr["KitapID"].ToString()), 
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()), EmanetTarihi = dr["EmanetTarihi"].ToString(), 
                        IadeTarihi = dr["IadeTarihi"].ToString(), IadeEdilenTarih = dr["IadeEdilenTarih"].ToString(),
                        Borc = dr["Borc"].ToString(), IslemTuru = dr["IslemTuru"].ToString() };

                    islem_kayit.Add(kayit_etme); //islem_kayit koleksiyonuna(listesine) yeni girilen emanet bilgilerini kaydeder
                
            }
                return islem_kayit; //islem_kayit degerini donduruyor
            }

            return null;
        }


        DATAACCESSLAYER.DataAccessLayer data4 = new DATAACCESSLAYER.DataAccessLayer();
        //DATAACCESSLAYER katmanindaki DataAccessLayer sinifindan data4 nesnesi oluşturma 

        public List<EmaneTeslim> kayit_listeleme2(string deger, string konum)
        {
            //listelemeyi değer ve konum parametrelerine gore yapıyoruz
            //listelemek istediğimiz verileri veritabanından çekiyoruz.
            //bu sefer çekmek istediğimiz sütunu da sorguya gönderiyoruz. 
            OleDbDataReader dr = data4.DRVeriCek("Select * from EmaneTeslim where KitapID in (Select KitapID from Kitap where "
                + konum + " ='" + deger + "')", CommandType.Text);
            if (dr.HasRows)//DATAACCESSLAYER'DA DataTableReader'ın satır içerip içermediğini gösteren bir değer ise

            {
                //veritabanından çektiğimiz verileri liste olarak geri gönderiyoruz.
                List<EmaneTeslim> islem_kayit = new List<EmaneTeslim>();
                while (dr.Read())//tablodaki verileri çekip yukle listesine ekliyoruz. 

                {
                    EmaneTeslim kayit_etme = new EmaneTeslim { KitapID = int.Parse(dr["KitapID"].ToString()),
                        OgrenciID = int.Parse(dr["OgrenciID"].ToString()), EmanetTarihi = dr["EmanetTarihi"].ToString(),
                        IadeTarihi = dr["IadeTarihi"].ToString(), IadeEdilenTarih = dr["IadeEdilenTarih"].ToString(),
                        Borc = dr["Borc"].ToString(), IslemTuru = dr["IslemTuru"].ToString() };

                    islem_kayit.Add(kayit_etme);//islem_kayit koleksiyonuna(listesine) yeni girilen emanet bilgilerini kaydeder

                }
                return islem_kayit; //islem_kayit degerini donduruyor
            }

            return null;
        }


    }
}
