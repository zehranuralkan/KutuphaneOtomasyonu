namespace KutuphaneOtomasyonu
{
    partial class Ogrenci_Emanet_Iade_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ogrenci_Emanet_Iade_Listesi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Ara_btn = new System.Windows.Forms.Button();
            this.Ogrenci_Numarası_txt = new System.Windows.Forms.TextBox();
            this.Ogrenci_Numarası_lbl = new System.Windows.Forms.Label();
            this.kayit_dg = new System.Windows.Forms.DataGridView();
            this.Kayitlar_btn = new System.Windows.Forms.Button();
            this.Geri_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.Ara_btn);
            this.groupBox1.Controls.Add(this.Ogrenci_Numarası_txt);
            this.groupBox1.Controls.Add(this.Ogrenci_Numarası_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(96, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMANET İADE EDİLEN KİTAPLAR ";
            // 
            // Ara_btn
            // 
            this.Ara_btn.Location = new System.Drawing.Point(16, 115);
            this.Ara_btn.Name = "Ara_btn";
            this.Ara_btn.Size = new System.Drawing.Size(521, 32);
            this.Ara_btn.TabIndex = 2;
            this.Ara_btn.Text = "ARA";
            this.Ara_btn.UseVisualStyleBackColor = true;
            this.Ara_btn.Click += new System.EventHandler(this.Ara_btn_Click);
            // 
            // Ogrenci_Numarası_txt
            // 
            this.Ogrenci_Numarası_txt.Location = new System.Drawing.Point(225, 62);
            this.Ogrenci_Numarası_txt.Name = "Ogrenci_Numarası_txt";
            this.Ogrenci_Numarası_txt.Size = new System.Drawing.Size(312, 27);
            this.Ogrenci_Numarası_txt.TabIndex = 1;
            this.Ogrenci_Numarası_txt.Text = "Öğrenci Numarası Giriniz.";
            this.Ogrenci_Numarası_txt.Click += new System.EventHandler(this.Ogrenci_Numarası_txt_Click);
            // 
            // Ogrenci_Numarası_lbl
            // 
            this.Ogrenci_Numarası_lbl.AutoSize = true;
            this.Ogrenci_Numarası_lbl.Location = new System.Drawing.Point(15, 69);
            this.Ogrenci_Numarası_lbl.Name = "Ogrenci_Numarası_lbl";
            this.Ogrenci_Numarası_lbl.Size = new System.Drawing.Size(167, 20);
            this.Ogrenci_Numarası_lbl.TabIndex = 0;
            this.Ogrenci_Numarası_lbl.Text = "Öğrenci Numarası:";
            // 
            // kayit_dg
            // 
            this.kayit_dg.BackgroundColor = System.Drawing.Color.White;
            this.kayit_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayit_dg.Location = new System.Drawing.Point(255, 335);
            this.kayit_dg.Name = "kayit_dg";
            this.kayit_dg.RowHeadersWidth = 51;
            this.kayit_dg.RowTemplate.Height = 24;
            this.kayit_dg.Size = new System.Drawing.Size(1014, 356);
            this.kayit_dg.TabIndex = 3;
            // 
            // Kayitlar_btn
            // 
            this.Kayitlar_btn.Location = new System.Drawing.Point(684, 279);
            this.Kayitlar_btn.Name = "Kayitlar_btn";
            this.Kayitlar_btn.Size = new System.Drawing.Size(178, 50);
            this.Kayitlar_btn.TabIndex = 4;
            this.Kayitlar_btn.Text = "KAYITLAR";
            this.Kayitlar_btn.UseVisualStyleBackColor = true;
            this.Kayitlar_btn.Click += new System.EventHandler(this.Kayitlar_btn_Click);
            // 
            // Geri_btn
            // 
            this.Geri_btn.Location = new System.Drawing.Point(96, 653);
            this.Geri_btn.Name = "Geri_btn";
            this.Geri_btn.Size = new System.Drawing.Size(97, 38);
            this.Geri_btn.TabIndex = 4;
            this.Geri_btn.Text = "GERİ";
            this.Geri_btn.UseVisualStyleBackColor = true;
            this.Geri_btn.Click += new System.EventHandler(this.Geri_btn_Click);
            // 
            // Ogrenci_Emanet_Iade_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Kayitlar_btn);
            this.Controls.Add(this.Geri_btn);
            this.Controls.Add(this.kayit_dg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ogrenci_Emanet_Iade_Listesi";
            this.Text = "Öğrenci Emanet Listesi";
            this.Load += new System.EventHandler(this.Ogrenci_Emanet_Iade_Listesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kayit_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Ara_btn;
        private System.Windows.Forms.TextBox Ogrenci_Numarası_txt;
        private System.Windows.Forms.Label Ogrenci_Numarası_lbl;
        private System.Windows.Forms.DataGridView kayit_dg;
        private System.Windows.Forms.Button Kayitlar_btn;
        private System.Windows.Forms.Button Geri_btn;
    }
}