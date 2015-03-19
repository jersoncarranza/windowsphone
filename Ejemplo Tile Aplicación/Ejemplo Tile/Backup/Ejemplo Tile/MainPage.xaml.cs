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

namespace Ejemplo_Tile
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnImagen_Click(object sender, RoutedEventArgs e)
        {
            //Obtenemos el primer Tile activo que será siempre el de la aplicación:
            ShellTile tileAplicacion = ShellTile.ActiveTiles.First();

            StandardTileData tileInfo = new StandardTileData();
            tileInfo.BackgroundImage = new Uri("/IMGS/Sol.png", UriKind.Relative);

            tileAplicacion.Update(tileInfo);
        }

        private void btnContador_Click(object sender, RoutedEventArgs e)
        {
            ShellTile tileAplicacion = ShellTile.ActiveTiles.First();

            StandardTileData tileInfo = new StandardTileData();
            tileInfo.Count = 33;

            tileAplicacion.Update(tileInfo);
        }

        private void btnContenido_Click(object sender, RoutedEventArgs e)
        {
            ShellTile tileAplicacion = ShellTile.ActiveTiles.First();

            StandardTileData tileInfo = new StandardTileData();
            tileInfo.Title = "Soleado";

            tileAplicacion.Update(tileInfo);
        }

        private void btnTrasera_Click(object sender, RoutedEventArgs e)
        {
            ShellTile tileAplicacion = ShellTile.ActiveTiles.First();

            StandardTileData tileInfo = new StandardTileData();
            tileInfo.BackTitle = "El Tiempo";
            tileInfo.BackContent = "Soleado";
            tileInfo.BackBackgroundImage = new Uri("/IMGS/Sol.png", UriKind.Relative);

            tileAplicacion.Update(tileInfo);
        }
    }
}