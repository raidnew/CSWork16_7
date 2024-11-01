using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Data;

namespace Task16.ViewModels;


public class WindowSummaryViewModel : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    private DataTable _customers;

    public DataTable Customers
    {
        get => _customers; 
        set => _customers = value;
    }

    //private 
}