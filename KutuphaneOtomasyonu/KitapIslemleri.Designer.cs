namespace KutuphaneOtomasyonu
{
    partial class KitapIslemleri
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapIslemleri));
            this.Geri_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kitapara_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kitap_cmb = new System.Windows.Forms.ComboBox();
            this.kitap_txt = new System.Windows.Forms.TextBox();
            this.ara_btn = new System.Windows.Forms.Button();
            this.ogrencibilgileri_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KitapID_txt = new System.Windows.Forms.Label();
            this.KitapAdi_lbl = new System.Windows.Forms.Label();
            this.YazarAdi_lbl = new System.Windows.Forms.Label();
            this.YayinEvi_lbl = new System.Windows.Forms.Label();
            this.SayfaSayisi_lbl = new System.Windows.Forms.Label();
            this.BaskiYili_lbl = new System.Windows.Forms.Label();
            this.KitapTuru_lbl = new System.Windows.Forms.Label();
            this.StokSayisi_lbl = new System.Windows.Forms.Label();
            this.KitapAciklama_lbl = new System.Windows.Forms.Label();
            this.kitapıd_txt = new System.Windows.Forms.TextBox();
            this.kitapadi_txt = new System.Windows.Forms.TextBox();
            this.yazaradi_txt = new System.Windows.Forms.TextBox();
            this.yayinevi_txt = new System.Windows.Forms.TextBox();
            this.sayfasayisi_txt = new System.Windows.Forms.TextBox();
            this.baskiyili_txt = new System.Windows.Forms.TextBox();
            this.kitapturu_txt = new System.Windows.Forms.TextBox();
            this.stoksayisi_txt = new System.Windows.Forms.TextBox();
            this.kitapaciklama_txt = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.kitap_dgrid = new System.Windows.Forms.DataGridView();
            this.kayitlikitaplar_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_dgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Geri_btn
            // 
            this.Geri_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geri_btn.Location = new System.Drawing.Point(22, 777);
            this.Geri_btn.Name = "Geri_btn";
            this.Geri_btn.Size = new System.Drawing.Size(127, 47);
            this.Geri_btn.TabIndex = 0;
            this.Geri_btn.Text = "GERİ";
            this.Geri_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Geri_btn.UseVisualStyleBackColor = true;
            this.Geri_btn.Click += new System.EventHandler(this.Geri_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(22, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 166);
            this.panel1.TabIndex = 1;
            // 
            // kitapara_lbl
            // 
            this.kitapara_lbl.AutoSize = true;
            this.kitapara_lbl.BackColor = System.Drawing.Color.Turquoise;
            this.kitapara_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitapara_lbl.Location = new System.Drawing.Point(245, 48);
            this.kitapara_lbl.Name = "kitapara_lbl";
            this.kitapara_lbl.Size = new System.Drawing.Size(170, 32);
            this.kitapara_lbl.TabIndex = 2;
            this.kitapara_lbl.Text = "KİTAP ARA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(240, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Aramayı şu kritere göre yapınız...";
            // 
            // kitap_cmb
            // 
            this.kitap_cmb.FormattingEnabled = true;
            this.kitap_cmb.Items.AddRange(new object[] {
            "YazarAdi",
            "KitapAdi",
            "KitapTuru",
            "KitapID",
            "YayinEvi"});
            this.kitap_cmb.Location = new System.Drawing.Point(244, 153);
            this.kitap_cmb.Name = "kitap_cmb";
            this.kitap_cmb.Size = new System.Drawing.Size(255, 24);
            this.kitap_cmb.TabIndex = 4;
            this.kitap_cmb.Text = "Seçiniz.";
            this.kitap_cmb.SelectedIndexChanged += new System.EventHandler(this.kitap_cmb_SelectedIndexChanged);
            // 
            // kitap_txt
            // 
            this.kitap_txt.Location = new System.Drawing.Point(245, 193);
            this.kitap_txt.Name = "kitap_txt";
            this.kitap_txt.Size = new System.Drawing.Size(253, 22);
            this.kitap_txt.TabIndex = 5;
            this.kitap_txt.Text = "Kitap Bilgisi";
            this.kitap_txt.Click += new System.EventHandler(this.kitap_txt_TextChanged);
            // 
            // ara_btn
            // 
            this.ara_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ara_btn.Location = new System.Drawing.Point(559, 180);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(111, 35);
            this.ara_btn.TabIndex = 6;
            this.ara_btn.Text = "ARA";
            this.ara_btn.UseVisualStyleBackColor = true;
            this.ara_btn.Click += new System.EventHandler(this.ara_btn_Click);
            // 
            // ogrencibilgileri_lbl
            // 
            this.ogrencibilgileri_lbl.AutoSize = true;
            this.ogrencibilgileri_lbl.BackColor = System.Drawing.Color.Turquoise;
            this.ogrencibilgileri_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencibilgileri_lbl.Location = new System.Drawing.Point(30, 273);
            this.ogrencibilgileri_lbl.Name = "ogrencibilgileri_lbl";
            this.ogrencibilgileri_lbl.Size = new System.Drawing.Size(302, 32);
            this.ogrencibilgileri_lbl.TabIndex = 7;
            this.ogrencibilgileri_lbl.Text = "ÖĞRENCİ BİLGİLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // KitapID_txt
            // 
            this.KitapID_txt.AutoSize = true;
            this.KitapID_txt.Location = new System.Drawing.Point(47, 343);
            this.KitapID_txt.Name = "KitapID_txt";
            this.KitapID_txt.Size = new System.Drawing.Size(61, 17);
            this.KitapID_txt.TabIndex = 9;
            this.KitapID_txt.Text = "Kitap ID:";
            // 
            // KitapAdi_lbl
            // 
            this.KitapAdi_lbl.AutoSize = true;
            this.KitapAdi_lbl.Location = new System.Drawing.Point(45, 374);
            this.KitapAdi_lbl.Name = "KitapAdi_lbl";
            this.KitapAdi_lbl.Size = new System.Drawing.Size(68, 17);
            this.KitapAdi_lbl.TabIndex = 10;
            this.KitapAdi_lbl.Text = "Kitap Adı:";
            // 
            // YazarAdi_lbl
            // 
            this.YazarAdi_lbl.AutoSize = true;
            this.YazarAdi_lbl.Location = new System.Drawing.Point(45, 401);
            this.YazarAdi_lbl.Name = "YazarAdi_lbl";
            this.YazarAdi_lbl.Size = new System.Drawing.Size(73, 17);
            this.YazarAdi_lbl.TabIndex = 11;
            this.YazarAdi_lbl.Text = "Yazar Adı:";
            // 
            // YayinEvi_lbl
            // 
            this.YayinEvi_lbl.AutoSize = true;
            this.YayinEvi_lbl.Location = new System.Drawing.Point(47, 434);
            this.YayinEvi_lbl.Name = "YayinEvi_lbl";
            this.YayinEvi_lbl.Size = new System.Drawing.Size(66, 17);
            this.YayinEvi_lbl.TabIndex = 12;
            this.YayinEvi_lbl.Text = "YayinEvi:";
            // 
            // SayfaSayisi_lbl
            // 
            this.SayfaSayisi_lbl.AutoSize = true;
            this.SayfaSayisi_lbl.Location = new System.Drawing.Point(47, 463);
            this.SayfaSayisi_lbl.Name = "SayfaSayisi_lbl";
            this.SayfaSayisi_lbl.Size = new System.Drawing.Size(89, 17);
            this.SayfaSayisi_lbl.TabIndex = 13;
            this.SayfaSayisi_lbl.Text = "Sayfa Sayısı:";
            // 
            // BaskiYili_lbl
            // 
            this.BaskiYili_lbl.AutoSize = true;
            this.BaskiYili_lbl.Location = new System.Drawing.Point(45, 491);
            this.BaskiYili_lbl.Name = "BaskiYili_lbl";
            this.BaskiYili_lbl.Size = new System.Drawing.Size(68, 17);
            this.BaskiYili_lbl.TabIndex = 14;
            this.BaskiYili_lbl.Text = "Baskı Yılı:";
            // 
            // KitapTuru_lbl
            // 
            this.KitapTuru_lbl.AutoSize = true;
            this.KitapTuru_lbl.Location = new System.Drawing.Point(45, 518);
            this.KitapTuru_lbl.Name = "KitapTuru_lbl";
            this.KitapTuru_lbl.Size = new System.Drawing.Size(78, 17);
            this.KitapTuru_lbl.TabIndex = 15;
            this.KitapTuru_lbl.Text = "Kitap Türü:";
            // 
            // StokSayisi_lbl
            // 
            this.StokSayisi_lbl.AutoSize = true;
            this.StokSayisi_lbl.Location = new System.Drawing.Point(47, 546);
            this.StokSayisi_lbl.Name = "StokSayisi_lbl";
            this.StokSayisi_lbl.Size = new System.Drawing.Size(81, 17);
            this.StokSayisi_lbl.TabIndex = 16;
            this.StokSayisi_lbl.Text = "Stok Sayısı:";
            // 
            // KitapAciklama_lbl
            // 
            this.KitapAciklama_lbl.AutoSize = true;
            this.KitapAciklama_lbl.Location = new System.Drawing.Point(47, 575);
            this.KitapAciklama_lbl.Name = "KitapAciklama_lbl";
            this.KitapAciklama_lbl.Size = new System.Drawing.Size(104, 17);
            this.KitapAciklama_lbl.TabIndex = 17;
            this.KitapAciklama_lbl.Text = "Kitap Açıklama:";
            // 
            // kitapıd_txt
            // 
            this.kitapıd_txt.Location = new System.Drawing.Point(157, 338);
            this.kitapıd_txt.Name = "kitapıd_txt";
            this.kitapıd_txt.Size = new System.Drawing.Size(129, 22);
            this.kitapıd_txt.TabIndex = 18;
            this.kitapıd_txt.Text = "Kitap ID giriniz.";
            this.kitapıd_txt.Click += new System.EventHandler(this.kitapıd_txt_Click);
            // 
            // kitapadi_txt
            // 
            this.kitapadi_txt.Location = new System.Drawing.Point(157, 366);
            this.kitapadi_txt.Name = "kitapadi_txt";
            this.kitapadi_txt.Size = new System.Drawing.Size(129, 22);
            this.kitapadi_txt.TabIndex = 19;
            this.kitapadi_txt.Text = "Kitap Adı giriniz.";
            this.kitapadi_txt.Click += new System.EventHandler(this.kitapadi_txt_Click);
            // 
            // yazaradi_txt
            // 
            this.yazaradi_txt.Location = new System.Drawing.Point(157, 394);
            this.yazaradi_txt.Name = "yazaradi_txt";
            this.yazaradi_txt.Size = new System.Drawing.Size(129, 22);
            this.yazaradi_txt.TabIndex = 20;
            this.yazaradi_txt.Text = "Yazar Adı giriniz.";
            this.yazaradi_txt.Click += new System.EventHandler(this.yazaradi_txt_Click);
            // 
            // yayinevi_txt
            // 
            this.yayinevi_txt.Location = new System.Drawing.Point(157, 422);
            this.yayinevi_txt.Name = "yayinevi_txt";
            this.yayinevi_txt.Size = new System.Drawing.Size(129, 22);
            this.yayinevi_txt.TabIndex = 21;
            this.yayinevi_txt.Text = "Yayın Evi giriniz.";
            this.yayinevi_txt.Click += new System.EventHandler(this.yayinevi_txt_Click);
            // 
            // sayfasayisi_txt
            // 
            this.sayfasayisi_txt.Location = new System.Drawing.Point(157, 458);
            this.sayfasayisi_txt.Name = "sayfasayisi_txt";
            this.sayfasayisi_txt.Size = new System.Drawing.Size(129, 22);
            this.sayfasayisi_txt.TabIndex = 22;
            this.sayfasayisi_txt.Text = "Sayfa Sayısı giriniz.";
            this.sayfasayisi_txt.Click += new System.EventHandler(this.sayfasayisi_txt_Click);
            // 
            // baskiyili_txt
            // 
            this.baskiyili_txt.Location = new System.Drawing.Point(157, 491);
            this.baskiyili_txt.Name = "baskiyili_txt";
            this.baskiyili_txt.Size = new System.Drawing.Size(129, 22);
            this.baskiyili_txt.TabIndex = 23;
            this.baskiyili_txt.Text = "Baskı Yılı giriniz.";
            this.baskiyili_txt.Click += new System.EventHandler(this.baskiyili_txt_Click);
            // 
            // kitapturu_txt
            // 
            this.kitapturu_txt.Location = new System.Drawing.Point(157, 519);
            this.kitapturu_txt.Name = "kitapturu_txt";
            this.kitapturu_txt.Size = new System.Drawing.Size(129, 22);
            this.kitapturu_txt.TabIndex = 24;
            this.kitapturu_txt.Text = "Kitap Türü giriniz.";
            this.kitapturu_txt.Click += new System.EventHandler(this.kitapturu_txt_Click);
            // 
            // stoksayisi_txt
            // 
            this.stoksayisi_txt.Location = new System.Drawing.Point(157, 544);
            this.stoksayisi_txt.Name = "stoksayisi_txt";
            this.stoksayisi_txt.Size = new System.Drawing.Size(129, 22);
            this.stoksayisi_txt.TabIndex = 25;
            this.stoksayisi_txt.Text = "Stok Sayısı giriniz.";
            this.stoksayisi_txt.Click += new System.EventHandler(this.stoksayisi_txt_Click);
            // 
            // kitapaciklama_txt
            // 
            this.kitapaciklama_txt.Location = new System.Drawing.Point(157, 572);
            this.kitapaciklama_txt.Name = "kitapaciklama_txt";
            this.kitapaciklama_txt.Size = new System.Drawing.Size(129, 22);
            this.kitapaciklama_txt.TabIndex = 26;
            this.kitapaciklama_txt.Text = "Kitap Açıklama giriniz.";
            this.kitapaciklama_txt.Click += new System.EventHandler(this.kitapaciklama_txt_Click);
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(37, 615);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(91, 41);
            this.ekle_btn.TabIndex = 27;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(134, 615);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(100, 40);
            this.guncelle_btn.TabIndex = 28;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(240, 616);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(78, 39);
            this.sil_btn.TabIndex = 29;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // kitap_dgrid
            // 
            this.kitap_dgrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.kitap_dgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_dgrid.Location = new System.Drawing.Point(504, 316);
            this.kitap_dgrid.Name = "kitap_dgrid";
            this.kitap_dgrid.RowHeadersWidth = 51;
            this.kitap_dgrid.RowTemplate.Height = 24;
            this.kitap_dgrid.Size = new System.Drawing.Size(1408, 339);
            this.kitap_dgrid.TabIndex = 30;
            this.kitap_dgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitap_dgrid_CellContentClick);
            // 
            // kayitlikitaplar_btn
            // 
            this.kayitlikitaplar_btn.Location = new System.Drawing.Point(1111, 265);
            this.kayitlikitaplar_btn.Name = "kayitlikitaplar_btn";
            this.kayitlikitaplar_btn.Size = new System.Drawing.Size(184, 40);
            this.kayitlikitaplar_btn.TabIndex = 31;
            this.kayitlikitaplar_btn.Text = "KAYITLI KİTAPLAR";
            this.kayitlikitaplar_btn.UseVisualStyleBackColor = true;
            this.kayitlikitaplar_btn.Click += new System.EventHandler(this.kayitlikitaplar_btn_Click);
            // 
            // KitapIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 921);
            this.Controls.Add(this.kayitlikitaplar_btn);
            this.Controls.Add(this.kitap_dgrid);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.kitapaciklama_txt);
            this.Controls.Add(this.stoksayisi_txt);
            this.Controls.Add(this.kitapturu_txt);
            this.Controls.Add(this.baskiyili_txt);
            this.Controls.Add(this.sayfasayisi_txt);
            this.Controls.Add(this.yayinevi_txt);
            this.Controls.Add(this.yazaradi_txt);
            this.Controls.Add(this.kitapadi_txt);
            this.Controls.Add(this.kitapıd_txt);
            this.Controls.Add(this.KitapAciklama_lbl);
            this.Controls.Add(this.StokSayisi_lbl);
            this.Controls.Add(this.KitapTuru_lbl);
            this.Controls.Add(this.BaskiYili_lbl);
            this.Controls.Add(this.SayfaSayisi_lbl);
            this.Controls.Add(this.YayinEvi_lbl);
            this.Controls.Add(this.YazarAdi_lbl);
            this.Controls.Add(this.KitapAdi_lbl);
            this.Controls.Add(this.KitapID_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ogrencibilgileri_lbl);
            this.Controls.Add(this.ara_btn);
            this.Controls.Add(this.kitap_txt);
            this.Controls.Add(this.kitap_cmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitapara_lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Geri_btn);
            this.Name = "KitapIslemleri";
            this.Text = "KitapIslemleri";
            this.Load += new System.EventHandler(this.KitapIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitap_dgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Geri_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label kitapara_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox kitap_cmb;
        private System.Windows.Forms.TextBox kitap_txt;
        private System.Windows.Forms.Button ara_btn;
        private System.Windows.Forms.Label ogrencibilgileri_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KitapID_txt;
        private System.Windows.Forms.Label KitapAdi_lbl;
        private System.Windows.Forms.Label YazarAdi_lbl;
        private System.Windows.Forms.Label YayinEvi_lbl;
        private System.Windows.Forms.Label SayfaSayisi_lbl;
        private System.Windows.Forms.Label BaskiYili_lbl;
        private System.Windows.Forms.Label KitapTuru_lbl;
        private System.Windows.Forms.Label StokSayisi_lbl;
        private System.Windows.Forms.Label KitapAciklama_lbl;
        private System.Windows.Forms.TextBox kitapıd_txt;
        private System.Windows.Forms.TextBox kitapadi_txt;
        private System.Windows.Forms.TextBox yazaradi_txt;
        private System.Windows.Forms.TextBox yayinevi_txt;
        private System.Windows.Forms.TextBox sayfasayisi_txt;
        private System.Windows.Forms.TextBox baskiyili_txt;
        private System.Windows.Forms.TextBox kitapturu_txt;
        private System.Windows.Forms.TextBox stoksayisi_txt;
        private System.Windows.Forms.TextBox kitapaciklama_txt;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.DataGridView kitap_dgrid;
        private System.Windows.Forms.Button kayitlikitaplar_btn;
    }
}