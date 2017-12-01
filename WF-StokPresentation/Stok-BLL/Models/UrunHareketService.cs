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
    public class UrunHareketService
    {
        StokDataEntities ent = new StokDataEntities();

        public List<UrunHareketModel> UrunHareketListByUrunID(int id)
        {
            var sonuc = (from f in ent.UrunHareketler
                         where f.UrunID == id && f.Silindi == false
                         select new UrunHareketModel
                         {
                             HareketID = f.HareketID,
                             Tarih = f.Tarih,
                             IslemTuru = f.IslemTuru,
                             CariID = f.CariID,
                             CariUnvan = f.Cariler.Unvan,
                             UrunID = f.UrunID,
                             Belge = f.Belge,
                             Birim = f.Birim,
                             BirimFiyat = f.BirimFiyat,
                             Adet = f.Adet,
                             Tutar = f.Tutar
                         }).ToList();

            return sonuc;
        }

        public void Kaydet(UrunHareketler uh)
        {
            ent.UrunHareketler.Add(uh);
            try
            {
                ent.SaveChanges();
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
            }
        }
        public void Guncelle(UrunHareketler uh)
        {

            UrunHareketler sonuc = ent.UrunHareketler.Where(x => x.CariID == Genel.CariID).FirstOrDefault();

            sonuc.Tarih = uh.Tarih;
            sonuc.IslemTuru = uh.IslemTuru;
            sonuc.Belge = uh.Belge;
            sonuc.Silindi = uh.Silindi;
            sonuc.UrunID = uh.UrunID;
            sonuc.Adet = uh.Adet;
            sonuc.BirimFiyat = uh.BirimFiyat;
            sonuc.Birim = uh.Birim;
            sonuc.Tutar = uh.Tutar;
            try
            {
                ent.SaveChanges();

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

       

    }
}
