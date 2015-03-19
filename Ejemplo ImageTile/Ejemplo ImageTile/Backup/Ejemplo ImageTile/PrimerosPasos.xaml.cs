using Microsoft.Phone.Controls;
using System.Collections.Generic;
using System;

namespace Ejemplo_ImageTile
{
    public partial class PrimerosPasos : PhoneApplicationPage
    {
        public PrimerosPasos()
        {
            InitializeComponent();

            List<Uri> images = new List<Uri>();
            images.Add(new Uri("/IMGS/vita.jpg", UriKind.Relative));
            images.Add(new Uri("/IMGS/wii.jpg", UriKind.Relative));
            images.Add(new Uri("/IMGS/wiiu.jpg", UriKind.Relative));

            imageTile.ItemsSource = images;
        }

        private void btnFade_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            imageTile.AnimationType = Coding4Fun.Phone.Controls.ImageTileAnimationTypes.Fade;
        }

        private void btnHorizontalExpand_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            imageTile.AnimationType = Coding4Fun.Phone.Controls.ImageTileAnimationTypes.HorizontalExpand;
        }

        private void btnVerticalExpand_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            imageTile.AnimationType = Coding4Fun.Phone.Controls.ImageTileAnimationTypes.VerticalExpand;
        }
    }
}