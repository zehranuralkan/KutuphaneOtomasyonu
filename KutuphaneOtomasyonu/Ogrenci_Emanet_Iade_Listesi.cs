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
    public partial class Ogrenci_Emanet_Iade_Listesi : Form
    {
        public Ogrenci_Emanet_Iade_Listesi()
        {
            InitializeComponent();
        }

        Kitap_Alim_İade kitap_iade_alim = new Kitap_Alim_İade();
        public void Emanet_iade_renk()
        {
          
            double ceza;
            for (int i = 0; i < kayit_dg.Rows.Count; i++)
            {

                string islem_turu = kayit_dg.Rows[i].Cells[6].Value.ToString();

                //eğer islem_turu iade'ye eşitse ilgili satırlar yeşil olur.
                if (islem_turu == "iade")
                {
                    kayit_dg.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    kayit_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }

                //almaverme tablosundaki islem_turu iadeye eşit değilse tarihsel işlemler aşağıdaki gibi yapılır.
                if (islem_turu != "iade")
                {
                    string t1, t2; DateTime s1, s2;
                    t1 = DateTime.Now.ToShortDateString();
                    DateTime t3 = DateTime.Parse(kayit_dg.Rows[i].Cells[3].Value.ToString());
                    t2 = t3.ToShortDateString();
                    TimeSpan fark;
                    s1 = DateTime.Parse(t1);
                    s2 = DateTime.Parse(t2);
                    fark = s1.Subtract(s2);


                    //eğer iade tarihine 3 gün veya daha az kaldıysa o kişinin satırı sarı olarak görünür
                    if (Int32.Parse(fark.TotalDays.ToString()) > -3 && Int32.Parse(fark.TotalDays.ToString()) < 1)
                    {
                        kayit_dg.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        kayit_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    //eğer son iade tarihi geçmişse satırın kırmızı görünmesi sağlanır.
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        kayit_dg.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        kayit_dg.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        kayit_dg.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                    if (Int32.Parse(fark.TotalDays.ToString()) > 0)
                    {
                        ceza = int.Parse(fark.TotalDays.ToString()) * 1;
                        kayit_dg.Rows[i].Cells[5].Value = ceza.ToString("c");
                    }
                }
            }
        }
        private void Kayitlar_btn_Click(object sender, EventArgs e)
        {
            //öğrencilerin daha önce yaptığı kitap alım ve iadeleri datagridview üzerinde gösterilir.
            List<EmaneTeslim> kitap_iade = kitap_iade_alim.iade_alim_yukle();
            kayit_dg.DataSource = kitap_iade;
            MessageBox.Show("Kayıt gösterme başarılı!");
            Emanet_iade_renk();
        }

        private void Ogrenci_Numarası_txt_Click(object sender, EventArgs e)
        {
            Ogrenci_Numarası_txt.Text = "";
        }

        private void Ara_btn_Click(object sender, EventArgs e)
        {
            //BL'daki iade_alim_islemleri sınıfından ogrenci_emanet_iade_listele fanksiyonu çalıştırılıp
            //arama textbox içindeki veri tablodan çağırılıp datagridview üzerinden
            //gösterilir.
            List<EmaneTeslim> arama = kitap_iade_alim.ogrenci_emanet_iade_listele(Ogrenci_Numarası_txt.Text);
            //EmaneTeslim den olusturulan arama nesnesi liste olarak  olusturulur
            //kitap_iade_alim  öğrenci numarası parametreli ogrenci_emanet_iade_listele 
            kayit_dg.DataSource = arama;
            MessageBox.Show("Arama Başarılı!");
        }

        private void Geri_btn_Click(object sender, EventArgs e)
        {
            Anasayfa geri = new Anasayfa();
            geri.Show();
            this.Hide();
        }

        private void Ogrenci_Emanet_Iade_Listesi_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
