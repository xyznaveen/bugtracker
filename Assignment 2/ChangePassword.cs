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
    public partial class ChangePassword : Form
    {
        private string fetchQuery;

        public ChangePassword()
        {
            InitializeComponent();
            this.OK.DialogResult = DialogResult.OK;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            this.fetchQuery = "SELECT password FROM users WHERE id = " + Dashboard.userId;

            string oldPassword = null;

            IDataReader pReader = DBHelper.runSelect(this.fetchQuery);

            // Read password from the dataset and store it
            while (pReader.Read())
            {
                oldPassword = pReader.GetString(0);
            }

            if(  oldPassword != txtOldPassword.Text )
            {
                MessageBox.Show("Old password do not match.");
            } else
            {
                // Entered old password is as same as database's password
                if ( txtNewPassword.Text == txtNewPassword1.Text )
                {
                    // New password and Confirmation password matches
                    string query = "UPDATE users SET password='" + txtNewPassword.Text
                        + "' WHERE id=" + Dashboard.userId;
                    int result = DBHelper.runInsert(query);
                    
                }
            }

        }
    }
}
