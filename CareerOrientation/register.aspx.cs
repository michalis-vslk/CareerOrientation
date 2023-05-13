using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareerOrientation
{
    public partial class register : System.Web.UI.Page
    {
        string gender;
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void cancelBack(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
        protected void makeUser_Click(object sender, EventArgs e)
        {

            bool bol = true;
            string script = "alert(\"There is already an account with that E-mail address\");";
            if (email.Text.Length == 0)//Zero length check
            {
                script = "alert(\"Email Address cannot be blank\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (!email.Text.Contains(".") || !email.Text.Contains("@")) //some other basic checks
            {
                script = "alert(\"Not a valid email address\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (pass.Text != pass2.Text)
            {
                script = "alert(\"Passwords are not identical\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (pass.Text.Length < 6)
            {
                script = "alert(\"Password cannot be less than 6 chars\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            else if (username.Text.Length < 3)
            {
                script = "alert(\"Username cannot be less than 3 chars\");";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
                bol = false;
            }
            
            
            if (bol)
            {
                User u = new User();
                u.profileCreate(username.Text, pass.Text, email.Text, gender, TextBox1.Text);
                Response.Redirect("index.aspx");
            }


        }


        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";

        }

        
    }
}
