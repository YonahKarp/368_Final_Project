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
    public partial class PayBalance : Form {
        private Customer user;

        public PayBalance(Customer user) {
            InitializeComponent();
            this.user = user;
            menuDropDown.Width = 20;
            balanceLbl.Text = string.Format("{0:C}", user.balance);
        }

        private void menuDropDown_SelectedIndexChanged(object sender, EventArgs e) {
            var selection = menuDropDown.SelectedItem;

            if (selection != null) {
                if (selection.Equals("Log Out")) {
                    this.Hide();
                    new LoginForm().Show();
                }
                else if (selection.Equals("Purchase Items")) {
                    this.Hide();
                    new MainForm(user).Show();
                }
                else if (selection.Equals("View Purchases")) {
                    this.Hide();
                    new ViewPurchase(user).Show();
                }
            }
        }

        private void menuDropDown_DropDown(object sender, EventArgs e) {
            menuDropDown.Width = 100;
        }

        private void menuDropDown_DropDownClosed(object sender, EventArgs e) {
            menuDropDown.Width = 20;
        }

        private void payBtn_Click(object sender, EventArgs e) {
            double payment;
            if (!double.TryParse(paymentTxt.Text, out payment) || payment < 0) {
                msgLbl.Text = "You payment value of " + payment + " is invalid";
                msgLbl.ForeColor = Color.DarkRed;
                return;
            }

            msgLbl.ForeColor = Color.DarkGreen;
            msgLbl.Text = string.Format("Thank You! Your payment of {0:C} was accepted.", payment);
            user.balance -= payment;

            
            balanceLbl.Text = string.Format("{0:C}", user.balance);
        }
    }
}
