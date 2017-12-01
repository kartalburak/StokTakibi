using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_StokPresentation.Stok_DAL.DataModel;

namespace WF_StokPresentation.Models
{
    public class UrunHareketModel
    {
         StokDataEntities ent = new StokDataEntities();
        public int HareketID { get; set; }
        public System.DateTime Tarih { get; set; }
        public string IslemTuru { get; set; }
        public int CariID { get; set; }
        public string CariUnvan { get; set; }
        public int UrunID { get; set; }
        public string Belge { get; set; }
        public string Birim { get; set; }
        public int Adet { get; set; }
        public decimal BirimFiyat { get; set; }
        public Nullable<decimal> Tutar { get; set; }


    }
}
