using System;

namespace Store
{
    // NOTE: You will find that the BikeSales.cs file is thoroughly commented. Start there.

    // TODO: Comment this code
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Store Tester");

            // Make a new store
            BikeStore store = new BikeStore();
            store.Name = "Rose's Bike Palace";
            store.Location = "Rose's House";
            store.Hours = "5am - 5pm";

            // Add some products to inventory
            Bike aBike = new Bike();
            aBike.Name = "Rose's Thorn 5000";
            aBike.Description = "Every Rose has (at least) one";
            aBike.Price = 14.5;

            Bike anotherBike = new Bike();
            anotherBike.Name = "Mo Speeder";
            anotherBike.Description = "It's faster than slower bikes";
            anotherBike.Price = 19.25;

            store.AddBike(aBike);
            store.AddBike(anotherBike);

            // List products available to sell
            Console.WriteLine("---All Inventory---");
            store.ListBikes();

            // Sell a product
            store.SellBike("Mo Speeder");

            Console.WriteLine("---After Sale---");
            store.ListBikes();

            store.PrintSalesReport();
        }
    }
}