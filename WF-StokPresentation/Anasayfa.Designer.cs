namespace WF_StokPresentation
{
    partial class Anasayfa
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
            this.mnuAnasayfa = new System.Windows.Forms.MenuStrip();
            this.mitemStok = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemUrunler = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemStokHareket = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemStokSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemKategoriler = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemMusteriCari = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemCariler = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemCariHareketler = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemCariSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemKasalar = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemGunlukKasa = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemKasaSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemRaporlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemKritikSeviye = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemCariEkstre = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemGelirGider = new System.Windows.Forms.ToolStripMenuItem();
            this.mitemcikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnasayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnasayfa
            // 
            this.mnuAnasayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemStok,
            this.mitemMusteriCari,
            this.mitemKasalar,
            this.mitemRaporlama,
            this.mitemcikis});
            this.mnuAnasayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnasayfa.Name = "mnuAnasayfa";
            this.mnuAnasayfa.Size = new System.Drawing.Size(706, 24);
            this.mnuAnasayfa.TabIndex = 1;
            this.mnuAnasayfa.Text = "menuStrip1";
            // 
            // mitemStok
            // 
            this.mitemStok.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemUrunler,
            this.mitemStokHareket,
            this.mitemStokSorgulama,
            this.mitemKategoriler});
            this.mitemStok.Name = "mitemStok";
            this.mitemStok.Size = new System.Drawing.Size(89, 20);
            this.mitemStok.Text = "&Stok İşlemleri";
            // 
            // mitemUrunler
            // 
            this.mitemUrunler.Name = "mitemUrunler";
            this.mitemUrunler.Size = new System.Drawing.Size(180, 22);
            this.mitemUrunler.Text = "&Ürün Kartları";
            this.mitemUrunler.Click += new System.EventHandler(this.mitemUrunler_Click);
            // 
            // mitemStokHareket
            // 
            this.mitemStokHareket.Name = "mitemStokHareket";
            this.mitemStokHareket.Size = new System.Drawing.Size(180, 22);
            this.mitemStokHareket.Text = "Stok &Giriş-Çıkış";
            this.mitemStokHareket.Click += new System.EventHandler(this.mitemStokHareket_Click);
            // 
            // mitemStokSorgulama
            // 
            this.mitemStokSorgulama.Name = "mitemStokSorgulama";
            this.mitemStokSorgulama.Size = new System.Drawing.Size(180, 22);
            this.mitemStokSorgulama.Text = "St&ok Sorgulama";
            // 
            // mitemKategoriler
            // 
            this.mitemKategoriler.Name = "mitemKategoriler";
            this.mitemKategoriler.Size = new System.Drawing.Size(180, 22);
            this.mitemKategoriler.Text = "&Kategori Tanımlama";
            // 
            // mitemMusteriCari
            // 
            this.mitemMusteriCari.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemCariler,
            this.mitemCariHareketler,
            this.mitemCariSorgulama});
            this.mitemMusteriCari.Name = "mitemMusteriCari";
            this.mitemMusteriCari.Size = new System.Drawing.Size(83, 20);
            this.mitemMusteriCari.Text = "&Müşteri Cari";
            // 
            // mitemCariler
            // 
            this.mitemCariler.Name = "mitemCariler";
            this.mitemCariler.Size = new System.Drawing.Size(155, 22);
            this.mitemCariler.Text = "&Cari Kartlar";
            // 
            // mitemCariHareketler
            // 
            this.mitemCariHareketler.Name = "mitemCariHareketler";
            this.mitemCariHareketler.Size = new System.Drawing.Size(155, 22);
            this.mitemCariHareketler.Text = "Cari &Hareketler";
            // 
            // mitemCariSorgulama
            // 
            this.mitemCariSorgulama.Name = "mitemCariSorgulama";
            this.mitemCariSorgulama.Size = new System.Drawing.Size(155, 22);
            this.mitemCariSorgulama.Text = "Cari &Sorgulama";
            // 
            // mitemKasalar
            // 
            this.mitemKasalar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemGunlukKasa,
            this.mitemKasaSorgulama});
            this.mitemKasalar.Name = "mitemKasalar";
            this.mitemKasalar.Size = new System.Drawing.Size(90, 20);
            this.mitemKasalar.Text = "&Kasa İşlemleri";
            // 
            // mitemGunlukKasa
            // 
            this.mitemGunlukKasa.Name = "mitemGunlukKasa";
            this.mitemGunlukKasa.Size = new System.Drawing.Size(186, 22);
            this.mitemGunlukKasa.Text = "&Günlük Kasa İşlemleri";
            // 
            // mitemKasaSorgulama
            // 
            this.mitemKasaSorgulama.Name = "mitemKasaSorgulama";
            this.mitemKasaSorgulama.Size = new System.Drawing.Size(186, 22);
            this.mitemKasaSorgulama.Text = "&Kasa Sorgulama";
            // 
            // mitemRaporlama
            // 
            this.mitemRaporlama.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitemKritikSeviye,
            this.mitemCariEkstre,
            this.mitemGelirGider});
            this.mitemRaporlama.Name = "mitemRaporlama";
            this.mitemRaporlama.Size = new System.Drawing.Size(76, 20);
            this.mitemRaporlama.Text = "&Raporlama";
            // 
            // mitemKritikSeviye
            // 
            this.mitemKritikSeviye.Name = "mitemKritikSeviye";
            this.mitemKritikSeviye.Size = new System.Drawing.Size(197, 22);
            this.mitemKritikSeviye.Text = "&Kritik Seviye Sorgulama";
            // 
            // mitemCariEkstre
            // 
            this.mitemCariEkstre.Name = "mitemCariEkstre";
            this.mitemCariEkstre.Size = new System.Drawing.Size(197, 22);
            this.mitemCariEkstre.Text = "&Müşteri Cari Ekstre";
            // 
            // mitemGelirGider
            // 
            this.mitemGelirGider.Name = "mitemGelirGider";
            this.mitemGelirGider.Size = new System.Drawing.Size(197, 22);
            this.mitemGelirGider.Text = "&Gelir-Gider Analizi";
            // 
            // mitemcikis
            // 
            this.mitemcikis.Name = "mitemcikis";
            this.mitemcikis.Size = new System.Drawing.Size(44, 20);
            this.mitemcikis.Text = "&Çıkış";
            this.mitemcikis.Click += new System.EventHandler(this.mitemcikis_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 495);
            this.Controls.Add(this.mnuAnasayfa);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnasayfa;
            this.Name = "Anasayfa";
            this.Text = "Stok Takibi Anasayfa İşlemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            this.mnuAnasayfa.ResumeLayout(false);
            this.mnuAnasayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnasayfa;
        private System.Windows.Forms.ToolStripMenuItem mitemStok;
        private System.Windows.Forms.ToolStripMenuItem mitemUrunler;
        private System.Windows.Forms.ToolStripMenuItem mitemStokHareket;
        private System.Windows.Forms.ToolStripMenuItem mitemStokSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitemKategoriler;
        private System.Windows.Forms.ToolStripMenuItem mitemMusteriCari;
        private System.Windows.Forms.ToolStripMenuItem mitemKasalar;
        private System.Windows.Forms.ToolStripMenuItem mitemRaporlama;
        private System.Windows.Forms.ToolStripMenuItem mitemcikis;
        private System.Windows.Forms.ToolStripMenuItem mitemCariler;
        private System.Windows.Forms.ToolStripMenuItem mitemCariHareketler;
        private System.Windows.Forms.ToolStripMenuItem mitemCariSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitemGunlukKasa;
        private System.Windows.Forms.ToolStripMenuItem mitemKasaSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitemKritikSeviye;
        private System.Windows.Forms.ToolStripMenuItem mitemCariEkstre;
        private System.Windows.Forms.ToolStripMenuItem mitemGelirGider;
    }
}