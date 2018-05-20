using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Assignment_2
{
    public class DBConnection
    {
        private DBConnection()
        {
        }

        /// <summary>
        /// Get and Set property of the variables
        /// </summary>
        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        /// <summary>
        /// Create a new instance and return it to the caller.
        /// </summary>
        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            
            _instance = new DBConnection();
            return _instance;
        }
        
        /// <summary>
        /// Connects to the database if the connection is not null
        /// </summary>
        /// <returns></returns>
        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
                string connstring = string.Format("Server=localhost; database={0}; UID=root; password=", databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open();
            }

            return true;
        }
        
        /// <summary>
        /// Closes the connection
        /// </summary>
        public void Close()
        {
            connection.Close();
        }
    }
}
