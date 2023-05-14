using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareerOrientation
{
    public partial class MainPage : System.Web.UI.Page
    {
        private String user;
        protected void Page_Load(object sender, EventArgs e)
        {
            user = Session["Username"].ToString();
            Label1.Text = "Welcome" + " " + user;
        }

        protected void kef1_click(object sender,EventArgs e)
        {
            Response.Redirect("kef1.aspx");
        }
    }
}