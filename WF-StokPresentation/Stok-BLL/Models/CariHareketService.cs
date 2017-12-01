using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF_StokPresentation.Stok_DAL.DataModel;

namespace WF_StokPresentation.Stok_BLL.Models
{
    public class CariHareketService
    {
        StokDataEntities ent = new StokDataEntities();
        public bool CariHareketEkle(CariHareketler ch)
        {
            ent.CariHareketler.Add(ch);
            try
            {
                ent.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }


    }
}
