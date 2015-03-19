using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows;
using Microsoft.Phone.Controls;
using System.Xml.Linq;

namespace Ejemplo_RSS_Cine
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
                new Uri("http://www.cinesunidos.com/XML_Files/movieBusinessData.xml"));
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

            List<RSSItem> items = (from item in documento.Descendants("Movie")
                                   select new RSSItem
                                   {
                                       Id = Convert.ToInt32(item.Attribute("id").Value),
                                       Titulo = item.Element("SpanishTitle").Value,
                                       Sinopsis = item.Element("Synopsis").Value
                                   }).ToList();

            lstRss.ItemsSource = items;
        }
    }
}