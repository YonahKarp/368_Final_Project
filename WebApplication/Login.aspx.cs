using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DBModel;
using static DBClasses.Classes;

namespace WebApplication {
    public partial class Login : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            DBModel.hardCodeded.fillLists();

        }

        protected void Button1_Click(object sender, EventArgs e) {
            if (Globals.customers.Any(c => c.username == userTxt.Text && c.password == passTxt.Text)) {
                Customer currCustomer =
                    Globals.customers.First(c => c.username == userTxt.Text && c.password == passTxt.Text);
                Application["Customer"] = currCustomer;
                Response.Redirect("PurchaseItems.aspx");
                //this.Hide();
                //new MainForm(currCustomer).Show();
            } else {
                errorLbl.Visible = true;
            }
        }
    }
}