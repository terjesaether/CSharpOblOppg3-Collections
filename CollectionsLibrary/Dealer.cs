using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary
{
    public class Dealer : ICustomer
    {
        public Dealer()
        {
            _sales = new List<Sale>();
        }
        public Dealer(Wholesale wholesale)
        {
            _sales = new List<Sale>();
            _wholesale = wholesale;
        }

        private List<Sale> _sales;
        public List<Sale> Sales
        {
            get { return _sales; }
            set { _sales = value; }
        }

        private Wholesale _wholesale;
        public Wholesale Wholesale // En dealer har en Grossist
        {
            get { return _wholesale; }
            set { _wholesale = value; }
        }

        public string Address { get; set; }

        public string City { get; set; }

        public string CompanyName { get; set; }

        public string Contact { get; set; }

        public double CustomerNo { get; set; }

        public string Phone { get; set; }

        public string Zipcode { get; set; }
        public void AddSale(Sale sale)
        {
            sale.DealerName = this.CompanyName; // Navnet på Forhandler er navnet til denne klassen.
            Sales.Add(sale);
        }
        public List<Sale> ListSales()
        {
            return Sales;
        }

        public int NumSales
        {
            get { return Sales.Count; }
        }
    }

}
