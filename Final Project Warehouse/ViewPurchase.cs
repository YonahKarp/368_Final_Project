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

namespace Final_Project_Warehouse {
    public partial class ViewPurchase : Form {
        Customer user;
        

        public ViewPurchase(Customer user) {
            InitializeComponent();
            this.user = user;
            menuDropDown.Width = 20;

            addPurchases(user.purchases);
        }

        private void menuDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            var selection = menuDropDown.SelectedItem;

            if (selection != null) {
                if (selection.Equals("Log Out")) {
                    this.Hide();
                    new LoginForm().Show();
                } else if (selection.Equals("Purchase Items")) {
                    this.Hide();
                    new MainForm(user).Show();
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

        private void filterByDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            var selection = filterByDropDown.SelectedItem;

            fromTxt.Clear();
            toTxt.Clear();

            if (selection == null) {
                fromTxt.Mask = "";
                toTxt.Mask = "";
            }
            else if (selection.Equals("Price")) {
                fromTxt.Mask = "0000.00";
                toTxt.Mask = "0000.00";
            } else if (selection.Equals("Date")) {
                fromTxt.Mask = "00/00/0000";
                toTxt.Mask = "00/00/0000";
            }
        }

        private void filterBtn_Click(object sender, EventArgs e) {
            var selection = filterByDropDown.SelectedItem;
            var purchases = new List<Purchase>();

            if (selection == null) {
                addPurchases(user.purchases);
                return;
            }
            if (selection.Equals("Price")) {
                double from;
                double to;
                double.TryParse(fromTxt.Text, out from);
                double.TryParse(toTxt.Text, out to);

                purchases = user.purchases.Where(p => p.total() >= from && p.total() <= to).ToList();
            } else if (selection.Equals("Date")) {
                DateTime from;
                DateTime.TryParse(fromTxt.Text, out from);
                DateTime to;
                DateTime.TryParse(toTxt.Text, out to);

                purchases = user.purchases.Where(p => p.date >= from && p.date <= to).ToList();
            }

            addPurchases(purchases);

        }

        private  void addPurchases(IEnumerable<Purchase> purchases) {
            purchasesList.Items.Clear();
            purchasesList.BeginUpdate();
            foreach (Purchase purchase in purchases) {
                purchasesList.Items.Add(purchase);
            }
            purchasesList.EndUpdate();
        }
    }
}
