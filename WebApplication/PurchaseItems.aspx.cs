using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static DBClasses.Classes;
using DBModel;

namespace WebApplication {
    public partial class PurchaseItems : System.Web.UI.Page {
        Customer user;
        private List<Item> items;

        protected void Page_Load(object sender, EventArgs e) {
            user = (Customer) Application["Customer"];
            nameLbl.Text = user.name;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        protected void searchBtn_Click(object sender, EventArgs e) {
            IEnumerable<Item> list = new List<Item>();

            errorLbl.Text = "";
            thankYouLbl.Text = "";

            double price = 0;
            try {
                if (dDownWhere.SelectedItem != null &&
                    (dDownWhere.SelectedItem.Text == "Price Above" || dDownWhere.SelectedItem.Text == "Price Below"))
                    price = double.Parse(searchTxt.Text + "");

            } catch (Exception ex) {
                errorLbl.Text = "search value needs to be a double to search price";
                return;
            }

            if (dDownWhere.SelectedItem != null && dDownWhere.SelectedItem.Text == ("Price Above")) {

                list = Globals.items.Where(c => c.price >= price).OrderBy(c => c.price);

            } else if (dDownWhere.SelectedItem != null && dDownWhere.SelectedItem.Text == ("Price Below")) {
                list = Globals.items.Where(c => c.price <= double.Parse(searchTxt.Text + "")).OrderBy(c => c.price);

            } else {
                list = Globals.items.Where(c => c.name.Contains(searchTxt.Text));
            }
            nameLbl.Text = list.Count()+"";
            addItems(list);
        }


        private void addItems(IEnumerable<Item> list) {
            
            itemsList.Items.Clear();
            items = new List<Item>();
            foreach (Item item in list) {
                items.Add(item);
                itemsList.Items.Add(item.ToString());
            }
            Application["Items"] = items;
        }
    

        protected void purchaseBtn_Click(object sender, EventArgs e) {
            items = (List<Item>) Application["Items"];
            if (itemsList.SelectedItem != null) {
                Item item = items.ElementAt(itemsList.SelectedIndex);
                int quant = int.Parse(quantTxt.Text);
                double cost = item.price * quant;

                user.purchases.Add(new Purchase(item, quant));
                user.balance += cost;

                thankYouLbl.Text = String.Format("Thank you! a charge of {0:C} was added to your account", cost);
            }

        }
    }
}