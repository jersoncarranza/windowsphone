using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_ListPicker
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBasic_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Basic.xaml", UriKind.Relative));
        }

        private void btnStyles_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Styles.xaml", UriKind.Relative));
        }

        private void btnEvents_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Events.xaml", UriKind.Relative));
        }
    }
}