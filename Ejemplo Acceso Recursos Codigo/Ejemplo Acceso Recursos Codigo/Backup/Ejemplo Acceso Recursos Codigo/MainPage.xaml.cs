using System.Windows;
using System.Windows.Media;
using Microsoft.Phone.Controls;

namespace Ejemplo_Acceso_Recursos_Codigo
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush pageColor = this.Resources["pageColor"] as SolidColorBrush;

            if (pageColor != null)
                tb1.Foreground = pageColor;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush appColor = App.Current.Resources["appColor"] as SolidColorBrush;

            if (appColor != null)
                tb2.Foreground = appColor;
        }
    }
}