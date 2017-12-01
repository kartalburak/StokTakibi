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
    public class CariService
    {
        StokDataEntities ent = new StokDataEntities();

        public List<Cariler> UnvanaGoreListele(string unvan)
        {
            var sonuc = (from f in ent.Cariler where f.CariTipi.StartsWith(unvan) select f).ToList();
            return sonuc;
        }
        public List<Cariler> AlıcıListe()
        {
            var sonuc = (from f in ent.Cariler where f.CariTipi == "Alıcı" select f).ToList();
            return sonuc;
        }
        public List<Cariler> SatıcıListe()
        {
            var sonuc = (from f in ent.Cariler where f.CariTipi == "Satıcı" select f).ToList();
            return sonuc;
        }
        public List<Cariler> CariListele()
        {
            var sonuc = (from f in ent.Cariler select f).ToList();
            return sonuc;

        }



        public bool CariBorcAlacakGuncelle(CariHareketler ch, decimal tutar)
        {

            var sonuc = (from f in ent.CariHareketler where f.CariID == ch.CariID select f).FirstOrDefault();

            if (ch.IslemTuru == "Stok Giriş")
            {
                ch.Borc = ch.Borc + tutar;
            }
            else
            {
                ch.Alacak = ch.Alacak + tutar;
            }
            try
            {
                ent.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                string hata = ex.Message;
                return false;
            }






        }

        public bool CariBakiyelerGuncelle(int CariID, decimal Alacak, decimal Borc)
        {




            return true;

        }



    }
}
