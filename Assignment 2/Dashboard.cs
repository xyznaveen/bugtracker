using FastColoredTextBoxNS;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Dashboard : Form
    {
        public static int userId = -1;
        private int currentbugId = -1;

        public static string userType = null;

        public Dashboard()
        {
            InitializeComponent();

            comboTesterSeverity.Items.Add("Critical");
            comboTesterSeverity.Items.Add("High");
            comboTesterSeverity.Items.Add("Medium");
            comboTesterSeverity.Items.Add("Low");
            
            string queryRole = "SELECT type FROM users u, roles r, roles_users ru WHERE u.id = ru.user_id AND r.id = ru.role_id AND u.id = " + userId;
            IDataReader reader = DBHelper.runSelect(queryRole);
            
            while(reader.Read())
            {
                userType = reader.GetString(0);
            }

            this.Text = "Dashboard :: " + userType;

            // To show the tabs based on user role
            if( userType != null )
            {
                switch(userType)
                {
                    // If the user is admin hide all tabs that are not related
                    // same is followed below. All unnecessary tabs are hidden for the user.
                    case "admin":
                        {
                            rootTab.TabPages.Remove(tabAddBug);
                            rootTab.TabPages.Remove(tabDeveloper);
                            rootTab.TabPages.Remove(tabTester);
                            rootTab.TabPages.Remove(tabBugsList);
                            rootTab.TabPages.Remove(tabUpdateBug);
                            break;
                        }
                    case "developer":
                        {
                            rootTab.TabPages.Remove(tabAdmin);
                            rootTab.TabPages.Remove(tabTester);
                            rootTab.TabPages.Remove(tabAddBug);
                            rootTab.TabPages.Remove(tabAddUser);
                            break;
                        }
                    case "tester":
                        {
                            rootTab.TabPages.Remove(tabDeveloper);
                            rootTab.TabPages.Remove(tabAdmin);
                            rootTab.TabPages.Remove(tabAddUser);
                            rootTab.TabPages.Remove(tabBugsList);
                            rootTab.TabPages.Remove(tabUpdateBug);
                            break;
                        }
                    default:
                        break;
                }
            }

        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is a simple Bug Tracking application.\n\nIt helps developer and testers keep track of all the bugs and their fix status.");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            string query = "SELECT id,title,date_added,status FROM bugs WHERE assigned_to="+Dashboard.userId;
            IDataReader reader = DBHelper.runSelect(query);
            dataGrid.Rows.Clear();
            while (reader.Read())
            {
                dataGrid.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2),reader.GetString(3));
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if ( dataGrid.SelectedRows.Count > 0 ) { 
                string val = dataGrid.SelectedRows[0].Cells["id"].Value.ToString();
                int.TryParse(val, out currentbugId);
                rootTab.SelectedTab = tabUpdateBug;
            }
        }

        private void tabOne_Selected(object sender, TabControlEventArgs e)
        {
            fetchFromTableUsers();
        }

        private void fetchFromTableUsers()
        {
            // Clear the current table
            adminUsersList.Rows.Clear();

            string query = "SELECT u.id,u.first_name,u.last_name,u.username,u.date_created,r.type FROM users u, roles r, roles_users ru WHERE ru.user_id = u.id AND ru.role_id = r.id";

            IDataReader reader = DBHelper.runSelect(query);

            while (reader.Read())
            {
                adminUsersList.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5));
            }
        }

        /// <summary>
        /// Fetches the information again from database every time the user refreshes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminRefreshList_Click(object sender, EventArgs e)
        {
            fetchFromTableUsers();
        }

        /// <summary>
        /// Remove the user from the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminDisableUser_Click(object sender, EventArgs e)
        {
            int selectedUser = -1;

            if (adminUsersList.SelectedRows.Count > 0)
            {
                string val = adminUsersList.SelectedRows[0].Cells["uid"].Value.ToString();
                int.TryParse(val, out selectedUser);

                string query = "DELETE FROM users WHERE id=" + selectedUser;
                DBHelper.runInsert(query);
            }

            fetchFromTableUsers();
        }

        /// <summary>
        /// Event fired when the user tries to edit the information clicking the edit details button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adminEditDetails_Click(object sender, EventArgs e)
        {
            int selectedUser = -1;
            
            if (adminUsersList.SelectedRows.Count > 0)
            {
                string val = adminUsersList.SelectedRows[0].Cells["uid"].Value.ToString();
                int.TryParse(val, out selectedUser);

                UpdateUserDetails uud = new UpdateUserDetails(selectedUser);
                if (uud.ShowDialog() == DialogResult.OK)
                {
                    fetchFromTableUsers();
                }
            }
            
        }

        /// <summary>
        /// Helps to change the password of current user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Prepare new instance of the form
            ChangePassword cp = new ChangePassword();

            // If password update was successful
            if( cp.ShowDialog() == DialogResult.OK )
            {
                MessageBox.Show("Password updated.");
            }

        }

        private void linkGeneraeUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Prepare random string 
            Random rn = new Random();
            int id = rn.Next(999);
            // Assing it to the user tab
            textUsername.Text = RandomString(3).ToLower() + id;
        }

        /// <summary>
        /// Returns new random string based on specified length
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789_#-";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void linkGeneratePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Generate random password and assign it to the textbox
            string pass = RandomString(8);
            textPassword.Text = pass;
            textRePassword.Text = pass;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {

            // Declaring variables
            string strFirstName, strLastName, strAddress, strNumber, strEmail, strUsername, strPassword, strRePassword, strCombo = null;
            
            strFirstName    = textFirstName.Text;
            strLastName     = textLastName.Text;
            strAddress      = textAddress.Text;
            strNumber       = textNumber.Text;
            strEmail        = textEmail.Text;
            strUsername     = textUsername.Text;
            strPassword     = textPassword.Text;
            strRePassword   = textRePassword.Text;
            strCombo        = addUserComboType.Text;

            bool isNotEmpty = !(String.IsNullOrEmpty(strFirstName) && String.IsNullOrEmpty(strLastName) && String.IsNullOrEmpty(strAddress) && String.IsNullOrEmpty(strNumber) && String.IsNullOrEmpty(strEmail) && String.IsNullOrEmpty(strUsername) && String.IsNullOrEmpty(strPassword) && String.IsNullOrEmpty(strRePassword) && String.IsNullOrEmpty(strCombo));

            // All files are filled
            if( isNotEmpty )
            {
                string query = "INSERT INTO users(first_name,last_name,username,password) VALUES('"+strFirstName+"','"+strLastName+"','"+strUsername+"','"+strPassword+"')";
                int queryResult = DBHelper.runInsert(query);
                
                // If query was executed successfully
                if(queryResult == 1)
                {
                    // Get last inserted user ID
                    string lastUser = "SELECT id FROM users WHERE username='"+strUsername+"'";
                    int lUid = -1;
                    IDataReader uiReader = DBHelper.runSelect(lastUser);
                    while(uiReader.Read())
                    {
                        lUid = uiReader.GetInt32(0);
                    }

                    // Get selected user type ID
                    string selectedType = "SELECT id FROM roles WHERE type='" + strCombo + "'";
                    int tId = -1;
                    IDataReader tReader = DBHelper.runSelect(selectedType);
                    while (tReader.Read())
                    {
                        tId = tReader.GetInt32(0);
                    }

                    // Assign the role to the user
                    string mapQuery = "INSERT INTO roles_users(user_id,role_id) VALUES(" + lUid + "," + tId + ")";
                    DBHelper.runInsert(mapQuery);
                }

                ClearTextBoxes();
            }

        }

        private void rootTab_Enter(object sender, EventArgs e)
        {
            fetchFromTableUsers();
        }

        private void tabAddUser_Enter(object sender, EventArgs e)
        {
            // When the user focuses the tab prepare list of users to be assigned
            string query = "SELECT type FROM roles WHERE 1";
            IDataReader reader = DBHelper.runSelect(query);
            addUserComboType.Items.Clear();
            while (reader.Read())
            {
                addUserComboType.Items.Add(reader.GetString(0));
            }
        }

        private void tabUpdateBug_Enter(object sender, EventArgs e)
        {
            string fetchQuery = "SELECT * FROM bugs b, users u WHERE b.id=" + currentbugId + " AND b.assigned_by = u.id ";
            IDataReader fetchReader = DBHelper.runSelect(fetchQuery);
            
            // Clear current list of vales in the combo box
            comboUpdateBugs.Items.Clear();
            comboUpdateBugs.Items.Add("notfixed");
            comboUpdateBugs.Items.Add("fixed");

            // Loop until the data is found
            while ( fetchReader.Read() )
            {
                textBugTitle.Text = fetchReader.GetString(4);
                textSummary.Text = fetchReader.GetString(5);
                textMethodName.Text = fetchReader.GetString(8);
                textClassName.Text = fetchReader.GetString(9);
                textFoundBy.Text = fetchReader.GetString(15);
                textFoundOn.Text = fetchReader.GetDateTime(7).ToString();
                textLineStart.Text = fetchReader.GetInt32(11).ToString();
                textLineEnd.Text = fetchReader.GetInt32(12).ToString();
            }

            // Fetch the source code the table where it is stored
            string fcQuery = "SELECT src FROM vcs WHERE parent_id=" + currentbugId;
            IDataReader idr = DBHelper.runSelect(fcQuery);
            while (idr.Read()) {
                editor.Text = idr.GetString(0);
            }
        }

        /// <summary>
        /// Clears all the controls which have text in them.
        /// TO automatically empty all the fields after an action is performed.
        /// </summary>
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                else if (control is FastColoredTextBox)
                    (control as FastColoredTextBox).Clear();
                else
                    func(control.Controls);
            };

            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Declaring the variables
            int startLine, endLine = -1;
            string strClassName, strMethodName, strFoundBy, strTitle, strSummary, strSeverity, strSourceCode, strUrl = null;

            string strFoundOn = dateTesterFoundOn.Text.ToString();
            strClassName = textTesterClassName.Text;
            strMethodName = textTesterMethodName.Text;
            strFoundBy = comboAssignedTo.Text;
            strTitle = textTesterTitle.Text;
            strSeverity = comboTesterSeverity.Text;
            strSourceCode = editorSrc.Text;
            strSummary = textTesterSummary.Text;
            strUrl = textUrl.Text;
            int.TryParse(textTesterStartLine.Text, out startLine);
            int.TryParse(textTesterEndLine.Text, out endLine);

            int auid = -1;
            string userQuery = "SELECT id FROM users WHERE username='"+comboAssignedTo.Text+"'";
            IDataReader ureader = DBHelper.runSelect(userQuery);
            while (ureader.Read())
            {
                // Select primary key from user and assign it to auid
                auid = ureader.GetInt32(0);
            }
                        
            string query = "INSERT INTO bugs(status,assigned_to,assigned_by,title,description,method,class,severity,start_line,end_line,url) "+
                "VALUES('notfixed',"+ auid + ","+ userId + ",'"+strTitle+"','"+strSummary+"','"+strMethodName+"','"+strClassName+"','"+comboTesterSeverity.Text+"',"+startLine+","+endLine+",'"+strUrl+"')";
            DBHelper.runInsert(query);

            string getLastIdquery = "SELECT id FROM bugs WHERE title='" + strTitle + "' AND assigned_to=" + userId;
            IDataReader lidReader = DBHelper.runSelect(getLastIdquery);
            int lid = -1;
            while(lidReader.Read())
            {
                lid = lidReader.GetInt32(0);
            }

            // Escape single quotes from the code  string which might cause problems when inserting code in SQL statement
            string sanitized = editorSrc.Text.Replace("'", "\\'");

            // Prepare the query and insert into the database
            string codeQuery = "INSERT INTO vcs(src,modified_by,parent_id) VALUES('" + sanitized + "'," + userId + ","+lid+")";
            int sts = DBHelper.runInsert(codeQuery);

            if(sts == 1)
            {
                // Clear all  fields if the insertion was a success
                ClearTextBoxes();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            string updateBugQuery = "UPDATE bugs SET status='" + comboUpdateBugs.Text + "' WHERE id=" + currentbugId;
            int result = DBHelper.runInsert(updateBugQuery);
            if(result ==1)
            {
                MessageBox.Show("Update success.");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabAddBug_Enter(object sender, EventArgs e)
        {
            // Fetch all the username from the database and show it in the combobox
            string query = "SELECT username FROM users WHERE 1";
            IDataReader reader = DBHelper.runSelect(query);

            comboAssignedTo.Items.Clear();

            while (reader.Read())
            {
                // Populate the combobox
                comboAssignedTo.Items.Add(reader.GetString(0));
            }
        }

        private void cToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.SQL;
        }


        /// <summary>
        /// Change the syntax highlighter programming language
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void cToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.VB;
        }

        private void javaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void pHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.PHP;
        }

        private void javascriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.Language = FastColoredTextBoxNS.Language.XML;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            editorSrc.Language = FastColoredTextBoxNS.Language.CSharp;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            editorSrc.Language = FastColoredTextBoxNS.Language.SQL;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            editorSrc.Language = FastColoredTextBoxNS.Language.JS;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            editorSrc.Language = FastColoredTextBoxNS.Language.PHP;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            editorSrc.Language = FastColoredTextBoxNS.Language.VB;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            editorSrc.Language = FastColoredTextBoxNS.Language.XML;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
