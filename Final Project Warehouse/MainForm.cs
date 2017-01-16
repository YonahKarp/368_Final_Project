using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DBClasses.Classes;
using  DBModel;

namespace Final_Project_Warehouse {
    public partial class MainForm : Form {
        Customer user;
        private List<Item> items = new List<Item>();

        public MainForm() {
            InitializeComponent();   
        }

        public MainForm(Customer user) {
            InitializeComponent();
            this.user = user;
            welcomeLbl.Text = "Welcome " + user.name;
            menuDropDown.Width = 20;
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            IEnumerable<Item> list = new List<Item>();

            errorLbl.Text = "";
            thankYouLbl.Text = "";

            double price = 0;
            try {
                if (dDownWhere.SelectedItem != null && 
                    (dDownWhere.SelectedItem.Equals("Price Above") || dDownWhere.SelectedItem.Equals("Price Below")) )
                         price = double.Parse(txtSearch.Text + "");
                
            } catch (Exception ex) {
                errorLbl.Text = "search value needs to be a double to search price";
                return;
            }

            if (dDownWhere.SelectedItem != null && dDownWhere.SelectedItem.Equals("Price Above")) {
                
                list = Globals.items.Where(c => c.price >= price).OrderBy(c => c.price);
                
            }else if (dDownWhere.SelectedItem != null && dDownWhere.SelectedItem.Equals("Price Below")) {
                list = Globals.items.Where(c => c.price <= double.Parse(txtSearch.Text + "")).OrderBy(c => c.price);
               
            } else {
                list = Globals.items.Where(c => c.name.Contains(txtSearch.Text));
            }

            addItems(list);
        }


        private void addItems(IEnumerable<Item> list) {
            itemsList.BeginUpdate();
            itemsList.Items.Clear();
            items.Clear();
            foreach (Item item in list) {
                items.Add(item);
                itemsList.Items.Add(item);
            }
            itemsList.EndUpdate();
        }

        private void purchaseBtn_Click(object sender, EventArgs e) {
            if (itemsList.SelectedItem != null) {
                Item item = items.ElementAt(itemsList.SelectedIndex);
                int quant = int.Parse(quantTxt.Text);
                double cost = item.price * quant;

                user.purchases.Add(new Purchase(item, quant));
                user.balance += cost;

                thankYouLbl.Text = String.Format("Thank you! a charge of {0:C} was added to your account", cost);
            }
            
        }

        private void menuDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            var selection = menuDropDown.SelectedItem;

            if (selection != null) {
                if (selection.Equals("Log Out")) {
                    this.Hide();
                    new LoginForm().Show();
                }else if (selection.Equals("View Purchases")) {
                    this.Hide();
                    new ViewPurchase(user).Show();
                } else if (selection.Equals("Pay Balance")) {
                    this.Hide();
                    new PayBalance(user).Show();
                }
            }
        }

        private void menuDropDown_DropDown(object sender, EventArgs e) {
            menuDropDown.Width = 100;
        }

        private void menuDropDown_DropDownClosed(object sender, EventArgs e) {
            menuDropDown.Width = 20;
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }
    }

}
