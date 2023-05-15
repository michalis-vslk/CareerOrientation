using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CareerOrientation
{
    public partial class Test1 : System.Web.UI.Page
    {
        List<RadioButton> checkedButtons;
        protected void Page_Load(object sender, EventArgs e)
        {
            
                checkedButtons = new List<RadioButton>();
                String typeTest = Session["Test"].ToString();
                if (typeTest == "test1")
                {
                    populateTable(typeTest);
                }

            
        }
        private void populateTable(string typeTest)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Random random = new Random();
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "career_base.db;Version=3;");
            conn.Open();
            //container = TestTable;

            for (int i = 1; i < 6; i++)
            {
                int randomIndex = random.Next(list.Count);
                int randomNumber = list[randomIndex];
                String query1 = "Select * from tests where testType='" + typeTest + "'and id='" + randomNumber + "'";
                SQLiteCommand cmd = new SQLiteCommand(query1, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string questionName = "Test 1:" + reader.GetString(2);

                    TableRow row = new TableRow();
                    TableCell cell = new TableCell();
                    cell.Controls.Add(new LiteralControl("<label>" + questionName));
                    row.Cells.Add(cell);
                    TestTable.Rows.Add(row);

                    for (int j = 3; j <= 6; j++)
                    {
                        TableRow answerRow = new TableRow();
                        TableCell answerCell = new TableCell();
                        RadioButton radioButton = new RadioButton();
                        //radioButton.ID = questionName + "r" + (j - 2);
                        radioButton.AutoPostBack=true;
                        radioButton.GroupName = questionName;
                        radioButton.Text = reader.GetString(j);
                        radioButton.CheckedChanged += new EventHandler(this.CheckedChanged);
                        answerCell.Controls.Add(radioButton);
                        answerRow.Cells.Add(answerCell);
                        TestTable.Rows.Add(answerRow);
                        
                    }
                }
                list.RemoveAt(randomIndex);
            }
            conn.Close();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            string script2 = "alert(\" here2\")";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
            RadioButton radioButton = (RadioButton)sender;

            // Clear the previous list of checked buttons
            checkedButtons.Clear();

            // Add the currently checked button to the list
            checkedButtons.Add(radioButton);
        }

        public void submitButton_Click(object sender, EventArgs e)
        {
            
            if (checkedButtons.Count > 0)
            {
                foreach (var radioButton in checkedButtons)
                {
                    string selectedID = radioButton.ID.ToString();
                    string script2 = "alert(\"" + selectedID + "\")";
                    ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                }
            }
            else
            {
                
                //string script = "alert(\"No radio buttons are checked\")";
                //ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script, true);
            }

        }
    }
}