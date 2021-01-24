using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Ogrenci_islemleri(object sender, EventArgs e)
        {
            OgrenciIslem ogrenci = new OgrenciIslem();//OgrenciIslem'den ogrenci nesnesi türetildi
            ogrenci.Show();//ogrenci formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Kitapislemleri_btn_Click(object sender, EventArgs e)
        {
            KitapIslemleri kitap = new KitapIslemleri();//KitapIslemleri'den kitap nesnesi türetildi
            kitap.Show();//kitap formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Emanetiade_btn_Click(object sender, EventArgs e)
        {
            EmanetIadeIslemleri emanet =new EmanetIadeIslemleri();//EmanetIadeIslemleri'den emanet nesnesi türetildi
            emanet.Show();//emanet formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Kitap_emanet_iade_btn_Click(object sender, EventArgs e)
        {
            Kitap_Emanet_iade_Listesi emanet_iade = new Kitap_Emanet_iade_Listesi();//Kitap_Emanet_iade_Listesi'den emanet_iade nesnesi türetildi
            emanet_iade.Show();//emanet_iade formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
        private void Ogrenci_emanet_iade_btn_Click_1(object sender, EventArgs e)
        {
            Ogrenci_Emanet_Iade_Listesi ogrenci = new Ogrenci_Emanet_Iade_Listesi();//Ogrenci_Emanet_Iade_Listesi'den ogrenci nesnesi türetildi
            ogrenci.Show();//ogrenci formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
       private void Grafik_btn_Click(object sender, EventArgs e)
        {
            KitapGrafik grafik = new KitapGrafik();//KitapGrafik'den grafik nesnesi türetildi
            grafik.Show();//grafik formunu goster
            this.Hide();//işlemlerin arka plandan devam etmesini sağlar
        }
       private void Anasayfa_Load(object sender, EventArgs e)
        {

            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
