using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace courseWork
{
    internal class DataBase
    {
        private SqlConnection sqlconnection = new SqlConnection(@"Data Source=DESKTOP-LIVP49H;Initial Catalog=Baza_ua;Integrated Security=True");

        internal void openConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Closed)
            {
                sqlconnection.Open();
            }
        }
        public void closeConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlconnection;
        }


    }
}
