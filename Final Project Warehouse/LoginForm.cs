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
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e) {
            if (Globals.customers.Any(c => c.username == txtUser.Text && c.password == txtPass.Text)) {
                Customer currCustomer =
                    Globals.customers.First(c => c.username == txtUser.Text && c.password == txtPass.Text);
                this.Hide();
                new MainForm(currCustomer).Show();
            }
            else {
                errorLbl.Visible = true;
            }

        }

        private void registerLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            this.Hide();
            new RegisterForm().Show();
        }
    }
}
