using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DBClasses.Classes;

using System.Data.Entity;

namespace DBModel
{
    public class myContext : DbContext {
        public DbSet<Item> items { get; set; }
        public DbSet<Customer> customers {get; set;}
        public DbSet<Purchase> purchases {get; set;}
      
    }

    public class hardCodeded {
        public static void fillLists() {
            Globals.items.Clear();
            Globals.customers.Clear();

            Customer testCust = new Customer("Yoni", "abc", "123");

            Globals.items.Add(new Item("soda", 3.5));
            Globals.items.Add(new Item("chips", 0.5));
            Globals.items.Add(new Item("water", 2.75));
            Globals.items.Add(new Item("hot dogs", 5.25));
            Globals.items.Add(new Item("burger", 7.5));

            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(0), 2));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(0), 5));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(1), 3));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(2), 7));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(2), 5));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(4), 5));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(3), 4));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(3), 3));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(2), 20));
            testCust.purchases.Add(new Purchase(Globals.items.ElementAt(1), 32));





            Globals.customers.Add(testCust);
        }


    }

    public static class Globals {
        public static List<Customer> customers = new List<Customer>();
        public static List<Item> items = new List<Item>();
    }
}
