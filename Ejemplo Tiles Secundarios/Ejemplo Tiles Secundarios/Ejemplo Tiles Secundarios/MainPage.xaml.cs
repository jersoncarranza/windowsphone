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
using Microsoft.Phone.Shell;

namespace Ejemplo_Tiles_Secundarios
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCrearTile_Click(object sender, RoutedEventArgs e)
        {
            ShellTile tileSecundario = ShellTile.ActiveTiles.FirstOrDefault(
                tile => tile.NavigationUri.ToString().Contains("MainPage.xaml"));

            if (tileSecundario == null)
            {
                StandardTileData tileInfo = new StandardTileData
                {
                    Title = "Vista Delantera",
                    BackgroundImage = new Uri("/IMGS/Lluvia.png", UriKind.Relative),
                    Count = 7,
                    BackTitle = "Vista Trasera",
                    BackBackgroundImage = new Uri("/IMGS/Lluvia.png", UriKind.Relative),
                    BackContent = "Lluvia"
                };

                ShellTile.Create(new Uri("/MainPage.xaml", UriKind.Relative), tileInfo);
            }
        }

        private void btnEliminarTile_Click(object sender, RoutedEventArgs e)
        {
            ShellTile tileSecundario = ShellTile.ActiveTiles.FirstOrDefault(
                tile => tile.NavigationUri.ToString().Contains("MainPage.xaml"));

            if (tileSecundario != null)
            {
                tileSecundario.Delete();
            }

            MessageBox.Show("Tile Secundario eliminado con éxito.");
        }
    }
}