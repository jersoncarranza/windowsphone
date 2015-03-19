using System.Collections.Generic;
using Microsoft.Phone.Controls;

namespace Ejemplo_ListPicker
{
    public partial class Styles : PhoneApplicationPage
    {
        public Styles()
        {
            InitializeComponent();


            List<Drivers> source = new List<Drivers>();
            source.Add(new Drivers() { Name = "Fernando Alonso", Nationality = "ES", Scuderia = "Ferrari" });
            source.Add(new Drivers() { Name = "Lewis Hamilton", Nationality = "UK", Scuderia = "McLaren" });
            source.Add(new Drivers() { Name = "Sebastian Vettel", Nationality = "GE", Scuderia = "RedBull" });

            listPicker1.ItemsSource = source;
            listPicker2.ItemsSource = source;
        }
    }
}