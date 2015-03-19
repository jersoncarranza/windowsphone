using System.Collections.Generic;
using Microsoft.Phone.Controls;

namespace Ejemplo_Charting
{
    public partial class PieChart : PhoneApplicationPage
    {
        public PieChart()
        {
            InitializeComponent();

            List<ChartItem> data = new List<ChartItem> 
            {
			    new ChartItem { EjeX = "Prueba 1", EjeY = 25 },
			    new ChartItem { EjeX = "Prueba 2", EjeY = 70 },
			    new ChartItem { EjeX = "Prueba 3", EjeY = 203.7M }
            };

            ContentPanel.DataContext = data;
        }
    }
}