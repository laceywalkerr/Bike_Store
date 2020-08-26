namespace System;
namespace System.Collections.Generic;
{
    public class BikeStore
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public string Hours { get; set; }

        public Dictionary<string, Bike> Inventory { get; set; }

        // Constructor
        public BikeStore()
        {
            Inventory = new Dictionary<string, Bike>();
        }

        public void AddBike(Bike aBike)
        {
            Inventory.Add(aBike.Name, aBike);
        }

        public void ListBikes()
        {
            foreach (KeyValuePair<string, Bike> item in Inventory)
            {
                Console.WriteLine($"{item.Value.Name}: $item.Value.Price}");
            }
        }
    }
}