using System;
using System.Collections.Generic;
using System.Windows.Input;
using Microsoft.Phone.Controls;

namespace Ejemplo_ImageTile
{
    public partial class Eventos : PhoneApplicationPage
    {
        public Eventos()
        {
            InitializeComponent();

            List<Uri> images = new List<Uri>();
            images.Add(new Uri("/IMGS/vita.jpg", UriKind.Relative));
            images.Add(new Uri("/IMGS/wii.jpg", UriKind.Relative));
            images.Add(new Uri("/IMGS/wiiu.jpg", UriKind.Relative));

            imageTile.ItemsSource = images;
        }

        private void imageTile_Tap(object sender, GestureEventArgs e)
        {
            imageTile.CycleImage();
        }
    }
}