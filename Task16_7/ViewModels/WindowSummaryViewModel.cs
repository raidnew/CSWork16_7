using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Data;
using Task.Common;
using System.Diagnostics;
using Task16.Models;

namespace Task16.ViewModels;


public class WindowSummaryViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private ICommand _clickAdd;
    private ICommand _clickEdit;
    private ICommand _clickDelete;

    public ICommand ClickAdd
    {
        get
        {
            return _clickAdd ?? (_clickAdd = new CommandHandler(() => AddProductEntry(), () => true));
        }
    }

    public ICommand ClickEdit
    {
        get
        {
            return _clickEdit ?? (_clickEdit = new CommandHandler(() => AddProductEntry(), () => true));
        }
    }

    public ICommand ClickDelete
    {
        get
        {
            return _clickDelete ?? (_clickDelete = new CommandHandler(() => AddProductEntry(), () => true));
        }
    }

    private DataTable _customers;
    public DataTable Customers
    {
        get => _customers;
        set => _customers = value;
    }

    public Summary Model { get; set;}

    public WindowSummaryViewModel()
    {

    }

    private void AddProductEntry()
    {
        /*
        DataRow test = _customers.NewRow();
        test["id"] = 1;
        test["product_id"] = "111";
        test["email"] = "adasd@asdfsad.dsf";
        test["product_name"] = "TEST1";

        _customers.Rows.Add(test);
        */

        Model.AddProductEntry(11, "dsafsd@asfas.sdf", "JHGJHGjhgj");
    }
}