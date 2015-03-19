using System;
using System.Linq;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Phone.Controls;
using System.Xml.Linq;
using System.Collections.Generic;

namespace Ejemplo_RSS
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            ObtenerDatos();
        }

        private void ObtenerDatos()
        {
            var request = (HttpWebRequest)WebRequest.Create(
                new Uri("http://javiersuarezruiz.wordpress.com/feed/"));
            request.BeginGetResponse(r =>
            {
                var httpRequest = (HttpWebRequest)r.AsyncState;
                var httpResponse = (HttpWebResponse)httpRequest.EndGetResponse(r);

                using (var reader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var response = reader.ReadToEnd();

                    //Interfaz de Usuario
                    Deployment.Current.Dispatcher.BeginInvoke(new Action(() =>
                    {
                        LeerDatos(response);
                    }));
                }
            }, request);
        }

        private void LeerDatos(string rss)
        {
            XDocument documento = XDocument.Parse(rss);

            List<RSSItem> items = (from item in documento.Descendants("item")
                                   select new RSSItem
                                   {
                                       Titulo = item.Element("title").Value,
                                       Contenido = item.Element("description").Value,
                                       Fecha = item.Element("pubDate").Value
                                   }).ToList();

            lstRss.ItemsSource = items;
        }
    }
}