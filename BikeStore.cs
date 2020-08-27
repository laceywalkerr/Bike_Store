// "using" statements give us access to external libraries
// Specifically for our BikeStore class...
//   "System" gives us access to "DateTime"
//   "System.Collections.Generic" gives us access to "Dictionary" and "List"
using System;
using System.Collections.Generic;

// A "class" should be declared inside a "namespace"
// The same namespace may e used in more than one file
// Each class in this program is in the "Store" namespace
namespace Store
{

    // To declare a class use the "public" and "class" keywords followed by a name for the class
    //  NOTE: it is possible to create "private" classes, but they are less common.
    // Inside the "body" of the class we declare methods and properties
    // A class becomes a new "type" in our application.
    //  For example the class below gives us the power to create a variable of type, "BikeStore"
    // Classes are "instantiated" to form "objects" using the "new" keywords
    //  The class is the blueprint that describes the properties and methods the object will have
    public class BikeStore
    {
        // "Properties" in a class describe the data that can be held inside the object created from the class
        // Properties are like variables. They are "names" that can refer to values.

        // Here are a few "public" "properities".
        // The "{ get; set; }" after the name signifies that this is a property
        // When you declare a property you must specify it's "type"
        public string Name { get; set; }
        public string Location { get; set; }
        public string Hours { get; set; }

        // Here are a couple of "private" properties
        // They can only be accessed within the body of the class

        // A dictionary is a collection of "keys" and "values" (a.k.a KeyValuePairs)
        private Dictionary<string, Bike> Inventory { get; set; }
        private List<Sale> SalesHistory { get; set; }

        // A "constructor" is a special method that is run when a class is instantiated
        //  Meaning when some other code says "new BikeStore()" the BikeStore constructor is executed
        public BikeStore()
        {
            // Here we create "instances" of a dictionary and a list and assign those "values"
            //  to the Inventory and SalesHistory properties
            Inventory = new Dictionary<string, Bike>();
            SalesHistory = new List<Sale>();
        }

        // A public "method" can be called from outside the class and can access either public or private properties and methods
        // This method accepts a "parameter" of type "Bike" and adds it to the private Inventory dictionary
        public void AddBike(Bike aBike)
        {
            Inventory.Add(aBike.Name, aBike);
        }

        // Display all the bikes in our inventory
        public void ListBikes()
        {
            // Iterate over the keys and values that are stored in the Inventory dictionary
            foreach (KeyValuePair<string, Bike> item in Inventory)
            {
                // Each "KeyValuePair" has a "Key" property and a "Value" property
                // Here we use the Value property to access a Bike object
                Console.WriteLine($"{item.Value.Name}: ${item.Value.Price}");
            }
        }

        // Sell a bike with a given "name"
        // The bike's name is passed in as a parameter
        public void SellBike(string name)
        {
            // Use the square bracket notation to get the bike from the dictionary
            Bike aBike = Inventory[name];

            // We want to record the sale of the bike, so we create new "Sale" object and set it's properties
            Sale aSale = new Sale();
            aSale.SaleDate = DateTime.Now;
            aSale.SalePrice = aBike.Price;
            aSale.BikeName = aBike.Name;

            // "Record" the sale, by adding it to our SalesHistory list
            SalesHistory.Add(aSale);

            // We've sold the bike so it's no longer in our inventory
            Inventory.Remove(name);
        }

        // Print a simple report that displays all sales information
        public void PrintSalesReport()
        {
            foreach (Sale aSale in SalesHistory)
            {
                Console.WriteLine($"{aSale.SaleDate} {aSale.BikeName}, {aSale.SalePrice}");
            }
        }
    }
}