using System.Net.Http.Headers;

namespace MoreLinq
{
    public class App
    {
        public void Run()
        {
            var annons = new
            {
                EndDate = DateTime.Now.AddDays(30),
                Seller = "Stefan Holmberg",
                Title = "Playstation 5",
                Description = "Nästan oanvänd",
                Price = 5500
            };

            var annons2 = new
            {
                EndDate = DateTime.Now.AddDays(30),
                Seller = "Stefan Holmberg",
                Title = "Playstation 5",
                Description = "Nästan oanvänd",
                Price = 5500,
                Bids = new[]
                {
                    new { Name = "Kalle", Datum = "2022-11-05", Summa = 2100 },
                    new { Name = "Lisa", Datum = "2022-11-06", Summa = 2200 },
                }.ToList()

            };

            foreach (var item in annons2.Bids)
            {
                Console.WriteLine(item);
            }


            string sentence = "Hej PÅ dig HALLÅ";

            var words = sentence.Split(' ').Where(x => x == x.ToUpper());

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            foreach (var item in cities.OrderBy(x => x.Length).ThenBy(x => x))
            {
                Console.WriteLine(item);
            }


            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman ppp", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            foreach (var item in customers.Select(x => new {Lastname = x.Name.Split(' ')[^1], NearlyMillionaire = 1000000-x.Balance}))
            {
                Console.WriteLine(item);
            }

        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }
}
