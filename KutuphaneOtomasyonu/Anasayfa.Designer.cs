namespace KutuphaneOtomasyonu
{
    partial class Anasayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.ogrenci_islemleri = new System.Windows.Forms.Button();
            this.Kitapislemleri_btn = new System.Windows.Forms.Button();
            this.Emanetiade_btn = new System.Windows.Forms.Button();
            this.Kitap_emanet_iade_btn = new System.Windows.Forms.Button();
            this.Ogrenci_emanet_iade_btn = new System.Windows.Forms.Button();
            this.Grafik_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ogrenci_islemleri
            // 
            this.ogrenci_islemleri.BackColor = System.Drawing.Color.NavajoWhite;
            this.ogrenci_islemleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ogrenci_islemleri.BackgroundImage")));
            this.ogrenci_islemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ogrenci_islemleri.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrenci_islemleri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ogrenci_islemleri.Location = new System.Drawing.Point(128, 133);
            this.ogrenci_islemleri.Name = "ogrenci_islemleri";
            this.ogrenci_islemleri.Size = new System.Drawing.Size(239, 138);
            this.ogrenci_islemleri.TabIndex = 0;
            this.ogrenci_islemleri.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.ogrenci_islemleri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ogrenci_islemleri.UseVisualStyleBackColor = false;
            this.ogrenci_islemleri.Click += new System.EventHandler(this.Ogrenci_islemleri);
            // 
            // Kitapislemleri_btn
            // 
            this.Kitapislemleri_btn.BackColor = System.Drawing.Color.NavajoWhite;
            this.Kitapislemleri_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kitapislemleri_btn.BackgroundImage")));
            this.Kitapislemleri_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Kitapislemleri_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kitapislemleri_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Kitapislemleri_btn.Location = new System.Drawing.Point(128, 369);
            this.Kitapislemleri_btn.Name = "Kitapislemleri_btn";
            this.Kitapislemleri_btn.Size = new System.Drawing.Size(239, 138);
            this.Kitapislemleri_btn.TabIndex = 1;
            this.Kitapislemleri_btn.Text = "KİTAP İŞLEMLERİ";
            this.Kitapislemleri_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Kitapislemleri_btn.UseVisualStyleBackColor = false;
            this.Kitapislemleri_btn.Click += new System.EventHandler(this.Kitapislemleri_btn_Click);
            // 
            // Emanetiade_btn
            // 
            this.Emanetiade_btn.BackColor = System.Drawing.Color.NavajoWhite;
            this.Emanetiade_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Emanetiade_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Emanetiade_btn.Image = ((System.Drawing.Image)(resources.GetObject("Emanetiade_btn.Image")));
            this.Emanetiade_btn.Location = new System.Drawing.Point(128, 595);
            this.Emanetiade_btn.Name = "Emanetiade_btn";
            this.Emanetiade_btn.Size = new System.Drawing.Size(239, 138);
            this.Emanetiade_btn.TabIndex = 2;
            this.Emanetiade_btn.Text = "EMANET VE İADE İŞLEMLERİ";
            this.Emanetiade_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Emanetiade_btn.UseVisualStyleBackColor = false;
            this.Emanetiade_btn.Click += new System.EventHandler(this.Emanetiade_btn_Click);
            // 
            // Kitap_emanet_iade_btn
            // 
            this.Kitap_emanet_iade_btn.BackColor = System.Drawing.Color.NavajoWhite;
            this.Kitap_emanet_iade_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Kitap_emanet_iade_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kitap_emanet_iade_btn.Image = ((System.Drawing.Image)(resources.GetObject("Kitap_emanet_iade_btn.Image")));
            this.Kitap_emanet_iade_btn.Location = new System.Drawing.Point(592, 368);
            this.Kitap_emanet_iade_btn.Name = "Kitap_emanet_iade_btn";
            this.Kitap_emanet_iade_btn.Size = new System.Drawing.Size(239, 138);
            this.Kitap_emanet_iade_btn.TabIndex = 3;
            this.Kitap_emanet_iade_btn.Text = "KİTAP EMANET VE İADE LİSTESİ";
            this.Kitap_emanet_iade_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Kitap_emanet_iade_btn.UseVisualStyleBackColor = false;
            this.Kitap_emanet_iade_btn.Click += new System.EventHandler(this.Kitap_emanet_iade_btn_Click);
            // 
            // Ogrenci_emanet_iade_btn
            // 
            this.Ogrenci_emanet_iade_btn.BackColor = System.Drawing.Color.NavajoWhite;
            this.Ogrenci_emanet_iade_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Ogrenci_emanet_iade_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ogrenci_emanet_iade_btn.Image = ((System.Drawing.Image)(resources.GetObject("Ogrenci_emanet_iade_btn.Image")));
            this.Ogrenci_emanet_iade_btn.Location = new System.Drawing.Point(592, 131);
            this.Ogrenci_emanet_iade_btn.Name = "Ogrenci_emanet_iade_btn";
            this.Ogrenci_emanet_iade_btn.Size = new System.Drawing.Size(239, 138);
            this.Ogrenci_emanet_iade_btn.TabIndex = 4;
            this.Ogrenci_emanet_iade_btn.Text = "ÖĞRENCİ EMANET VE İADE LİSTESİ";
            this.Ogrenci_emanet_iade_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Ogrenci_emanet_iade_btn.UseVisualStyleBackColor = false;
            this.Ogrenci_emanet_iade_btn.Click += new System.EventHandler(this.Ogrenci_emanet_iade_btn_Click_1);
            // 
            // Grafik_btn
            // 
            this.Grafik_btn.BackColor = System.Drawing.Color.NavajoWhite;
            this.Grafik_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Grafik_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Grafik_btn.Image = ((System.Drawing.Image)(resources.GetObject("Grafik_btn.Image")));
            this.Grafik_btn.Location = new System.Drawing.Point(592, 595);
            this.Grafik_btn.Name = "Grafik_btn";
            this.Grafik_btn.Size = new System.Drawing.Size(239, 138);
            this.Grafik_btn.TabIndex = 5;
            this.Grafik_btn.Text = "GRAFİK";
            this.Grafik_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Grafik_btn.UseVisualStyleBackColor = false;
            this.Grafik_btn.Click += new System.EventHandler(this.Grafik_btn_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Grafik_btn);
            this.Controls.Add(this.Ogrenci_emanet_iade_btn);
            this.Controls.Add(this.Kitap_emanet_iade_btn);
            this.Controls.Add(this.Emanetiade_btn);
            this.Controls.Add(this.Kitapislemleri_btn);
            this.Controls.Add(this.ogrenci_islemleri);
            this.Name = "Anasayfa";
            this.Text = "Kütüphane Otomasyonu Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ogrenci_islemleri;
        private System.Windows.Forms.Button Kitapislemleri_btn;
        private System.Windows.Forms.Button Emanetiade_btn;
        private System.Windows.Forms.Button Kitap_emanet_iade_btn;
        private System.Windows.Forms.Button Ogrenci_emanet_iade_btn;
        private System.Windows.Forms.Button Grafik_btn;
    }
}

