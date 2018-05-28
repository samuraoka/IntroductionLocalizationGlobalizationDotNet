using System;
using System.Globalization;
using System.Windows;

namespace ChangeUICulture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DateTime _displayDate = DateTime.Now;

        public MainWindow()
        {
            InitializeComponent();
            UpdateUIElements();

            USButton.Click += USButton_Click;
            GBButton.Click += GBButton_Click;
            AUButton.Click += AUButton_Click;
            NZButton.Click += NZButton_Click;
            JAButton.Click += JPButton_Click;
        }

        private void UpdateUIElements()
        {
            CurrentCultureTextBlock.Text = string.Format(
                Properties.Resources.CurrentCulture,
                CultureInfo.CurrentCulture.ToString());
            DateTextBlock.Text = _displayDate.ToString("d");
            LongDateTextBlock.Text = _displayDate.ToString("D");
        }

        private void USButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-US"));
        }

        private void GBButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-GB"));
        }

        private void AUButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-AU"));
        }

        private void NZButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("en-NZ"));
        }

        private void JPButton_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture(new CultureInfo("ja-JP"));
        }
    }
}
