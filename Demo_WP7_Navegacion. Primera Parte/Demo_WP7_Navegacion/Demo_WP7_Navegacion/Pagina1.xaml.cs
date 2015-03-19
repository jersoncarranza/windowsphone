using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Demo_WP7_Navegacion
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnPag2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pagina2.xaml", UriKind.Relative));
        }

        private void btnPag2Parametro_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri(string.Format("/Pagina2.xaml?parametro={0}", txtParametro.Text), UriKind.Relative));
        }
    }
}