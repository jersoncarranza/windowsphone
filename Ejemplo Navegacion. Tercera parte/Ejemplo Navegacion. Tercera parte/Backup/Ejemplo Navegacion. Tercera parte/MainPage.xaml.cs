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
using System.Windows.Media.Imaging;

namespace Ejemplo_Navegacion.Tercera_parte
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnNavegar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Pagina2.xaml", UriKind.Relative));
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            Pagina2 pagina2 = e.Content as Pagina2;

            if (pagina2 != null)
            {
                Telefono telefono = new Telefono();
                telefono.Imagen = new Uri("/IMGS/Lumia800.jpg", UriKind.Relative);
                telefono.Marca = "Nokia";
                telefono.Modelo = "Lumia 800";
                telefono.Peso = 142;

                //pagina2.Tel = telefono;
                pagina2.DataContext = telefono;

                /*
                //Otra posibilidad sin hacer uso de binding:
                BitmapImage bi = new BitmapImage();
                bi.UriSource = telefono.Imagen;

                pagina2.img.Source = bi;
                pagina2.tbMarca.Text = telefono.Marca;
                pagina2.tbModelo.Text = telefono.Modelo;
                pagina2.tbPeso.Text = string.Format("{0} gr", telefono.Peso);
                 * */
            }
        }
    }
}