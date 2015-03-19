using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_Charting
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBarChart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/BarChart.xaml", UriKind.Relative));
        }

        private void btnPieChart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PieChart.xaml", UriKind.Relative));
        }

        private void btnLineChart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/LineChart.xaml", UriKind.Relative));
        }

        private void btnStyleBarChart_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/StyleBarChart.xaml", UriKind.Relative));
        }
    }
}