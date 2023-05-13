using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareerOrientation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Unnamed1_Click(object sender, EventArgs e)
        {

            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "career_base.db;Version=3;");
            conn.Open();
            String query1 = "Select * from users where username='" + name1.Text + "' and password='" + pwd.Text + "'";
            SQLiteCommand cmd = new SQLiteCommand(query1, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            while (reader.Read())
            {
                builder.Append(reader.GetString(1) + "/").Append(reader.GetString(2));
            }
            conn.Close();
            if (builder.ToString() == "")
            {

                string script = "alert(\"Incorrect username/password\")";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }
            else
            {
                Session["Username"] = name1.Text;
                Session["Type"] = "Client";
                Response.Redirect("clientMainPage.aspx");
            }
            

        }
    }
}