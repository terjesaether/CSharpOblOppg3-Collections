using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CollectionsLibrary;
using CSharpOblOppg3_Collections.Models;

namespace CSharpOblOppg3_Collections.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var init = new InitProgram();
            var viewModel = new CdSalesViewModel();

            Wholesale wholesale1 = init.MakeWholesalers()[0];
            Wholesale wholesale2 = init.MakeWholesalers()[1];
            Wholesale wholesale3 = init.MakeWholesalers()[2];
            Wholesale wholesale4 = init.MakeWholesalers()[3];

            var dealer1 = init.MakeDealers()[0];
            var dealer2 = init.MakeDealers()[1];
            var dealer3 = init.MakeDealers()[2];
            var dealer4 = init.MakeDealers()[3];
            var dealer5 = init.MakeDealers()[4];
            var dealer6 = init.MakeDealers()[5];

            dealer1.Wholesale = wholesale1;
            dealer2.Wholesale = wholesale1;

            wholesale1.Dealers = new List<Dealer>
            {
                dealer1,
                dealer2
            };

            wholesale2.Dealers = new List<Dealer>
            {
                dealer4,
                dealer3
            };

            wholesale3.Dealers = new List<Dealer>
            {
                dealer5,
                dealer6

            };

            var cd1 = init.MakeCds()[0];
            var cd2 = init.MakeCds()[1];
            var cd3 = init.MakeCds()[2];

            var sale1 = new Sale
            {
                CustomerName = "Per Hansen",
                Price = 50,
                Cd = cd1
            };

            var sale2 = new Sale
            {
                CustomerName = "Kåre Nilsen",
                Price = 90,
                Cd = cd2
            };

            var sale3 = new Sale
            {
                CustomerName = "Nils Nilsen",
                Price = 150,
                Cd = cd3
            };

            dealer1.AddSale(sale1);
            dealer1.AddSale(sale2);
            dealer1.AddSale(sale3);

            viewModel.Dealers.Add(dealer1);

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}