using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connections;

public class DBSQLConnection
{
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CSTask16_7;Integrated Security=True";
    private SqlDataAdapter _adapter;
    private SqlConnection _connection;

    public DataTable Data
    {
        get; private set;
    }

    public DBSQLConnection()
    {
        _connection = new SqlConnection(connectionString);
        Data = new DataTable();
        InitAdapter();
    }

    private void InitAdapter()
    {
        _adapter = new SqlDataAdapter();

        string sql = "";

        sql = "SELECT * FROM Customers";
        _adapter.SelectCommand = new SqlCommand(sql, _connection);


        sql = @"INSERT INTO Customers (Id, LastName, FirstName, ThirdName, Phone, Email) 
                VALUES (@id, @LastName, @FirstName, @ThirdName, @Phone, @Email)";
        _adapter.InsertCommand = new SqlCommand(sql, _connection);
        _adapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");
        _adapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 10, "LastName");
        _adapter.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 10, "FirstName");
        _adapter.InsertCommand.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 10, "ThirdName");
        _adapter.InsertCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 10, "Phone");
        _adapter.InsertCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 10, "Email");

        sql = @"INSERT INTO Customers (Id, LastName, FirstName, ThirdName, Phone, Email) 
                VALUES (@id, @LastName, @FirstName, @ThirdName, @Phone, @Email)";
        _adapter.UpdateCommand = new SqlCommand(sql, _connection);
        _adapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");
        _adapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 10, "LastName");
        _adapter.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 10, "FirstName");
        _adapter.InsertCommand.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 10, "ThirdName");
        _adapter.InsertCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 10, "Phone");
        _adapter.InsertCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 10, "Email");

        sql = @"INSERT INTO Customers (Id, LastName, FirstName, ThirdName, Phone, Email) 
                VALUES (@id, @LastName, @FirstName, @ThirdName, @Phone, @Email)";
        _adapter.DeleteCommand = new SqlCommand(sql, _connection);
        _adapter.InsertCommand.Parameters.Add("@id", SqlDbType.Int, 4, "id");
        _adapter.InsertCommand.Parameters.Add("@LastName", SqlDbType.NVarChar, 10, "LastName");
        _adapter.InsertCommand.Parameters.Add("@FirstName", SqlDbType.NVarChar, 10, "FirstName");
        _adapter.InsertCommand.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 10, "ThirdName");
        _adapter.InsertCommand.Parameters.Add("@Phone", SqlDbType.NVarChar, 10, "Phone");
        _adapter.InsertCommand.Parameters.Add("@Email", SqlDbType.NVarChar, 10, "Email");


        _adapter.Fill(Data);
    }


}
