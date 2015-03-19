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
using Coding4Fun.Phone.Controls;

namespace Ejemplo_AboutPrompt
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSencillo_Click(object sender, RoutedEventArgs e)
        {
            AboutPrompt acercaDe = new AboutPrompt();
            acercaDe.Show();
        }

        private void btnPropiedades_Click(object sender, RoutedEventArgs e)
        {
            AboutPrompt acercaDe = new AboutPrompt();
            acercaDe.WaterMark = "Aparece en la parte superior";
            acercaDe.Title = "Ejemplo AboutPrompt";
            acercaDe.Body = "Esto es el mensaje del cuerpo.";
            acercaDe.Footer = "http://javiersuarezruiz.wordpress.com";
            acercaDe.VersionNumber = "Version 1.0";

            acercaDe.Show();
        }

        private void btnPersonItem_Click(object sender, RoutedEventArgs e)
        {
            AboutPrompt acercaDe = new AboutPrompt();
            acercaDe.Title = "Ejemplo AboutPersonItem";

            AboutPersonItem item = new AboutPersonItem();
            item.Role = "Autor:";
            item.AuthorName = "Javier Suárez Ruiz";
            item.WebSiteUrl = @"http://javiersuarezruiz.wordpress.com";

            acercaDe.Show(item);
        }

        private void btnUserControl_Click(object sender, RoutedEventArgs e)
        {
            AboutPrompt acercaDe = new AboutPrompt();
            acercaDe.Title = "Utilizando un UserControl";
            acercaDe.Body = new AboutPromptUserControl();

            acercaDe.Show();
        }
    }
}