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
    public partial class UpdateUserDetails : Form
    {
        private int user = -1;

        public UpdateUserDetails(int selectedUser)
        {
            InitializeComponent();
            this.Text = "Update User Details";

            user = selectedUser;

            this.OK.DialogResult = DialogResult.OK;
            this.CANCEL.DialogResult = DialogResult.Cancel;
            this.FetchUserAndPopulate();

            string query = "SELECT type FROM roles WHERE 1";
            IDataReader reader = DBHelper.runSelect(query);
            while (reader.Read())
            {
                comboRole.Items.Add(reader.GetString(0));
            }
        }
        
        private void FetchUserAndPopulate()
        {
            string query = "SELECT first_name, last_name, type FROM users u, roles r, roles_users ru WHERE u.id = ru.user_id AND r.id = ru.role_id AND u.id = " + user;

            IDataReader reader = DBHelper.runSelect(query);

            while(reader.Read())
            {
                firstName.Text = reader.GetString(0);
                lastName.Text = reader.GetString(1);
                userType.Text = reader.GetString(2);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strFn = firstName.Text;
            string strLn = lastName.Text;

            string query = "UPDATE users SET first_name='" + strFn + "', last_name='" + strLn + "' WHERE id=" + user;
            int result = DBHelper.runInsert(query);
            
            if( result == 1 )
            {
                FetchUserAndPopulate();

                int rqId = -1;
                string roleQuery = "SELECT id FROM roles WHERE type='" + comboRole.Text + "'";
                IDataReader rqReader = DBHelper.runSelect(roleQuery);
                while (rqReader.Read())
                {
                    rqId = rqReader.GetInt32(0);
                }

                MessageBox.Show("Update sttus : " + rqId);

                int mqResult = -1;
                string mapQuery = "UPDATE `roles_users` SET `user_id`=" + user + ",`role_id`=" + rqId + " WHERE `user_id`=" + user;
                // UPDATE `roles_users` SET `user_id`=1,`role_id`=3 WHERE 1
                mqResult = DBHelper.runInsert(mapQuery);
                
            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
