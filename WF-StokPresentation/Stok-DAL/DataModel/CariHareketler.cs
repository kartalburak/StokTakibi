//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WF_StokPresentation.Stok_DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CariHareketler
    {
        public int HareketID { get; set; }
        public System.DateTime Tarih { get; set; }
        public string IslemTuru { get; set; }
        public int CariID { get; set; }
        public string Belge { get; set; }
        public decimal Borc { get; set; }
        public decimal Alacak { get; set; }
        public int UrunHareketID { get; set; }
        public int KasaHareketID { get; set; }
        public bool Silindi { get; set; }
    
        public virtual Cariler Cariler { get; set; }
    }
}
