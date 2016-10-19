using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollectionsLibrary;

namespace CSharpOblOppg3_Collections.Models
{
    public class CdSalesViewModel
    {
        public CdSalesViewModel()
        {
            Wholesales = new List<Wholesale>();
            Sales = new List<Sale>();
            Dealers = new List<Dealer>();
        }

        public List<Wholesale> Wholesales { get; set; }
        public List<Sale> Sales { get; set; }
        //public Dealer Dealers { get; set; }
        public List<Dealer> Dealers { get; set; }


    }
}