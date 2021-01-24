using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace DATAACCESSLAYER
{
   public class DataAccessLayer
    {
        //access veritabanında sorgu yazmak için bu fonkiyonu kullanıyoruz.
        private OleDbCommand SorguYaz(string Sorgu, CommandType SorguTipi)
        {
            Baglanti baglanti = new Baglanti();
            //Data Access Layer'daki Baglanti.cs'den baglantı adında nesne olusturuldu
            OleDbCommand cmd = baglanti.baglanti.CreateCommand();
            //baglanti ile ilişkili bir cmd nesnesi oluşturur ve döndürür 
            cmd.CommandText = Sorgu;
            //Sorguyu veri kaynağında yürütülecek cmd nesnesine atar
            cmd.CommandType = SorguTipi;
            //commandtype özelliğin nasıl yorumlanacağını gösteren bir değer alır
            return cmd;
        }

        List<OleDbParameter> Parametreler = new List<OleDbParameter>(); 
        //Parametreler veri tabanı listesi oluşturma

        //veritabanına parametre eklemek için bu fonksiyonu kullanıyoruz.
        public void InputParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            OleDbParameter parametre = new OleDbParameter();
            //parametre nesnesi oluşturma
            parametre.ParameterName = ParametreAdi;
            //parametre nesnesinin parametrename'ini ParametreAdi'na
            parametre.Value = ParametreDegeri;
            //parametre nesnesinin value'sini ParametreDegeri'ne
            Parametreler.Add(parametre);
            //parametrelere ekleniyor
        }

        public void OutParametreEkle(string ParametreAdi, object ParametreDegeri)
        {
            OleDbParameter parametre = new OleDbParameter(); //nesne oluşturma
            parametre.ParameterName = ParametreAdi;
            //parametre nesnesinin parametrename'ini ParametreAdi'na
            parametre.Value = ParametreDegeri;
            //parametre nesnesinin value'sini ParametreDegeri'ne
            parametre.Direction = ParameterDirection.Output;
            //parametre nesnesinin direction'nu ParametreDegeri'ne

            Parametreler.Add(parametre);//parametrelere ekleniyor
        }

        //aldığımız parametreleri sorguya eklemek için bu fonksiyonu kullanıyoruz.
        private void ParametreleriSorguyaEkle(OleDbCommand CommandNesnesi)
        {
            CommandNesnesi.Parameters.AddRange(Parametreler.ToArray());
            //Parametreler listesinin/ koleksiyonun öğelerini veri tabanının sonuna ekle
        }

        //parametrenin değerini almak için kullanıyoruz.
        public object ParametreDeğeriniGetir(string ParametreAdi)
        {
            foreach (var item in Parametreler)//Paremetreler kadar döngüye giriyor
            {
                if (item.ParameterName == ParametreAdi)//ParametreAdi item'in ParameterName'ine eşitse
                {
                    return item.Value.ToString(); //item'in value değerini stringe dönüştürüp döndürüyor
                }
            }
            return null;
        }

        //veritabanında ekleme, silme ve güncelleme sorgularını bu fonksiyon ile gerçekleştiriyoruz.
        public int EkleSilGuncelle(string Sorgu, CommandType SorguTipi)
        { 
            try //hata olusma ihtimali olan kod blogu
            {
                OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);//cmd nesnesi olusturma
                ParametreleriSorguyaEkle(cmd); //cmd nesnesi fonksiyona gönderilir
                int sonuc = cmd.ExecuteNonQuery();//cmd yürütür ve etkilenen satır sayısını döndürür.
                if (cmd.Connection.State == ConnectionState.Open)//baglantı acik ise
                {
                    cmd.Connection.Close();//baglantı kapatıldı
                }
                cmd.Connection.Dispose(); 
                //tüm yönetilmeyen kaynakları kaldırarak baglantının tekrar kullanılmasını
                //engelleyerek tamamen temizlenir.
                cmd.Dispose();
                return sonuc;
            }
            catch (Exception) //try'da hata olursa calısır
            {

                throw;
            }


        }

        public object IlkSatirIlkSutun(string Sorgu, CommandType SorguTipi)
        {

            try
            {
                OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi);
                ParametreleriSorguyaEkle(cmd);
                object Sonuc = cmd.ExecuteScalar();
                if (cmd.Connection.State == ConnectionState.Open)
                {
                    cmd.Connection.Close();
                }
                cmd.Connection.Dispose();
                cmd.Dispose();
                return Sonuc;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //veritabanından veri çekme sorgularını bu fonksiyon ile yapıyoruz.
        public OleDbDataReader DRVeriCek(string Sorgu, CommandType SorguTipi)
        {
            OleDbCommand cmd = SorguYaz(Sorgu, SorguTipi); //cmd nesnesi
            ParametreleriSorguyaEkle(cmd);//cmd fonksiyonuna gönderildi
            OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            //cmd nesnesini veritabanı bağlantısını kapatma dr nesnesi olusturur 
            return dr;//dr dondurur
        }

        public DataTable DTVeriCek(string Sorgu, CommandType SorguTipi)
        {
            try //hata olusma ihtimali olan kod blogu
            {
                OleDbDataReader dr = DRVeriCek(Sorgu, SorguTipi); 
                //data reader okuma islemi yapar. dr nesnesi ile
                DataTable dt = new DataTable();
                //data table datareader'ın verilerini dondurur dt nesnesi olusturulmus
                dt.Load(dr); // dt nesnesi  kullanarak bir veri tabanından değerleri doldurur
                return dt;//dt dondurur
            }
            catch (Exception) //try da hata olursa calisir
            {

                throw;
            }
        }

    }
}
