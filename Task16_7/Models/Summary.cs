using Connections;
using CSWork16_7.Connections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16.Models;

public class Summary : INotifyPropertyChanged
{
    private DataTable _customersData;
    private DataTable _productsData;

    private DBAccessConnection _productsConnection;
    private DBSQLConnection _customerConnection;

    public Summary()
    {

        _customerConnection = new DBSQLConnection();
        _productsConnection = new DBAccessConnection();

        _customersData = _customerConnection.Data;
        _productsData = _productsConnection.Data;

    }

    public DataTable GetProductData()
    {
        return _productsData;
    }

    public void AddProductEntry(int product_id, string product_name, string email)
    {
        DataRow newRow = _productsData.NewRow();
        newRow["product_id"] = product_id;
        newRow["product_name"] = product_name;
        newRow["email"] = email;
        _productsData.Rows.Add(newRow);
        _productsConnection.Save();
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}
