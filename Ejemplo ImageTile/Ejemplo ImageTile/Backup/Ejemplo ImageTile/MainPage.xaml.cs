using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_ImageTile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnInit_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/PrimerosPasos.xaml", UriKind.Relative));
        }

        private void btnEvents_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Eventos.xaml", UriKind.Relative));
        }
    }
}