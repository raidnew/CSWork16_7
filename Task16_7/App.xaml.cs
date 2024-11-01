using Connections;
using System.Configuration;
using System.Data;
using System.Windows;
using Task16.Views;
using Task16.ViewModels;

namespace Task16;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{

    private void Application_Startup(object sender, StartupEventArgs e)
    {
        WindowSummary wnd = new WindowSummary();
        WindowSummaryViewModel wndvm = new WindowSummaryViewModel();
        wnd.Show();

        DBSQLConnection conn = new DBSQLConnection();
    }
}
