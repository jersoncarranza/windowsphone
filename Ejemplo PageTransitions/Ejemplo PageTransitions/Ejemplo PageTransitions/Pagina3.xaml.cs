using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_PageTransitions
{
    public partial class Pagina3 : PhoneApplicationPage
    {
        public Pagina3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}