using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_StokPresentation.Stok_DAL.DataModel;

namespace WF_StokPresentation.Stok_BLL.Models
{
    public class KategoriService
    {
        StokDataEntities ent = new StokDataEntities();

        public List<string> KategorileriGetir() {

            var sonuc = (from k in ent.Kategoriler where k.Silindi==false select k.KategoriAd).ToList();

            return sonuc;

        } 
        public string KategoriGetirByID(int id)
        {
            var sonuc = (from k in ent.Kategoriler where k.Silindi == false && k.KategoriID==id select k.KategoriAd).FirstOrDefault();


            return sonuc;

        }
        public int IDGetirByKategori(string kategori)
        {
            return ent.Kategoriler.Where(k => k.KategoriAd == kategori && k.Silindi == false).FirstOrDefault().KategoriID;
        }
    }
}
