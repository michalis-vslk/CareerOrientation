using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Services.Description;

namespace CareerOrientation
{
    public class User
    {
        private String username;
        private String password;
        private String email;
        private String gender;
        private String datebirth;
        public String db = "Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "career_base.db;Version=3;";
        public User() { }
        public void profileCreate(String username, String password, String email, String gender, String datebirth){
            SQLiteConnection conn = new SQLiteConnection(db);
            conn.Open();
            SQLiteCommand profileCreatecmd = new SQLiteCommand("Insert into users(username,password,email,birthdate,gender) Values(@username,@password,@email,@birthdate,@gender)", conn);
            profileCreatecmd.Parameters.AddWithValue("@username", username);
            profileCreatecmd.Parameters.AddWithValue("@password", password);
            profileCreatecmd.Parameters.AddWithValue("@email", email);
            profileCreatecmd.Parameters.AddWithValue("@birthdate", datebirth);
            profileCreatecmd.Parameters.AddWithValue("@gender", gender);
            profileCreatecmd.ExecuteNonQuery();
        }

    }

}