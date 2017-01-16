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
using DBModel;

namespace Final_Project_Warehouse {
    public partial class RegisterForm : Form {
        public RegisterForm() {
            InitializeComponent();
        }

        private void backLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            new LoginForm().Show();
        }

        private void registerBtn_Click(object sender, EventArgs e) {
            bool allValid = true;

            errName.Visible = false;
            errUser.Visible = false;
            errPass.Visible = false;

            if (nameTxt.Text == "") {
                allValid = false;
                errName.Visible = true;
            }
            if (passTxt.Text == "") {
                allValid = false;
                errPass.Visible = true;
            }
            if (userTxt.Text == "") {
                allValid = false;
                errUser.Visible = true;
            }

            if (allValid) {
                Customer newCustomer = new Customer(nameTxt.Text, userTxt.Text, passTxt.Text);

                Globals.customers.Add(newCustomer);

                this.Hide();
                new MainForm(newCustomer).Show();
            }

        }
    }
}
