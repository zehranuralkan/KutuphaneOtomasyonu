using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSINESSLAYER;
using ENTITYLAYER;

namespace KutuphaneOtomasyonu
{
    public partial class OgrenciIslem : Form
    {
        public OgrenciIslem()
        {
            InitializeComponent();
        }

        Ogrenci ogr = new Ogrenci();
        //Ogrenci sinifindan ogr nesnesi olusturdu
        private void Ekle_btn_Click(object sender, EventArgs e)
        {
            int sonuc = ogr.ogr_ekle(OgrenciID_txt.Text,Isim_txt.Text, Soyisim.Text, Tc_txt.Text, OgrenciNo_txt.Text, Bolum_txt.Text,
                (int.Parse(Sinif_txt.Text)), Telefon_txt.Text, Mail_txt.Text, Adres_txt.Text, KayitTarihi_txt.Text);
            //ogrenci islem formunda kullandıgımız textbox isimlerindeki texti  ogr.ekle() fonksiyonuna gönderir
            MessageBox.Show("Öğrenci Başarıyla Eklendi.");//basari ile eklendiginde ekrana mesaj gelir
           
        }

        

       

        private void geri_btn_Click(object sender, EventArgs e)
        {
            //Geri butonuna tıklandıgında anasayfa sayfasına geri dönmesini sağlar
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void Ogrenci_ara_Click(object sender, EventArgs e)
        {
            List<OgrenciVarlik> ogrenciler = ogr.ogrenci_goster(ogrenciara.Text);
            //entity layer üzerinden ogrenciler adlı nesneyle liste olusturuyor
            //bu liste ogrenci sinifindan olusturdugumuz ogr nesnesiyle ogrenci sinifindan 
            //ogrenci_goster fonksiyonuna ogrenci ara textinin ismini gönderiyor
            kayitlar.DataSource = ogrenciler;
            //kayitlar tablosunda arar
            //
        }

       
        void ogr_gstr()
        {
            //ogrencilerrenciler listesindeki verileri ogr_goster fonkiyonu ile datagridview'e çağırır. 
            List<OgrenciVarlik> ogrenciler = ogr.ogrenci_goster();
            kayitlar.DataSource = ogrenciler;
        }
        private void kayit_btn_Click(object sender, EventArgs e)
        {
            ogr_gstr();//ogr goster fonksiyonuna gider
            MessageBox.Show("Öğrenciler Başarıyla Listelendi.");
        }

        private void ogrenciara_click(object sender, EventArgs e)
        {
            ogrenciara.Text = "";
        }

        private void OgrenciID_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.

            OgrenciID_txt.Text= "";

        }

        private void Isim_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.

            Isim_txt.Text = "";
        }

        private void Soyisim_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            Soyisim.Text = "";
        }

        private void Tc_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            Tc_txt.Text = "";
        }

        private void OgrenciNo_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            OgrenciNo_txt.Text = "";
        }

        private void Bolum_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            Bolum_txt.Text = "";
        }

        private void Sinif_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.

            Sinif_txt.Text = "";
        }

        private void Telefon_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            Telefon_txt.Text = "";
        }

        private void Mail_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            Mail_txt.Text = "";
        }

        private void Adres_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            Adres_txt.Text = "";
        }

        private void KayitTarihi_txt_Click(object sender, EventArgs e)
        {
            //textbox içindeki yazılar silinir.
            KayitTarihi_txt.Text = "";
        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_guncelle fonksiyonu çalıştırılarak öğrenci 
            //güncelleme işlemi yapılır.
            try//Hata olusma ihtimali olan kod blogu
            {
                int sonuc = ogr.ogr_guncelle(int.Parse(OgrenciID_txt.Text), Isim_txt.Text, Soyisim.Text,
                    Tc_txt.Text, OgrenciNo_txt.Text, Bolum_txt.Text, int.Parse(Sinif_txt.Text), Telefon_txt.Text, 
                    Mail_txt.Text, Adres_txt.Text, KayitTarihi_txt.Text);
                //guncelleme isleminde textbox'ların her biri tekrardan kontrol edilerek yani 
                //textbox icerisindeki textler guncelleme fonksiyonuna gonderilerek calisir
                MessageBox.Show("Öğrenci Başarıyla Güncellendi.");
            }
            catch (Exception)//hata olusma ihtimaline karsi
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru girdiğinizden emin olun!");
            }
        }
        Ogrenci sil = new Ogrenci();
        //Ogrenci sinifindan sil nesnesi olusturdu

        private void sil_btn_Click(object sender, EventArgs e)
        {
            //BL'daki ogrenci_islem sınıfındaki ogr_sil fonksiyonu çalıştırılarak öğrenci silme işlemi yapılır.
            try //hata olusma ihtimali olan kodlari barindirir
            {
                sil.ogr_sil(int.Parse(OgrenciID_txt.Text)); 
                //silme islemini ogrenciıd' ye girilen text ile ogr_sil fonksiyonuna yaptirir
                MessageBox.Show("Öğrenci Başarıyla Silindi.");
            }
            catch (Exception)//hata olustugunda bu blok calisir
            {
                MessageBox.Show("Lütfen girilen değerleri kontrol ediniz!");
            }
        }

        private void kayitlar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kayitlar.Rows[e.RowIndex];
                OgrenciID_txt.Text = row.Cells[0].Value.ToString();
                Isim_txt.Text = row.Cells[1].Value.ToString();
                Soyisim.Text = row.Cells[2].Value.ToString();
                Tc_txt.Text = row.Cells[3].Value.ToString();
                OgrenciNo_txt.Text = row.Cells[4].Value.ToString();
                Bolum_txt.Text = row.Cells[5].Value.ToString();
                Sinif_txt.Text = row.Cells[6].Value.ToString();
                Telefon_txt.Text = row.Cells[7].Value.ToString();
                Mail_txt.Text = row.Cells[8].Value.ToString();
                Adres_txt.Text = row.Cells[9].Value.ToString();
                KayitTarihi_txt.Text = row.Cells[10].Value.ToString();


            }
        }

        private void OgrenciIslem_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
