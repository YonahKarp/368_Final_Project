using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClasses {
    public class Classes {
        public class Customer {
            public int Id { get; set; }

            public string name { get; }

            public string username { get; }
            public string password { get; }

            public double balance { get; set; }

            public List<Purchase> purchases = new List<Purchase>();

            public Customer(string name, string username, string password) {
                this.name = name;
                this.username = username;
                this.password = password;
                balance = 0;
            }
        }

        public class Purchase {
            public int Id { get; set; }
            public Item item { get; }
            public int quantity { get; }
            public DateTime date { get; }

            public Purchase(Item item, int quantity) {
                this.item = item;
                this.quantity = quantity;
                date = DateTime.Now;
            }

            public double total() {
                return item.price*quantity;
            }

            public override string ToString() {
                return String.Format(quantity + " " + item.name + "(s):\t{0:C}\t" + date , item.price*quantity);
            }

        }

        public class Item {
            public int Id { get; set; }
            public string name { get; }
            public double price { get; set; }

            public Item(string name, double price) {
                this.name = name;
                this.price = price;
            }

            public override string ToString() {
                return String.Format(name + ":\t {0:C}", price);
            }
        }

    }
}

