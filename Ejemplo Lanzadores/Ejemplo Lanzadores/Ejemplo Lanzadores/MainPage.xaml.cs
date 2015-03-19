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
using Microsoft.Phone.Tasks;
using System.Device.Location;

namespace Ejemplo_Lanzadores
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnBingMapsDirectionsTask_Click(object sender, RoutedEventArgs e)
        {
            BingMapsDirectionsTask ruta = new BingMapsDirectionsTask();
            ruta.Start = new LabeledMapLocation("Sevilla", new GeoCoordinate(37.3879089355469 , 6.00195980072021));
            ruta.End = new LabeledMapLocation("Madrid", new GeoCoordinate(40.4202995300293 , 3.70577001571655));

            ruta.Show();
        }

        private void btnBingMapsTask_Click(object sender, RoutedEventArgs e)
        {
            BingMapsTask mapa = new BingMapsTask();
            mapa.SearchTerm = "Sevilla";

            mapa.Show();
        }

        private void btnEmailComposeTask_Click(object sender, RoutedEventArgs e)
        {
            EmailComposeTask correo = new EmailComposeTask();
            correo.To = "destinatario@correo.es";
            correo.Subject = "Test EmailComposeTask";
            correo.Body = "Cuerpo del correo electrónico.";

            correo.Show();
        }

        private void btnMarketplaceDetailTask_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceDetailTask detallesAplicacion = new MarketplaceDetailTask();
            detallesAplicacion.ContentIdentifier = null;
            detallesAplicacion.ContentType = MarketplaceContentType.Applications;

            detallesAplicacion.Show();
        }

        private void btnMarketplaceHubTask_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceHubTask abrirMarket = new MarketplaceHubTask();
            abrirMarket.ContentType = MarketplaceContentType.Music;

            abrirMarket.Show();
        }

        private void btnMarketplaceReviewTask_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceReviewTask darOpinion = new MarketplaceReviewTask();
            darOpinion.Show();
        }

        private void btnMarketplaceSearchTask_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceSearchTask busquedaMarket = new MarketplaceSearchTask();
            busquedaMarket.ContentType = MarketplaceContentType.Applications;
            busquedaMarket.SearchTerms = "Javier Suárez Ruiz";

            busquedaMarket.Show();
        }

        private void btnMediaPlayerLauncher_Click(object sender, RoutedEventArgs e)
        {
            MediaPlayerLauncher reproductor = new MediaPlayerLauncher();
            reproductor.Media = new Uri("http://media.ch9.ms/ch9/cf36/619b25ee-8acd-46b1-bc96-f578d855cf36/W8TourIntroduccion.wmv", UriKind.Absolute);
            reproductor.Orientation = MediaPlayerOrientation.Landscape;

            reproductor.Show();
        }

        private void btnPhoneCallTask_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallTask llamada = new PhoneCallTask();
            llamada.PhoneNumber = "666666666";
            llamada.DisplayName = "Mama";

            llamada.Show();
        }

        private void btnSearchTask_Click(object sender, RoutedEventArgs e)
        {
            SearchTask busqueda = new SearchTask();
            busqueda.SearchQuery = "Javier Suárez Ruiz Blog";

            busqueda.Show();
        }

        private void btnShareLinkTask_Click(object sender, RoutedEventArgs e)
        {
            ShareLinkTask compartirEnlace = new ShareLinkTask();
            compartirEnlace.LinkUri = new Uri("http://javiersuarezruiz.wordpress.com");
            compartirEnlace.Message = "Visita el blog!";

            compartirEnlace.Show();
        }

        private void btnShareStatusTask_Click(object sender, RoutedEventArgs e)
        {
            ShareStatusTask compartirEstado = new ShareStatusTask();
            compartirEstado.Status = "Realizando un ejemplo sobre lanzadores de WP7!";

            compartirEstado.Show();
        }

        private void btnSmsComposeTask_Click(object sender, RoutedEventArgs e)
        {
            SmsComposeTask enviarSMS = new SmsComposeTask();
            enviarSMS.To = "666666666";
            enviarSMS.Body = "Visita http://javiersuarezruiz.wordpress.com";
   
            enviarSMS.Show();
        }

        private void btnWebBrowserTask_Click(object sender, RoutedEventArgs e)
        {
            WebBrowserTask navegador = new WebBrowserTask();
            navegador.Uri = new Uri("http://javiersuarezruiz.wordpress.com");

            navegador.Show();
        }
    }
}