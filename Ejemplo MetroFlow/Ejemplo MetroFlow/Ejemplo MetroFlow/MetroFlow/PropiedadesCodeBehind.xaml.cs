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

namespace Ejemplo_MetroFlow.MetroFlow
{
    public partial class PropiedadesCodeBehind : PhoneApplicationPage
    {
        public PropiedadesCodeBehind()
        {
            InitializeComponent();

            //Creamos el MetroFlow dinamicamente:
            Coding4Fun.Phone.Controls.MetroFlow metroFlow = new Coding4Fun.Phone.Controls.MetroFlow();

            // Añadimos cada MetroFlowData:
            metroFlow.Items.Add(new MetroFlowData { Title = "Nokia Lumia 610", ImageUri = new Uri(@"..\IMGS\Lumia610.jpg", UriKind.RelativeOrAbsolute) });
            metroFlow.Items.Add(new MetroFlowData { Title = "Nokia Lumia 710", ImageUri = new Uri(@"..\IMGS\Lumia710.jpg", UriKind.RelativeOrAbsolute) });
            metroFlow.Items.Add(new MetroFlowData { Title = "Nokia Lumia 800", ImageUri = new Uri(@"..\IMGS\Lumia800.jpg", UriKind.RelativeOrAbsolute) });
            metroFlow.Items.Add(new MetroFlowData { Title = "Nokia Lumia 900", ImageUri = new Uri(@"..\IMGS\Lumia900.jpg", UriKind.RelativeOrAbsolute) });

            // Indicamos el MetroFlowData que estará expandido:
            metroFlow.SelectedColumnIndex = 3;

            //Añadimos el control al Grid principal de la página:
            ContentPanel.Children.Add(metroFlow);
        }
    }
}