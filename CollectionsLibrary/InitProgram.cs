using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsLibrary
{
    public class InitProgram
    {
        public List<Wholesale> MakeWholesalers()
        {
            var wholesalers = new List<Wholesale>();

            var wholesale1 = new Wholesale
            {
                CustomerNo = 89,
                CompanyName = "CdGrossisten",
                Address = "Persveien 2",
                City = "Oslo",
                Zipcode = "7890",
                Contact = "Ola",
                Phone = "89898787",
                District = "Vest"
            };

            var wholesale2 = new Wholesale
            {
                CustomerNo = 89,
                CompanyName = "CdStorselgern",
                Address = "Persveien 2b",
                City = "Oslo",
                Zipcode = "7891",
                Contact = "Per",
                Phone = "89898787",
                District = "Sør"
            };


            var wholesale3 = new Wholesale();
            var wholesale4 = new Wholesale();

            wholesalers.Add(wholesale1);
            wholesalers.Add(wholesale2);
            wholesalers.Add(wholesale3);
            wholesalers.Add(wholesale4);

            return wholesalers;
        }

        public List<Dealer> MakeDealers()
        {
            var dealers = new List<Dealer>();

            var dealer1 = new Dealer()
            {
                CompanyName = "Free Record Shop",
            };

            var dealer2 = new Dealer()
            {
                CompanyName = "Platekompaniet",
            };

            var dealer3 = new Dealer()
            {
                CompanyName = "Hjørnet Cd",
            };
            var dealer4 = new Dealer()
            {
                CompanyName = "Cdsjappa",
            };
            var dealer5 = new Dealer()
            {
                CompanyName = "Cdsjappa1",
            };
            var dealer6 = new Dealer()
            {
                CompanyName = "CdButikken",
            };

            dealers.Add(dealer1);
            dealers.Add(dealer2);
            dealers.Add(dealer3);
            dealers.Add(dealer4);
            dealers.Add(dealer5);
            dealers.Add(dealer6);

            return dealers;
        }

        public List<CompactDisk> MakeCds()
        {
            var cds = new List<CompactDisk>();

            var cd1 = new CompactDisk
            {
                AlbumName = "And Justice For All",
                GroupOrArtist = "Metallica"
            };

            var cd2 = new CompactDisk
            {
                AlbumName = "Grevling i Taket",
                GroupOrArtist = "Knutsen og Ludviksen"
            };

            var cd3 = new CompactDisk
            {
                AlbumName = "Neste Sommer",
                GroupOrArtist = "DeLillos"
            };

            cds.Add(cd1);
            cds.Add(cd2);
            cds.Add(cd3);

            return cds;
        }

    }
}
