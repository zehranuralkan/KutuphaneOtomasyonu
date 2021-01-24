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
    public partial class KitapIslemleri : Form
    {
        public KitapIslemleri()
        {
            InitializeComponent();
        }

        string konum = " ";

        Kitap kitapl = new Kitap();
        //kitap sinifindan kitap1 nesnesi olusturdum
         private void ekle_btn_Click(object sender, EventArgs e)
        {

            //BL'daki kitap_islem sınıfındaki ktp_ekle fonksiyonu çaılştırılarak kitap ekleme işlemi yapılır.
            int sonuc = kitapl.ktp_ekle(int.Parse(kitapıd_txt.Text),kitapadi_txt.Text, yazaradi_txt.Text, 
                yayinevi_txt.Text, int.Parse(sayfasayisi_txt.Text), int.Parse(baskiyili_txt.Text), 
                kitapturu_txt.Text, int.Parse(stoksayisi_txt.Text), kitapaciklama_txt.Text);
            //textboc'lar içerisine girilen text degerlerini ktp_ekle fonksiyonuna gönderir
            MessageBox.Show("Kitap Başarıyla Eklendi.");
        }
        void veri_cek()
        {
            //kitaplar listesinden sütun bilgilerini çekip datagridview'e aktarır.
            List<KitapVarlik> ktp = kitapislem.kitap_goster();
            //Kitapvarlikdan türetilen ktp nesnesi liste seklinde kitap gosterir
            kitap_dgrid.DataSource = ktp;
        }
        Kitap kitapislem = new Kitap();
        //Kitap sinifindan kitapislem nesnesi olsturma islemi
        private void kayitlikitaplar_btn_Click(object sender, EventArgs e)
        {
            //veri_cek fonksiyonu ile tüm kitap bilgileri datagridview'e aktarılır.
            veri_cek();//fonksiyona gider
            MessageBox.Show("Tüm kayıtlar listelendi");
        }


        Kitap guncelleme = new Kitap();
        //Kitap sinifindan guncelleme nesnesi olustudum
        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_guncelle fonksiyonu çalıştırılarak kitap güncellleme işlemi yapılır.
            try//hata olusabilecek kod blokları
            {
                int Sonuc = guncelleme.ktp_guncelle(int.Parse(kitapıd_txt.Text), kitapadi_txt.Text, yazaradi_txt.Text,
                    yayinevi_txt.Text, int.Parse(sayfasayisi_txt.Text), int.Parse(baskiyili_txt.Text),
                    kitapturu_txt.Text, int.Parse(stoksayisi_txt.Text), kitapaciklama_txt.Text);
                //guncelleme islemi icin textboxlar icine girilen textleri kitap_guncelle 
                //fonksiyonuna guncelleme nesnesine gonderir
                MessageBox.Show("Kitap başarıyla güncellendi");
            }
            catch (Exception)//eger hata olusursa bu kodlar calisir
            {
                MessageBox.Show("Lütfen güncelleme bilgilerini doğru giriniz!");
            }


        }

        Kitap sil = new Kitap();
        //Kitap sinifindan sil nesnesi türetme islemi
        private void sil_btn_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfındaki ktp_sil fonksiyonu çalıştırılarak kitap silme işlemi yapılır.
            try//hata olusma ihtimali olan kof bloklari
            {
                int Sonuc = sil.ktp_sil(int.Parse(kitapıd_txt.Text));
                //silme islemini kitapıd girilen textbox içerisindeki degeri int degerine donusturerek
                //ktp_sil fonksiyonuna gönderiyorum
                MessageBox.Show("Kitap başarıyla silindi");
            }
            catch (Exception)//Herhangi bir hatada bu blok calisir
            {
                MessageBox.Show("Lütfen alanları doldurduğunuzdan veya doğru olduğundan emin olunuz!");
            }
        }


        private void kitap_dgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //datagridview'de tıklanan satırın bilgileri textbox'a aktarılır.
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = kitap_dgrid.Rows[e.RowIndex];
                kitapıd_txt.Text = row.Cells[0].Value.ToString();
                kitapadi_txt.Text = row.Cells[1].Value.ToString();
                yazaradi_txt.Text = row.Cells[2].Value.ToString();
                yayinevi_txt.Text = row.Cells[3].Value.ToString();
                sayfasayisi_txt.Text = row.Cells[4].Value.ToString();
                baskiyili_txt.Text = row.Cells[5].Value.ToString();
                kitapturu_txt.Text = row.Cells[6].Value.ToString();
                stoksayisi_txt.Text = row.Cells[7].Value.ToString();
                kitapaciklama_txt.Text = row.Cells[8].Value.ToString();
            }
        }


        private void kitap_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //konum değeri textbox içersindeki seçilen değere eşitlenir.
            konum = kitap_cmb.SelectedItem.ToString();
          
        }
        private void kitap_txt_TextChanged(object sender, EventArgs e)
        {
            kitap_txt.Text = "";//üzerine tiklandiginda textbox icindeki yazi silinir
        }
         private void ara_btn_Click(object sender, EventArgs e)
        {
            //BL'daki kitap_islem sınıfından kitap_goster fonksiyonu çalıştırılarak kitap bilgileri
            //datagridview'e aktarılır.
            try//hata olusabilcek kod blogu
            {
                List<KitapVarlik> ktp2 = kitapislem.kitap_goster(kitap_txt.Text, konum);
                //entity'deki kitapvarlik üzerinden ktp2 nesneli liste olusturuyorum
                //combobox'da seçtiğim konumu ve ara textbox'ı içine yazdıgımız text kitap goster parametreli fonksiyonuna gonderir
                kitap_dgrid.DataSource = ktp2;
                MessageBox.Show("Arama sonuçları listelendi");
            }
            catch (Exception)//hata durumunda bu kodlar calisir
            {
                MessageBox.Show("Lütfen Alanları Doldurunuz!");
            }
        }

        private void Geri_btn_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            Anasayfa anasayfa = new Anasayfa();
            anasayfa.Show();
            this.Hide();
        }


       
       
     


      

       

       
        private void kitapıd_txt_Click(object sender, EventArgs e)
        {
            kitapıd_txt.Text = "";
        }

        private void kitapadi_txt_Click(object sender, EventArgs e)
        {
            kitapadi_txt.Text = "";
        }

        private void yazaradi_txt_Click(object sender, EventArgs e)
        {
            yazaradi_txt.Text = "";
        }

        private void yayinevi_txt_Click(object sender, EventArgs e)
        {
            yayinevi_txt.Text = "";
        }

        private void sayfasayisi_txt_Click(object sender, EventArgs e)
        {
            sayfasayisi_txt.Text = "";
        }

        private void baskiyili_txt_Click(object sender, EventArgs e)
        {
            baskiyili_txt.Text = "";

        }

        private void kitapturu_txt_Click(object sender, EventArgs e)
        {
            kitapturu_txt.Text = "";
        }

        private void stoksayisi_txt_Click(object sender, EventArgs e)
        {
            stoksayisi_txt.Text = "";
        }

        private void kitapaciklama_txt_Click(object sender, EventArgs e)
        {
            kitapaciklama_txt.Text = "";
        }

        private void KitapIslemleri_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
