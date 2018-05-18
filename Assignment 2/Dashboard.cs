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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
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

            string query = "SELECT id,title,date_added,status FROM bugs";
            IDataReader reader = DBHelper.runSelect(query);
            dataGrid.Rows.Clear();
            while (reader.Read())
            {
                dataGrid.Rows.Add(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2),reader.GetString(3));
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //DataGridViewRow drv = (DataGridViewRow)dataGrid.SelectedRows[0];
            if ( dataGrid.SelectedRows.Count > 0 ) { 
                string val = dataGrid.SelectedRows[0].Cells["id"].Value.ToString();
                MessageBox.Show(val + " ");
            }
        }
    }
}
