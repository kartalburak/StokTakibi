using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_StokPresentation.Models;
using WF_StokPresentation.Stok_BLL.Models;
using WF_StokPresentation.Stok_DAL.DataModel;

namespace WF_StokPresentation
{
    public partial class StokIslemleri : Form
    {
        public StokIslemleri()
        {
            InitializeComponent();
        }
        KategoriService ks = new KategoriService();
        UrunService us = new UrunService();
        CariService cs = new CariService();
        CariHareketService chs = new CariHareketService();
        UrunHareketService uhs = new UrunHareketService();
        UrunHareketModel um = new UrunHareketModel();

        private void StokIslemleri_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            cmbkategoriler.DataSource = ks.KategorileriGetir();
            dgvurunler.DataSource = us.UrunleriGetir();
            dgvHareketler.DataSource = uhs.UrunHareketListByUrunID(Genel.UrID);
            dgvurunler.Columns[0].Visible = false;
            dgvurunler.Columns[8].Visible = false;
            dgvurunler.Columns[9].Visible = false;

            slblzaman.Text = DateTime.Now.ToShortDateString() + " || " + DateTime.Now.ToShortTimeString();


        }
        #region Stok Kartlari

        private void txtkodagore_TextChanged(object sender, EventArgs e)
        {
            dgvurunler.DataSource = us.UrunleriGetirByKodaGore(txtkodagore.Text);
        }

        private void txtadagore_TextChanged(object sender, EventArgs e)
        {
            dgvurunler.DataSource = us.UrunleriGetirByUrunAdaGore(txtadagore.Text);
        }

        private void cmbkategoriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtkategori.Text = cmbkategoriler.SelectedItem.ToString();
        }

        private void dgvurunler_DoubleClick(object sender, EventArgs e)
        {
            Genel.KatID = Convert.ToInt32(dgvurunler.SelectedRows[0].Cells[3].Value);
            Genel.UrID = Convert.ToInt32(dgvurunler.SelectedRows[0].Cells[0].Value);

            tsDegistir.Enabled = true;
            tsSil.Enabled = true;
            tsKaydet.Enabled = false;

            txturunadi.Text = dgvurunler.SelectedRows[0].Cells[2].Value.ToString();
            txturunkodu.Text = dgvurunler.SelectedRows[0].Cells[1].Value.ToString();
            txturunadi2.Text = dgvurunler.SelectedRows[0].Cells[2].Value.ToString();
            txturunkodu2.Text = dgvurunler.SelectedRows[0].Cells[1].Value.ToString();
            txtkategori.Text = ks.KategoriGetirByID(Convert.ToInt32(dgvurunler.SelectedRows[0].Cells[3].Value));
            txtstokmiktari.Text = dgvurunler.SelectedRows[0].Cells[4].Value.ToString();
            txtkritik.Text = dgvurunler.SelectedRows[0].Cells[5].Value.ToString();
            txtbirimfiyat.Text = dgvurunler.SelectedRows[0].Cells[6].Value.ToString();
            txtfiyat.Text = dgvurunler.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void tsYeni_Click(object sender, EventArgs e)
        {
            tsKaydet.Enabled = true;
            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            Temizle();

        }
        public void Temizle()
        {
            txturunadi.Clear();
            txturunkodu.Clear();
            txtkategori.Clear();
            txtstokmiktari.Clear();
            txtkritik.Clear();
            txtbirimfiyat.Clear();
        }

        private void tsKaydet_Click(object sender, EventArgs e)
        {
            tsYeni.Enabled = true;
            tsKaydet.Enabled = false;
            Urunler u = new Urunler();
            u.UrunAd = txturunadi.Text;
            u.UrunKodu = txturunkodu.Text;
            u.KategoriID = ks.IDGetirByKategori(cmbkategoriler.SelectedItem.ToString());
            u.Miktar = Convert.ToInt32(txtstokmiktari.Text);
            u.KritikSeviye = Convert.ToInt32(txtkritik.Text);
            u.BirimFiyat = Convert.ToDecimal(txtbirimfiyat.Text);
            u.Silindi = false;

            //  int katid = ks.IDGetirByKategori(cmbkategoriler.SelectedItem.ToString());


            if (txturunkodu.Text.Trim() != "" && txturunadi.Text.Trim() != ""
                && txtkategori.Text.Trim() != "")
            {
                us.UrunEkle(u);
            }
            dgvurunler.DataSource = us.UrunleriGetir();


        }

        private void tsDegistir_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            u.UrunAd = txturunadi.Text;
            u.UrunKodu = txturunkodu.Text;
            u.KategoriID = Genel.KatID;
            u.Miktar = Convert.ToInt32(txtstokmiktari.Text);
            u.KritikSeviye = Convert.ToInt32(txtkritik.Text);
            u.BirimFiyat = Convert.ToDecimal(txtbirimfiyat.Text);
            u.Silindi = false;


            us.UrunGuncelle(u);

            tsDegistir.Enabled = false;
            tsSil.Enabled = false;
            tsYeni.Enabled = true;
            dgvurunler.DataSource = us.UrunleriGetir();
        }

        private void tsSil_Click(object sender, EventArgs e)
        {
            us.UrunSil(Genel.UrID);
            Temizle();
            dgvurunler.DataSource = us.UrunleriGetir();
            tsSil.Enabled = true;
            tsDegistir.Enabled = true;
        }
        #endregion
        #region Stok Hareketler
        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            txttarih.Text = dtpTarih.Value.ToShortDateString();
        }
        private void cmbislemturleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtislemturu.Text = cmbislemturleri.SelectedItem.ToString();
            txtcari.Focus();
        }
        private void btncaribul_Click(object sender, EventArgs e)
        {
            if (txtislemturu.Text == "Stok Giriş")
            {
                Genel.CariTipi = "Satıcı";
            }
            else
            {
                Genel.CariTipi = "Alıcı";
            }


            CariSorgulama frm = new CariSorgulama();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            txtcari.Text = Genel.CariUnvan;

        }
        private void btnyeni_Click(object sender, EventArgs e)
        {
            btnkaydet.Enabled = true;
            btndegistir.Enabled = false;
            btnsil.Enabled = false;
            Temizle2();
        }
        public void Temizle2()
        {
            txttarih.Text = DateTime.Now.ToShortDateString();
            txtislemturu.Clear();
            txtcari.Clear();
            txtbelge.Clear();
            txtbirim.Clear();
            // txtbirimfiyat.Clear();
            txtadet.Clear();
            txttutar.Clear();
            //txturunadi2.Clear();
            //txturunkodu2.Clear();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            if (txtislemturu.Text == "Stok Çıkış" && Convert.ToInt32(txtadet.Text) > Convert.ToInt32(txtstokmiktari.Text))
            {
                MessageBox.Show("Dikkat ! Yetersiz stok miktarı ");
                txtadet.Focus();
            }
            else
            {
                if (txturunadi2.Text.Trim() != "" && txtcari.Text.Trim() != "" && txttutar.Text.Trim() != "")
                {
                    UrunHareketler uh = new UrunHareketler();
                    uh.Tarih = Convert.ToDateTime(txttarih.Text);
                    uh.IslemTuru = txtislemturu.Text;
                    uh.CariID = Genel.CariID;
                    uh.Belge = txtbelge.Text;
                    uh.UrunID = Genel.UrID;
                    uh.Birim = txtbirim.Text;
                    uh.Adet = Convert.ToInt32(txtadet.Text);
                    uh.BirimFiyat = Convert.ToDecimal(txtbirimfiyat.Text);
                    // uh.Tutar = Convert.ToDecimal(txttutar.Text);

                    uhs.Kaydet(uh);
                    MessageBox.Show("Ürün Hareketleri Eklendi ....");
                    dgvHareketler.DataSource = uhs.UrunHareketListByUrunID(Genel.UrID);
                    //Stok Miktarı Düzenlenmeli
                    if (us.UrunStokGuncelle(Genel.UrID, cmbislemturleri.SelectedItem.ToString(), uh.Adet))
                    {
                        txtstokmiktari.Text = dgvurunler.SelectedRows[0].Cells[4].Value.ToString();
                        dgvurunler.DataSource = us.UrunleriGetir();
                        //CariHareketlere borç alacak eklenmeli
                        CariHareketler ch = new CariHareketler();
                        ch.Tarih = Convert.ToDateTime(txttarih.Text);
                        ch.IslemTuru = txtislemturu.Text;
                        ch.CariID = Genel.CariID;
                        ch.Belge = txtbelge.Text;

                        if (txtislemturu.Text == "Stok Giriş")
                        {
                            ch.Alacak = Convert.ToDecimal(txttutar.Text);
                            ch.Borc = 0;
                        }
                        else
                        {
                            ch.Alacak = 0;
                            ch.Borc = Convert.ToDecimal(txttutar.Text);
                        }
                        ch.KasaHareketID = 0;
                        ch.UrunHareketID = uh.HareketID;
                        if (chs.CariHareketEkle(ch))
                        {
                            MessageBox.Show("Cari Hareket Kaydı Eklendi....");
                            //cari kartında toplam bakiye güncellenmeli
                            if (cs.CariBakiyelerGuncelle(ch.CariID, ch.Alacak, ch.Borc))
                            {
                                MessageBox.Show("");
                            }
                            else
                            {
                                MessageBox.Show("");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ürün Adı,Cari ve Tutar Boş Geçilemez !!");
                    txturunadi2.Focus();
                }
            }
        }
        private void btndegistir_Click(object sender, EventArgs e)
        {
            //CariHareketler cs2 = new CariHareketler();
            //cs2.Tarih = Convert.ToDateTime(txttarih.Text);
            //cs2.IslemTuru = txtislemturu.Text;
            //cs2.CariID = Genel.CariID;
            //cs2.Belge = txtbelge.Text;
            //cs2.Silindi = false;
            //cs2.UrunHareketID = Genel.UrID;

            //cs.Guncelle(cs2);

        }
        private void btnsil_Click(object sender, EventArgs e)
        {
            //cs.Sil(Genel.CariID);
        }
        private void txtadet_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtadet.Text) && !string.IsNullOrEmpty(txtbirimfiyat.Text))
            {
                txttutar.Text = (Convert.ToInt32(txtadet.Text) * Convert.ToDecimal(txtbirimfiyat.Text)).ToString();
            }
            else
            {
                txttutar.Text = txtbirimfiyat.Text;
            }

        }



        #endregion




    }
}
