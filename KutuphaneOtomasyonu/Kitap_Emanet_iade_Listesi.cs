using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITYLAYER;
using BUSINESSLAYER;

namespace KutuphaneOtomasyonu
{
    public partial class Kitap_Emanet_iade_Listesi : Form
    {
        public Kitap_Emanet_iade_Listesi()
        {
            InitializeComponent();
        }
        Kitap_Alim_İade iade_alim = new Kitap_Alim_İade();
        //Kitap_Alim_İade sinifindan iade_alim nesnesi olusturulur
        private void Kitap_Ara_btn_Click(object sender, EventArgs e)
        {
            //arama fonksiyonunda sorgu yapıp dönen liste değerlerini datagridview'e ekliyoruz.
            try //hatali olabilecek kodlar
            {
                string konum = " ";
                konum = kategori_cbx.SelectedItem.ToString();
                //kitap arama kategorisini combobox'dan sectiriyor
                List<EmaneTeslim> kayit_cekme = iade_alim.kayit_listeleme2(kitap_bilgi_txt.Text, konum);
                //EmaneTeslim'den kayit_cekme nesnesini liste olarak olusturur
                //iade_alim nesnesi parametreli kayit listeleme fonksiyonuna textbox ve comboboz'a gönderilen bilgileri gonderir
                Kayit_Listesi_dg.DataSource = kayit_cekme;
                MessageBox.Show("Arama başarılı!");
            }
            //eğer arama bölümü boş veya geçersiz ise hata mesajı veriyoruz.
            catch (Exception)//hata olusursa calisir
            {
                MessageBox.Show("Giriş değerlerini kontrol ediniz!");
            }
        }
        public void Emanet_iade_renk()
        {

        
            double ceza;
            for (int i = 0; i < Kayit_Listesi_dg.Rows.Count; i++)
            {

                string islem_turu = Kayit_Listesi_dg.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islem_turu == "iade")
                {
                    Kayit_Listesi_dg.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    Kayit_Listesi_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(Kayit_Listesi_dg.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);


                    //eğer iade tarihine 3 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        Kayit_Listesi_dg.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        Kayit_Listesi_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        Kayit_Listesi_dg.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        Kayit_Listesi_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        Kayit_Listesi_dg.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        Kayit_Listesi_dg.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }
            }
        }
        private void Kayitlar_btn_Click(object sender, EventArgs e)
        {
            //veritabanından almaverme'deki tüm verileri çekip datagridview'e yazıyoruz.
            List<EmaneTeslim> kitap = iade_alim.iade_alim_yukle();
            Kayit_Listesi_dg.DataSource = kitap;
            MessageBox.Show("Kayıt gösterme Başarılı!");
            Emanet_iade_renk();
        }

        private void Geri_btn_Click(object sender, EventArgs e)
        {
            //anasayfaya dönüş butonu.
            Anasayfa syf = new Anasayfa();
            syf.Show();
            this.Hide();
        }

        private void Kitap_Emanet_iade_Listesi_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
