using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary
{
    public class Wholesale : ICustomer
    {
        public Wholesale()
        {
            _dealers = new List<Dealer>();
            _sales = new List<Sale>();
        }
        private List<Dealer> _dealers;

        public List<Dealer> Dealers
        {
            get { return _dealers; }
            set { _dealers = value; }
        }
        private List<Sale> _sales;

        public List<Sale> Sales
        {
            get { return _sales; }
            set { _sales = value; }
        }
        public string Address { get; set; }

        public string City { get; set; }

        public string CompanyName { get; set; }

        public string Contact { get; set; }

        public double CustomerNo { get; set; }

        public string Phone { get; set; }

        public string Zipcode { get; set; }

        public string District { get; set; }


        public double NoOfDealers
        {
            get
            {
                var allDealers = ListAllDealers();
                return allDealers.Count;
            }

        }

        public List<Dealer> ListAllDealers()
        {
            return Dealers;
        }

        public List<Sale> TotalSales(Sale sale)
        {
            return Sales;
        }
    }
}
