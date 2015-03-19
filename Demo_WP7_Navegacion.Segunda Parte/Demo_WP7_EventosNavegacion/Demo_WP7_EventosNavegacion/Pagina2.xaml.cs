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

namespace Demo_WP7_EventosNavegacion
{
    public partial class Pagina2 : PhoneApplicationPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            MessageBox.Show("Método OnNavigatedTo de la página 2" + Environment.NewLine + 
                            string.Format("Contenido: {0}", e.Content) + Environment.NewLine +
                            string.Format("Uril de destino: {0}", e.Uri) + Environment.NewLine +
                            string.Format("Modo de navegación: {0}", e.NavigationMode));
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            MessageBox.Show("Método OnNavigatedFrom de la página 2" + Environment.NewLine + 
                            string.Format("Contenido: {0}", e.Content) + Environment.NewLine +
                            string.Format("Uril de destino: {0}", e.Uri) + Environment.NewLine +
                            string.Format("Modo de navegación: {0}", e.NavigationMode));
        }
    }
}