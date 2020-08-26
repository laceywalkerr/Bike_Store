using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Store Tester");
            // Make a new store
            BikeStore store = new BikeStore();
            store.Name = "Rose's Bike Store";
            store.Location = "Rose's Garage";
            store.Hours = "5am - 5pm";

            // Add some products to inventory
            Bike aBike = new Bike();
            aBike.Name = "Rose's Thorn 5000";
            aBike.Description = "Every Rose has a thorn";
            aBike.Price = 14.5;

            store.AddBike(aBike);

            // List products available to sell
            store.ListBikes();

            // Sell a product
        }
    }
}