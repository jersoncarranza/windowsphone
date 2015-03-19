using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_PageTransitions
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pagina1.xaml", UriKind.Relative));
        }
    }
}