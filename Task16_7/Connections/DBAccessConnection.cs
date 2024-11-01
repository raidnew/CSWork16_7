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
        private OleDbConnection _connection;
        private OleDbDataAdapter _adapter;
        private string _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=db.accdb";

        public DataTable Data { get; private set; }

        public DBAccessConnection() 
        {
            Data = new DataTable();
            _connection = new OleDbConnection(_connectionString);
            InitAdapter();
        }

        public void Save()
        {
            _adapter.Update(Data);
        }

        private void InitAdapter()
        {
            _adapter = new OleDbDataAdapter();
            string query;

            query = "SELECT id, product_id, email, product_name FROM Products";
            _adapter.SelectCommand = new OleDbCommand(query, _connection);

            query = "INSERT INTO Products (id, email, product_id, product_name) " +
                "VALUES(@Id, @email, @product_id, @product_name)";
            _adapter.InsertCommand = new OleDbCommand(query, _connection);

            _adapter.Fill(Data);
        }

    }
}
