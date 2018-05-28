using System.Globalization;
using System.Threading;
using System.Windows;

namespace ChangeUICulture
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        internal static void ChangeCulture(CultureInfo newCulture)
        {
            Thread.CurrentThread.CurrentCulture = newCulture;
            Thread.CurrentThread.CurrentUICulture = newCulture;

            var oldWindow = Current.MainWindow;

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();

            oldWindow.Close();
        }
    }
}
