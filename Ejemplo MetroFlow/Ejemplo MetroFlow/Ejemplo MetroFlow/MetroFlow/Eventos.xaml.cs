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

namespace Ejemplo_MetroFlow.MetroFlow
{
    public partial class Eventos : PhoneApplicationPage
    {
        public Eventos()
        {
            InitializeComponent();
        }

        private void MetroFlow_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Este evento se dispara cada vez que se cambia de item.");
        }

        private void MetroFlow_SelectionTap(object sender, Coding4Fun.Phone.Controls.SelectionTapEventArgs e)
        {
            MessageBox.Show(string.Format("Este evento se dispara cuando se pulsa sobre un item en concreto. Item pulsado: {0}", e.Data.Title));
            //Hay más propiedades de interés en el SelectionTapEventArgs como: e.Data.ImageUri
        }
    }
}