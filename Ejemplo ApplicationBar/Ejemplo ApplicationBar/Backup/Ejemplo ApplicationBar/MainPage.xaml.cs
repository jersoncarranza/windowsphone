using System;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_ApplicationBar
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void ApplicationBarMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento Click de producido por un ApplicationBarMenuItem");
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento Click de producido por un ApplicationBarIconButton");
        }
    }
}