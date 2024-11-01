using Connections;
using System.Configuration;
using System.Data;
using System.Windows;
using Task16.Views;
using Task16.ViewModels;
using Task16.Models;

namespace Task16;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        Summary summary = new Summary();


        WindowSummaryViewModel wndvm = new WindowSummaryViewModel();
        wndvm.Model = summary;
        wndvm.Customers = summary.GetProductData();
        WindowSummary wnd = new WindowSummary();
        wnd.DataContext = wndvm;
        wnd.Show();

        
    }
}
