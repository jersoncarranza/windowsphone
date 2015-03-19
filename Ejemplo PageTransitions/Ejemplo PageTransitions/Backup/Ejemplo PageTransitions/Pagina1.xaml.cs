using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_PageTransitions
{
    public partial class Pagina1 : PhoneApplicationPage
    {
        public Pagina1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pagina2.xaml", UriKind.Relative));
        }
    }
}