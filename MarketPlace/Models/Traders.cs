using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketPlace.Models
{
    public class Traders
    {

        public int TraderID { get; set; }
        public int TraderCode { get; set; } 
        public string TraderName { get; set; }
        public string TraderRegisterNo { get; set; }
        public decimal TraderCommission { get; set; }
        
    }
}