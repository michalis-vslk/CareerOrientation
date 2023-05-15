using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CareerOrientation
{
    public partial class kef1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void test1(object sender, EventArgs e)
        {
            Session["Test"] = "test1";
            Response.Redirect("test.aspx");
        }
    }
}