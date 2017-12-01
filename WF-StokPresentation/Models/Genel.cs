using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_StokPresentation.Models
{
    public class Genel
    {
        public static int KatID;
        public static int UrID;
        public static int CariID;
        public static string CariUnvan;
        public static string CariTipi;

        #region Form içindeki tüm textboxlar silinir fakat groupbox ve tabcontrol içindekiler hariç !!!
        //public static void Temizle(Form frm)
        //{
        //    foreach (Control item in frm.Controls)
        //    {
        //        if (item.GetType() == typeof(TextBox))
        //        {
        //            item.Text = "";
        //        }              
        //    }
        //}
        #endregion






    }
}
