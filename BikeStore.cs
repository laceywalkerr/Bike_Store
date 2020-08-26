namespace System;
namespace System.Collections.Generic;
{
    public class BikeStore
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public string Hours { get; set; }

        private Dictionary<string, Bike> Inventory { get; set; }
        private List<Sale> SalesHistory { get; set; }

        // Constructor
        public BikeStore()
        {
            Inventory = new Dictionary<string, Bike>();
            SalesHistory = new List<Sale>();
        }

        public void AddBike(Bike aBike)
        {
            Inventory.Add(aBike.Name, aBike);
        }

        public void ListBikes()
        {
            foreach (KeyValuePair<string, Bike> item in Inventory)
            {
                Console.WriteLine($"{item.Value.Name}: ${item.Value.Price}");
            }
        }

        public void SellBike(string name)
        {
            BikeStore aBike = Inventory[name];

            Sale aSale = new Sale();
            aSale.SaleDate = DateTime.Now;
            aSale.SalePrice = aBike.Price;
            aSale.BikeName = aBike.Name;

            SalesHistory.Add(aSale);
            Inventory.Remove(name);

        }

        public void PrintSalesReport()
        {
            foreach (Sale aSale in SalesHistory)
                Console.WriteLine($"{aSale.SaleDate} {aSale.BikeName}, {aSale.SalePrice}");
        }
    }
}