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

namespace Ejemplo_MetroFlow
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSimple_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MetroFlow/Simple.xaml", UriKind.Relative));
        }

        private void btnPropiedadesXAML_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MetroFlow/PropiedadesXAML.xaml", UriKind.Relative));
        }

        private void btnPropiedadesCB_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MetroFlow/PropiedadesCodeBehind.xaml", UriKind.Relative));
        }

        private void btnEventos_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MetroFlow/Eventos.xaml", UriKind.Relative));
        }

        private void btnPersonalizacion_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MetroFlow/Personalizacion.xaml", UriKind.Relative));
        }
    }
}