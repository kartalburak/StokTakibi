using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_StokPresentation.Models;
using WF_StokPresentation.Stok_DAL.DataModel;

namespace WF_StokPresentation.Stok_BLL.Models
{
    public class UrunService
    {
        StokDataEntities ent = new StokDataEntities();

        public List<Urunler> UrunleriGetir()
        {
            var sonuc = (from u in ent.Urunler where u.Silindi == false orderby u.UrunKodu descending select u).ToList();
            return sonuc;
        }
        public List<Urunler> UrunleriGetirByKodaGore(string kod)
        {
            var sonuc = (from u in ent.Urunler where u.Silindi == false && u.UrunKodu.StartsWith(kod) select u).ToList();
            return sonuc;
        }
        public List<Urunler> UrunleriGetirByUrunAdaGore(string UrunAd)
        {
            var sonuc = (from u in ent.Urunler where u.Silindi == false && u.UrunAd.StartsWith(UrunAd) select u).ToList();
            return sonuc;
        }
        public bool UrunKontrol(string urunkodu, string urunad)
        {
            var sonuc = (from f in ent.Urunler where f.UrunKodu == urunkodu || f.UrunAd == urunad select f).FirstOrDefault();

            if (sonuc == null)
            {
                return false;
            }
            else
            {
                return true;
            }



        }
        public void UrunEkle(Urunler u)
        {
            bool deger = UrunKontrol(u.UrunKodu, u.UrunAd);
            if (deger)
            {
                MessageBox.Show("Aynı veriden zaten var", "Urun kodu veya urun adına dikkat ediniz..");
            }
            else
            {
                ent.Urunler.Add(u);
                try
                {
                    ent.SaveChanges();
                    MessageBox.Show("Ekleme Başarılı...");
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                    MessageBox.Show(hata);
                }
            }


        }
        public void UrunGuncelle(Urunler u)
        {
            var sonuc = (from ur in ent.Urunler where ur.UrunID == Genel.UrID select ur).FirstOrDefault();
            sonuc.UrunKodu = u.UrunKodu;
            sonuc.UrunAd = u.UrunAd;
            sonuc.KategoriID = u.KategoriID;
            sonuc.Miktar = u.Miktar;
            sonuc.BirimFiyat = u.BirimFiyat;
            sonuc.KritikSeviye = u.KritikSeviye;
            sonuc.Silindi = u.Silindi;

            try
            {
                ent.SaveChanges();
                MessageBox.Show("Güncelleme Başarılı...");
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                MessageBox.Show(hata);
            }

        }
        public void UrunSil(int urunid)
        {
            if (MessageBox.Show("Emin misin ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var sonuc = (from ur in ent.Urunler where ur.UrunID == urunid select ur).FirstOrDefault();
                sonuc.Silindi = true;
                try
                {
                    ent.SaveChanges();
                    MessageBox.Show("Silme Başarılı...");
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                    MessageBox.Show(hata);
                }
            }






        }


        public void Kaydet(CariHareketler cs)
        {
            ent.CariHareketler.Add(cs);
            try
            {
                ent.SaveChanges();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }
        public void Guncelle(CariHareketler cs)
        {

            CariHareketler sonuc = ent.CariHareketler.Where(x => x.CariID == Genel.CariID).FirstOrDefault();

            sonuc.Tarih = cs.Tarih;
            sonuc.IslemTuru = cs.IslemTuru;
            sonuc.Belge = cs.Belge;
            sonuc.Silindi = cs.Silindi;
            sonuc.UrunHareketID = cs.UrunHareketID;

            try
            {
                ent.SaveChanges();
                MessageBox.Show("Güncelleme Başarılı...");
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                MessageBox.Show(hata);
            }
        }
        public void Sil(int cariid)
        {
            if (MessageBox.Show("Emin misin ?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var sonuc = (from ur in ent.CariHareketler where ur.CariID == cariid select ur).FirstOrDefault();
                sonuc.Silindi = true;
                try
                {
                    ent.SaveChanges();
                    MessageBox.Show("Silme Başarılı...");
                }
                catch (Exception ex)
                {
                    string hata = ex.Message;
                    MessageBox.Show(hata);
                }
            }






        }

        public bool UrunStokGuncelle(int id, string islemtipi, int adet)
        {
            bool deger = false;
            var sonuc = (from f in ent.Urunler where f.UrunID == id select f).FirstOrDefault();


            if (islemtipi == "Stok Giriş")
            {

                sonuc.Miktar = sonuc.Miktar + adet;

            }
            else
            {
                sonuc.Miktar = sonuc.Miktar - adet;


            }
            try
            {
                ent.SaveChanges();
                deger = true;
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
            }




            return deger;

        }





    }
}
