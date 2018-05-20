using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Welcome :: Bug Tracking System";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            string user     = loginUsername.Text.ToString();
            string password = loginPassword.Text.ToString();

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "ase_bug_tracking";

            if (dbCon.IsConnect())
            {
                string query = "SELECT id,username,password FROM users where username='" + user + "' and password='" + password + "'" ;
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                bool userExists = false;
                while (reader.Read())
                {
                    string dbUsername = reader.GetString(1);
                    string dbPassword = reader.GetString(2);
                    
                    if( !String.IsNullOrEmpty(dbUsername) && !String.IsNullOrEmpty(dbPassword) )
                    {
                        userExists = !userExists;

                        // Get user_id for later usage
                        Dashboard.userId = reader.GetInt32(0);

                        // User exists
                        this.Hide();
                        Dashboard dash = new Dashboard();
                        dash.Show();
                    }

                }
                
                if(!userExists)
                    MessageBox.Show("username / password doesn't match.");

                dbCon.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Register formRegister = new Register();
            formRegister.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
