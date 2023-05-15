using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace CareerOrientation
{
    public partial class Test : System.Web.UI.Page
    {
        private SQLiteConnection conn;
        private SQLiteDataReader reader;
        private int currentQuestionIndex;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Open the SQLite database connection
                conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "career_base.db;Version=3;");
                conn.Open();

                // Load the first question
                currentQuestionIndex = 1;
                LoadQuestion(currentQuestionIndex);
            }
        }
        protected void LoadQuestion(int questionIndex)
        {
            conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "career_base.db;Version=3;");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM tests", conn);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                lblQuestion.Text = reader.GetString(2);
                rbOptions.Items.Clear();
                rbOptions.Items.Add(reader.GetString(3));
                rbOptions.Items.Add(reader.GetString(4));
                rbOptions.Items.Add(reader.GetString(5));
                rbOptions.Items.Add(reader.GetString(6));
            }

            reader.Close();
            conn.Close();
        }
        protected void GetCorrectAnswerIndex(int questionIndex)
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "career_base.db;Version=3;");
            conn.Open();
            SQLiteCommand cmd2 = new SQLiteCommand("SELECT Correct FROM tests WHERE id ='" + questionIndex + "'", conn);
            SQLiteDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read()) { 
                  Label1.Text="the correct answer is"+ reader2.GetString(1);
            }
            conn.Close();

        }
        protected void btnNext_Click(object sender, EventArgs e)
        {
            // Check the selected answer
            int selectedAnswerIndex = rbOptions.SelectedIndex;
            GetCorrectAnswerIndex(currentQuestionIndex);

            /*if (selectedAnswerIndex == correctAnswerIndex)
            {
                // Correct answer
                // You can add your desired logic here
            }*/
            

            // Move to the next question
            currentQuestionIndex++;

            if (currentQuestionIndex < GetTotalQuestionsCount())
            {
                LoadQuestion(currentQuestionIndex);
            }
            else
            {
                // Test finished
                // You can add your desired logic here
            }
        }

        protected int GetTotalQuestionsCount()
        {
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "career_base.db;Version=3;");
            conn.Open();
            SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM tests", conn);
            int totalQuestionsCount = Convert.ToInt32(cmd.ExecuteScalar());
            string script2 = "alert(\" "+totalQuestionsCount+"\")";
            ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
            conn.Close();
            return totalQuestionsCount;
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // Close the SQLite database connection
            if (conn != null && conn.State != System.Data.ConnectionState.Closed)
            {
                string script2 = "alert(\" gamiesai\")";
                ScriptManager.RegisterStartupScript(this, GetType(), "ServerControlScript", script2, true);
                conn.Close();
            }
        }

    }
}