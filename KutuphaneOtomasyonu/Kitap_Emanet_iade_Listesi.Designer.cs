namespace KutuphaneOtomasyonu
{
    partial class Kitap_Emanet_iade_Listesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitap_Emanet_iade_Listesi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Kitap_Ara_btn = new System.Windows.Forms.Button();
            this.kitap_bilgi_txt = new System.Windows.Forms.TextBox();
            this.kitap_bilgi_lbl = new System.Windows.Forms.Label();
            this.kategori_cbx = new System.Windows.Forms.ComboBox();
            this.kategori_lbl = new System.Windows.Forms.Label();
            this.Kayit_Listesi_dg = new System.Windows.Forms.DataGridView();
            this.Kayitlar_btn = new System.Windows.Forms.Button();
            this.Geri_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kayit_Listesi_dg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.Kitap_Ara_btn);
            this.groupBox1.Controls.Add(this.kitap_bilgi_txt);
            this.groupBox1.Controls.Add(this.kitap_bilgi_lbl);
            this.groupBox1.Controls.Add(this.kategori_cbx);
            this.groupBox1.Controls.Add(this.kategori_lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(69, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(913, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EMANET- İADE EDİLEN KİTAP";
            // 
            // Kitap_Ara_btn
            // 
            this.Kitap_Ara_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kitap_Ara_btn.Location = new System.Drawing.Point(27, 165);
            this.Kitap_Ara_btn.Name = "Kitap_Ara_btn";
            this.Kitap_Ara_btn.Size = new System.Drawing.Size(446, 29);
            this.Kitap_Ara_btn.TabIndex = 4;
            this.Kitap_Ara_btn.Text = "KİTAP ARA";
            this.Kitap_Ara_btn.UseVisualStyleBackColor = true;
            this.Kitap_Ara_btn.Click += new System.EventHandler(this.Kitap_Ara_btn_Click);
            // 
            // kitap_bilgi_txt
            // 
            this.kitap_bilgi_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_bilgi_txt.Location = new System.Drawing.Point(211, 120);
            this.kitap_bilgi_txt.Name = "kitap_bilgi_txt";
            this.kitap_bilgi_txt.Size = new System.Drawing.Size(262, 27);
            this.kitap_bilgi_txt.TabIndex = 3;
            // 
            // kitap_bilgi_lbl
            // 
            this.kitap_bilgi_lbl.AutoSize = true;
            this.kitap_bilgi_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kitap_bilgi_lbl.Location = new System.Drawing.Point(24, 127);
            this.kitap_bilgi_lbl.Name = "kitap_bilgi_lbl";
            this.kitap_bilgi_lbl.Size = new System.Drawing.Size(103, 20);
            this.kitap_bilgi_lbl.TabIndex = 2;
            this.kitap_bilgi_lbl.Text = "Kitap Bilgisi:";
            // 
            // kategori_cbx
            // 
            this.kategori_cbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_cbx.FormattingEnabled = true;
            this.kategori_cbx.ItemHeight = 20;
            this.kategori_cbx.Items.AddRange(new object[] {
            "YazarAdi",
            "KitapAdi",
            "KitapTuru",
            "KitapID",
            "YayinEvi"});
            this.kategori_cbx.Location = new System.Drawing.Point(207, 66);
            this.kategori_cbx.Name = "kategori_cbx";
            this.kategori_cbx.Size = new System.Drawing.Size(266, 28);
            this.kategori_cbx.TabIndex = 1;
            // 
            // kategori_lbl
            // 
            this.kategori_lbl.AutoSize = true;
            this.kategori_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kategori_lbl.Location = new System.Drawing.Point(23, 73);
            this.kategori_lbl.Name = "kategori_lbl";
            this.kategori_lbl.Size = new System.Drawing.Size(151, 20);
            this.kategori_lbl.TabIndex = 0;
            this.kategori_lbl.Text = "Aranacak Kategori:";
            // 
            // Kayit_Listesi_dg
            // 
            this.Kayit_Listesi_dg.BackgroundColor = System.Drawing.Color.White;
            this.Kayit_Listesi_dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Kayit_Listesi_dg.Location = new System.Drawing.Point(568, 332);
            this.Kayit_Listesi_dg.Name = "Kayit_Listesi_dg";
            this.Kayit_Listesi_dg.RowHeadersWidth = 51;
            this.Kayit_Listesi_dg.RowTemplate.Height = 24;
            this.Kayit_Listesi_dg.Size = new System.Drawing.Size(1090, 498);
            this.Kayit_Listesi_dg.TabIndex = 1;
            // 
            // Kayitlar_btn
            // 
            this.Kayitlar_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kayitlar_btn.Location = new System.Drawing.Point(1018, 278);
            this.Kayitlar_btn.Name = "Kayitlar_btn";
            this.Kayitlar_btn.Size = new System.Drawing.Size(182, 36);
            this.Kayitlar_btn.TabIndex = 2;
            this.Kayitlar_btn.Text = "KAYITLAR";
            this.Kayitlar_btn.UseVisualStyleBackColor = true;
            this.Kayitlar_btn.Click += new System.EventHandler(this.Kayitlar_btn_Click);
            // 
            // Geri_btn
            // 
            this.Geri_btn.Location = new System.Drawing.Point(30, 790);
            this.Geri_btn.Name = "Geri_btn";
            this.Geri_btn.Size = new System.Drawing.Size(144, 40);
            this.Geri_btn.TabIndex = 3;
            this.Geri_btn.Text = "GERİ";
            this.Geri_btn.UseVisualStyleBackColor = true;
            this.Geri_btn.Click += new System.EventHandler(this.Geri_btn_Click);
            // 
            // Kitap_Emanet_iade_Listesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.Geri_btn);
            this.Controls.Add(this.Kayitlar_btn);
            this.Controls.Add(this.Kayit_Listesi_dg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kitap_Emanet_iade_Listesi";
            this.Text = "Kitap Emanet İade Listesi";
            this.Load += new System.EventHandler(this.Kitap_Emanet_iade_Listesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Kayit_Listesi_dg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kategori_lbl;
        private System.Windows.Forms.ComboBox kategori_cbx;
        private System.Windows.Forms.TextBox kitap_bilgi_txt;
        private System.Windows.Forms.Label kitap_bilgi_lbl;
        private System.Windows.Forms.Button Kitap_Ara_btn;
        private System.Windows.Forms.DataGridView Kayit_Listesi_dg;
        private System.Windows.Forms.Button Kayitlar_btn;
        private System.Windows.Forms.Button Geri_btn;
    }
}