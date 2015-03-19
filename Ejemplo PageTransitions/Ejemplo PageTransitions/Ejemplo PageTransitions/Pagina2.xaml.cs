using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_PageTransitions
{
    public partial class Pagina2 : PhoneApplicationPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pagina3.xaml", UriKind.Relative));
        }
    }
}