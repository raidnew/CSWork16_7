using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSWork16_7.Connections
{
    public class DBAccessConnection
    {
        public DBAccessConnection() 
        {
            Connect();
        }

        private void Connect()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db11.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception e)
                {
                    Trace.WriteLine(e.Message);
                }
            }
        }
    }
}
