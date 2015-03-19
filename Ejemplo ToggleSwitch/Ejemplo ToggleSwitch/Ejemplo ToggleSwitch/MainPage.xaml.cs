using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_ToggleSwitch
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBasicClick(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Basic.xaml", UriKind.Relative));
        }

        private void btnStylesClick(object sender, RoutedEventArgs e)
        {
             NavigationService.Navigate(new Uri("/Styles.xaml", UriKind.Relative));
        }

        private void btnEventsClick(object sender, RoutedEventArgs e)
        {
             NavigationService.Navigate(new Uri("/Events.xaml", UriKind.Relative));
        }
    }
}