namespace KutuphaneOtomasyonu
{
    partial class OgrenciIslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciIslem));
            this.Ogrencibilgileri = new System.Windows.Forms.Label();
            this.OgrenciID_lbl = new System.Windows.Forms.Label();
            this.OgrenciID_txt = new System.Windows.Forms.TextBox();
            this.İsim_lbl = new System.Windows.Forms.Label();
            this.Isim_txt = new System.Windows.Forms.TextBox();
            this.soyisim_txt = new System.Windows.Forms.Label();
            this.Soyisim = new System.Windows.Forms.TextBox();
            this.Tc_lbl = new System.Windows.Forms.Label();
            this.Tc_txt = new System.Windows.Forms.TextBox();
            this.OgrenciNo_lbl = new System.Windows.Forms.Label();
            this.OgrenciNo_txt = new System.Windows.Forms.TextBox();
            this.Bolum_lbl = new System.Windows.Forms.Label();
            this.Bolum_txt = new System.Windows.Forms.TextBox();
            this.Sinif_lbl = new System.Windows.Forms.Label();
            this.Sinif_txt = new System.Windows.Forms.TextBox();
            this.Telefon_lbl = new System.Windows.Forms.Label();
            this.Telefon_txt = new System.Windows.Forms.TextBox();
            this.Mail_lbl = new System.Windows.Forms.Label();
            this.Mail_txt = new System.Windows.Forms.TextBox();
            this.Adres_lbl = new System.Windows.Forms.Label();
            this.Adres_txt = new System.Windows.Forms.TextBox();
            this.KayitTarihi_lbl = new System.Windows.Forms.Label();
            this.KayitTarihi_txt = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.kayitlar = new System.Windows.Forms.DataGridView();
            this.kayit_btn = new System.Windows.Forms.Button();
            this.geri_btn = new System.Windows.Forms.Button();
            this.Ogrenci_ara = new System.Windows.Forms.Button();
            this.ogrenciara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kayitlar)).BeginInit();
            this.SuspendLayout();
            // 
            // Ogrencibilgileri
            // 
            this.Ogrencibilgileri.AutoSize = true;
            this.Ogrencibilgileri.BackColor = System.Drawing.Color.Turquoise;
            this.Ogrencibilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrencibilgileri.Location = new System.Drawing.Point(20, 206);
            this.Ogrencibilgileri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ogrencibilgileri.Name = "Ogrencibilgileri";
            this.Ogrencibilgileri.Size = new System.Drawing.Size(202, 24);
            this.Ogrencibilgileri.TabIndex = 4;
            this.Ogrencibilgileri.Text = "ÖĞRENCİ BİLGİLERİ";
            // 
            // OgrenciID_lbl
            // 
            this.OgrenciID_lbl.AutoSize = true;
            this.OgrenciID_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciID_lbl.Location = new System.Drawing.Point(7, 247);
            this.OgrenciID_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OgrenciID_lbl.Name = "OgrenciID_lbl";
            this.OgrenciID_lbl.Size = new System.Drawing.Size(68, 15);
            this.OgrenciID_lbl.TabIndex = 5;
            this.OgrenciID_lbl.Text = "Öğrenci ID:";
            // 
            // OgrenciID_txt
            // 
            this.OgrenciID_txt.Location = new System.Drawing.Point(91, 247);
            this.OgrenciID_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OgrenciID_txt.Name = "OgrenciID_txt";
            this.OgrenciID_txt.Size = new System.Drawing.Size(152, 20);
            this.OgrenciID_txt.TabIndex = 6;
            this.OgrenciID_txt.Text = "ÖğrenciID giriniz.";
            this.OgrenciID_txt.Click += new System.EventHandler(this.OgrenciID_txt_Click);
            // 
            // İsim_lbl
            // 
            this.İsim_lbl.AutoSize = true;
            this.İsim_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İsim_lbl.Location = new System.Drawing.Point(6, 271);
            this.İsim_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.İsim_lbl.Name = "İsim_lbl";
            this.İsim_lbl.Size = new System.Drawing.Size(36, 17);
            this.İsim_lbl.TabIndex = 7;
            this.İsim_lbl.Text = "İsim:";
            // 
            // Isim_txt
            // 
            this.Isim_txt.Location = new System.Drawing.Point(91, 273);
            this.Isim_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Isim_txt.Name = "Isim_txt";
            this.Isim_txt.Size = new System.Drawing.Size(152, 20);
            this.Isim_txt.TabIndex = 8;
            this.Isim_txt.Text = "İsim giriniz.";
            this.Isim_txt.Click += new System.EventHandler(this.Isim_txt_Click);
            // 
            // soyisim_txt
            // 
            this.soyisim_txt.AutoSize = true;
            this.soyisim_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.soyisim_txt.Location = new System.Drawing.Point(6, 297);
            this.soyisim_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.soyisim_txt.Name = "soyisim_txt";
            this.soyisim_txt.Size = new System.Drawing.Size(60, 17);
            this.soyisim_txt.TabIndex = 9;
            this.soyisim_txt.Text = "Soyisim:";
            // 
            // Soyisim
            // 
            this.Soyisim.Location = new System.Drawing.Point(91, 297);
            this.Soyisim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Soyisim.Name = "Soyisim";
            this.Soyisim.Size = new System.Drawing.Size(152, 20);
            this.Soyisim.TabIndex = 10;
            this.Soyisim.Text = "Soyisim giriniz.";
            this.Soyisim.Click += new System.EventHandler(this.Soyisim_Click);
            // 
            // Tc_lbl
            // 
            this.Tc_lbl.AutoSize = true;
            this.Tc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tc_lbl.Location = new System.Drawing.Point(6, 325);
            this.Tc_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tc_lbl.Name = "Tc_lbl";
            this.Tc_lbl.Size = new System.Drawing.Size(30, 17);
            this.Tc_lbl.TabIndex = 11;
            this.Tc_lbl.Text = "T.C";
            // 
            // Tc_txt
            // 
            this.Tc_txt.Location = new System.Drawing.Point(91, 325);
            this.Tc_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tc_txt.Name = "Tc_txt";
            this.Tc_txt.Size = new System.Drawing.Size(152, 20);
            this.Tc_txt.TabIndex = 12;
            this.Tc_txt.Text = "TC giriniz.";
            this.Tc_txt.Click += new System.EventHandler(this.Tc_txt_Click);
            // 
            // OgrenciNo_lbl
            // 
            this.OgrenciNo_lbl.AutoSize = true;
            this.OgrenciNo_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciNo_lbl.Location = new System.Drawing.Point(6, 356);
            this.OgrenciNo_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OgrenciNo_lbl.Name = "OgrenciNo_lbl";
            this.OgrenciNo_lbl.Size = new System.Drawing.Size(84, 17);
            this.OgrenciNo_lbl.TabIndex = 13;
            this.OgrenciNo_lbl.Text = "Ogrenci No:";
            // 
            // OgrenciNo_txt
            // 
            this.OgrenciNo_txt.Location = new System.Drawing.Point(91, 354);
            this.OgrenciNo_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OgrenciNo_txt.Name = "OgrenciNo_txt";
            this.OgrenciNo_txt.Size = new System.Drawing.Size(150, 20);
            this.OgrenciNo_txt.TabIndex = 14;
            this.OgrenciNo_txt.Text = "Ogrenci No giriniz.";
            this.OgrenciNo_txt.Click += new System.EventHandler(this.OgrenciNo_txt_Click);
            // 
            // Bolum_lbl
            // 
            this.Bolum_lbl.AutoSize = true;
            this.Bolum_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Bolum_lbl.Location = new System.Drawing.Point(6, 384);
            this.Bolum_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Bolum_lbl.Name = "Bolum_lbl";
            this.Bolum_lbl.Size = new System.Drawing.Size(51, 17);
            this.Bolum_lbl.TabIndex = 15;
            this.Bolum_lbl.Text = "Bölüm:";
            // 
            // Bolum_txt
            // 
            this.Bolum_txt.Location = new System.Drawing.Point(91, 382);
            this.Bolum_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bolum_txt.Name = "Bolum_txt";
            this.Bolum_txt.Size = new System.Drawing.Size(152, 20);
            this.Bolum_txt.TabIndex = 16;
            this.Bolum_txt.Text = "Bolum giriniz.";
            this.Bolum_txt.Click += new System.EventHandler(this.Bolum_txt_Click);
            // 
            // Sinif_lbl
            // 
            this.Sinif_lbl.AutoSize = true;
            this.Sinif_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sinif_lbl.Location = new System.Drawing.Point(6, 411);
            this.Sinif_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Sinif_lbl.Name = "Sinif_lbl";
            this.Sinif_lbl.Size = new System.Drawing.Size(39, 17);
            this.Sinif_lbl.TabIndex = 17;
            this.Sinif_lbl.Text = "Sınıf:";
            // 
            // Sinif_txt
            // 
            this.Sinif_txt.Location = new System.Drawing.Point(91, 410);
            this.Sinif_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Sinif_txt.Name = "Sinif_txt";
            this.Sinif_txt.Size = new System.Drawing.Size(152, 20);
            this.Sinif_txt.TabIndex = 18;
            this.Sinif_txt.Text = "Sınıf giriniz.";
            this.Sinif_txt.Click += new System.EventHandler(this.Sinif_txt_Click);
            // 
            // Telefon_lbl
            // 
            this.Telefon_lbl.AutoSize = true;
            this.Telefon_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Telefon_lbl.Location = new System.Drawing.Point(6, 438);
            this.Telefon_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Telefon_lbl.Name = "Telefon_lbl";
            this.Telefon_lbl.Size = new System.Drawing.Size(60, 17);
            this.Telefon_lbl.TabIndex = 19;
            this.Telefon_lbl.Text = "Telefon:";
            // 
            // Telefon_txt
            // 
            this.Telefon_txt.Location = new System.Drawing.Point(90, 436);
            this.Telefon_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Telefon_txt.Name = "Telefon_txt";
            this.Telefon_txt.Size = new System.Drawing.Size(151, 20);
            this.Telefon_txt.TabIndex = 20;
            this.Telefon_txt.Text = "Telefon giriniz.";
            this.Telefon_txt.Click += new System.EventHandler(this.Telefon_txt_Click);
            // 
            // Mail_lbl
            // 
            this.Mail_lbl.AutoSize = true;
            this.Mail_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Mail_lbl.Location = new System.Drawing.Point(6, 462);
            this.Mail_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Mail_lbl.Name = "Mail_lbl";
            this.Mail_lbl.Size = new System.Drawing.Size(37, 17);
            this.Mail_lbl.TabIndex = 21;
            this.Mail_lbl.Text = "Mail:";
            // 
            // Mail_txt
            // 
            this.Mail_txt.Location = new System.Drawing.Point(90, 462);
            this.Mail_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Mail_txt.Name = "Mail_txt";
            this.Mail_txt.Size = new System.Drawing.Size(151, 20);
            this.Mail_txt.TabIndex = 22;
            this.Mail_txt.Text = "Mail adresi giriniz.";
            this.Mail_txt.Click += new System.EventHandler(this.Mail_txt_Click);
            // 
            // Adres_lbl
            // 
            this.Adres_lbl.AutoSize = true;
            this.Adres_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adres_lbl.Location = new System.Drawing.Point(6, 485);
            this.Adres_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Adres_lbl.Name = "Adres_lbl";
            this.Adres_lbl.Size = new System.Drawing.Size(49, 17);
            this.Adres_lbl.TabIndex = 23;
            this.Adres_lbl.Text = "Adres:";
            // 
            // Adres_txt
            // 
            this.Adres_txt.Location = new System.Drawing.Point(92, 487);
            this.Adres_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Adres_txt.Name = "Adres_txt";
            this.Adres_txt.Size = new System.Drawing.Size(151, 20);
            this.Adres_txt.TabIndex = 24;
            this.Adres_txt.Text = "Adres giriniz.";
            this.Adres_txt.Click += new System.EventHandler(this.Adres_txt_Click);
            // 
            // KayitTarihi_lbl
            // 
            this.KayitTarihi_lbl.AutoSize = true;
            this.KayitTarihi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayitTarihi_lbl.Location = new System.Drawing.Point(6, 511);
            this.KayitTarihi_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.KayitTarihi_lbl.Name = "KayitTarihi_lbl";
            this.KayitTarihi_lbl.Size = new System.Drawing.Size(83, 17);
            this.KayitTarihi_lbl.TabIndex = 25;
            this.KayitTarihi_lbl.Text = "Kayit Tarihi:";
            // 
            // KayitTarihi_txt
            // 
            this.KayitTarihi_txt.Location = new System.Drawing.Point(92, 511);
            this.KayitTarihi_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.KayitTarihi_txt.Name = "KayitTarihi_txt";
            this.KayitTarihi_txt.Size = new System.Drawing.Size(152, 20);
            this.KayitTarihi_txt.TabIndex = 26;
            this.KayitTarihi_txt.Text = "Kayit Tarihi giriniz.";
            this.KayitTarihi_txt.Click += new System.EventHandler(this.KayitTarihi_txt_Click);
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(23, 557);
            this.ekle_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(86, 32);
            this.ekle_btn.TabIndex = 27;
            this.ekle_btn.Text = "EKLE";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.Ekle_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(205, 557);
            this.guncelle_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(93, 32);
            this.guncelle_btn.TabIndex = 28;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(113, 557);
            this.sil_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(87, 32);
            this.sil_btn.TabIndex = 29;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // kayitlar
            // 
            this.kayitlar.BackgroundColor = System.Drawing.Color.White;
            this.kayitlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayitlar.Location = new System.Drawing.Point(309, 245);
            this.kayitlar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kayitlar.Name = "kayitlar";
            this.kayitlar.RowHeadersWidth = 51;
            this.kayitlar.RowTemplate.Height = 24;
            this.kayitlar.Size = new System.Drawing.Size(793, 279);
            this.kayitlar.TabIndex = 30;
            this.kayitlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kayitlar_CellContentClick);
            // 
            // kayit_btn
            // 
            this.kayit_btn.Location = new System.Drawing.Point(719, 206);
            this.kayit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kayit_btn.Name = "kayit_btn";
            this.kayit_btn.Size = new System.Drawing.Size(130, 35);
            this.kayit_btn.TabIndex = 31;
            this.kayit_btn.Text = "KAYITLI ÖĞRENCİLER";
            this.kayit_btn.UseVisualStyleBackColor = true;
            this.kayit_btn.Click += new System.EventHandler(this.kayit_btn_Click);
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(9, 622);
            this.geri_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(60, 40);
            this.geri_btn.TabIndex = 33;
            this.geri_btn.Text = "GERİ";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // Ogrenci_ara
            // 
            this.Ogrenci_ara.Location = new System.Drawing.Point(420, 107);
            this.Ogrenci_ara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ogrenci_ara.Name = "Ogrenci_ara";
            this.Ogrenci_ara.Size = new System.Drawing.Size(106, 26);
            this.Ogrenci_ara.TabIndex = 37;
            this.Ogrenci_ara.Text = "ARA";
            this.Ogrenci_ara.UseVisualStyleBackColor = true;
            this.Ogrenci_ara.Click += new System.EventHandler(this.Ogrenci_ara_Click);
            // 
            // ogrenciara
            // 
            this.ogrenciara.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciara.Location = new System.Drawing.Point(177, 110);
            this.ogrenciara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ogrenciara.Name = "ogrenciara";
            this.ogrenciara.Size = new System.Drawing.Size(226, 24);
            this.ogrenciara.TabIndex = 36;
            this.ogrenciara.Text = "Öğrenci Numarası";
            this.ogrenciara.Click += new System.EventHandler(this.ogrenciara_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(172, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "ÖĞRENCİ ARA";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(23, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 135);
            this.panel1.TabIndex = 34;
            // 
            // OgrenciIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.Ogrenci_ara);
            this.Controls.Add(this.ogrenciara);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.kayit_btn);
            this.Controls.Add(this.kayitlar);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.KayitTarihi_txt);
            this.Controls.Add(this.KayitTarihi_lbl);
            this.Controls.Add(this.Adres_txt);
            this.Controls.Add(this.Adres_lbl);
            this.Controls.Add(this.Mail_txt);
            this.Controls.Add(this.Mail_lbl);
            this.Controls.Add(this.Telefon_txt);
            this.Controls.Add(this.Telefon_lbl);
            this.Controls.Add(this.Sinif_txt);
            this.Controls.Add(this.Sinif_lbl);
            this.Controls.Add(this.Bolum_txt);
            this.Controls.Add(this.Bolum_lbl);
            this.Controls.Add(this.OgrenciNo_txt);
            this.Controls.Add(this.OgrenciNo_lbl);
            this.Controls.Add(this.Tc_txt);
            this.Controls.Add(this.Tc_lbl);
            this.Controls.Add(this.Soyisim);
            this.Controls.Add(this.soyisim_txt);
            this.Controls.Add(this.Isim_txt);
            this.Controls.Add(this.İsim_lbl);
            this.Controls.Add(this.OgrenciID_txt);
            this.Controls.Add(this.OgrenciID_lbl);
            this.Controls.Add(this.Ogrencibilgileri);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "OgrenciIslem";
            this.Text = "Ogrenci İşlemleri";
            this.Load += new System.EventHandler(this.OgrenciIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kayitlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Ogrencibilgileri;
        private System.Windows.Forms.Label OgrenciID_lbl;
        private System.Windows.Forms.TextBox OgrenciID_txt;
        private System.Windows.Forms.Label İsim_lbl;
        private System.Windows.Forms.TextBox Isim_txt;
        private System.Windows.Forms.Label soyisim_txt;
        private System.Windows.Forms.TextBox Soyisim;
        private System.Windows.Forms.Label Tc_lbl;
        private System.Windows.Forms.TextBox Tc_txt;
        private System.Windows.Forms.Label OgrenciNo_lbl;
        private System.Windows.Forms.TextBox OgrenciNo_txt;
        private System.Windows.Forms.Label Bolum_lbl;
        private System.Windows.Forms.TextBox Bolum_txt;
        private System.Windows.Forms.Label Sinif_lbl;
        private System.Windows.Forms.TextBox Sinif_txt;
        private System.Windows.Forms.Label Telefon_lbl;
        private System.Windows.Forms.TextBox Telefon_txt;
        private System.Windows.Forms.Label Mail_lbl;
        private System.Windows.Forms.TextBox Mail_txt;
        private System.Windows.Forms.Label Adres_lbl;
        private System.Windows.Forms.TextBox Adres_txt;
        private System.Windows.Forms.Label KayitTarihi_lbl;
        private System.Windows.Forms.TextBox KayitTarihi_txt;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.DataGridView kayitlar;
        private System.Windows.Forms.Button kayit_btn;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Button Ogrenci_ara;
        private System.Windows.Forms.TextBox ogrenciara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}