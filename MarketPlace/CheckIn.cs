//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketPlace
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckIn
    {
        public int CheckInID { get; set; }
        public int TraderID { get; set; }
        public string FarmerName { get; set; }
        public string VehicalNumber { get; set; }
        public string GoodsDestination { get; set; }
        public int GoodsID { get; set; }
        public long Begs { get; set; }
        public decimal Weight { get; set; }
        public string DriverName { get; set; }
        public int CheckInBy { get; set; }
        public System.DateTime CheckInDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual GoodsMaster GoodsMaster { get; set; }
        public virtual TraderMaster TraderMaster { get; set; }
        public virtual UserMaster UserMaster { get; set; }
    }
}
