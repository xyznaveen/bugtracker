using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    /// <summary>
    /// This class performs CRUD operation on the database
    /// </summary>
    class DBHelper
    {

        /// <summary>
        /// Inserts the value into database as specified in the passed query
        /// </summary>
        /// <param name="query">MySQL syntax for insert statement</param>
        /// <returns>int</returns>
        public static int runInsert(string query)
        {
            int result = -1;

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "ase_bug_tracking";

            if (dbCon.IsConnect() && !String.IsNullOrEmpty(query))
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);
                result = cmd.ExecuteNonQuery();
                dbCon.Close();
            }

            return result;
        }

        
        /// <summary>
        /// Retrives the data from the table single or collection.
        /// </summary>
        /// <param name="query">MySQL syntax for select statement</param>
        /// <returns>MySqlDataReader which has the collection of data</returns>
        public static IDataReader runSelect(string query)
        {
            IDataReader result = null;

            var dbCon = DBConnection.Instance();
            dbCon.DatabaseName = "ase_bug_tracking";

            if (dbCon.IsConnect() && !String.IsNullOrEmpty(query))
            {
                var cmd = new MySqlCommand(query, dbCon.Connection);

                var dt = new DataTable();
                dt.Load( cmd.ExecuteReader() );

                result = dt.CreateDataReader();

                dbCon.Close();
            }

            return result;
        }

    }

}
