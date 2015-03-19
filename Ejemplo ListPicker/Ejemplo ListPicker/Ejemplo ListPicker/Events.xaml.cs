using System.Collections.Generic;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_ListPicker
{
    public partial class Events : PhoneApplicationPage
    {
        public Events()
        {
            InitializeComponent();

            List<Drivers> source = new List<Drivers>();
            source.Add(new Drivers() { Name = "Fernando Alonso", Nationality = "ES", Scuderia = "Ferrari" });
            source.Add(new Drivers() { Name = "Lewis Hamilton", Nationality = "UK", Scuderia = "McLaren" });

            listPicker.ItemsSource = source;
        }

        private void listPicker_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            MessageBox.Show(((Drivers)listPicker.SelectedItem).Name);
        }
    }
}