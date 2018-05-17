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
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user     = loginUsername.Text.ToString();
            string password = loginPassword.Text.ToString();

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "ase_bug_tracking";

            if (dbCon.IsConnect())
            {
                string query = "SELECT username,password FROM users where username='" + user + "' and password='" + password + "'" ;
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    string dbUsername = reader.GetString(0);
                    string dbPassword = reader.GetString(1);
                    
                    if( !String.IsNullOrEmpty(dbUsername) && !String.IsNullOrEmpty(dbPassword) )
                    {
                        // User exists
                        this.Hide();
                        Dashboard dash = new Dashboard();
                        dash.Show();
                    } else
                    {
                        // User doesn't exist


                    }

                }
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
            string firstName = registerFirstName.Text.ToString();
            string lastName = registerLastName.Text.ToString();
            string username = registerUsername.Text.ToString();
            string password = registerPassword.Text.ToString();
            string role = null;
            string timestamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            try {
                role = comboRole.Items[comboRole.SelectedIndex].ToString();
            } catch (Exception) { };

            string query = "INSERT INTO users(first_name, last_name, username, password, date_created) values('"+firstName+"','"+lastName+"','"+username+"','"+password+"','"+timestamp+"')";
            //string query = "SELECT * FROM users WHERE id = 1";
            
            if ( DBHelper.runInsert(query) >= 0 )
            {
                MessageBox.Show("User " + username + " created. You can login now!");
            } else
            {
                MessageBox.Show("There was an error creating the user.");
            }
            
        }
    }
}
