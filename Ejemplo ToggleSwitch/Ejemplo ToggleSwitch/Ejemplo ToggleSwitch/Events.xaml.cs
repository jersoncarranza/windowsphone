using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_ToggleSwitch
{
    public partial class Events : PhoneApplicationPage
    {
        public Events()
        {
            InitializeComponent();
        }

        private void tEventsChecked(object sender, RoutedEventArgs e)
        {
            tEvents.Content = "Activado";
            MessageBox.Show("Activado");
        }

        private void tEventsUnchecked(object sender, RoutedEventArgs e)
        {
            tEvents.Content = "Desactivado";
            MessageBox.Show("Desactivado");
        }
    }
}