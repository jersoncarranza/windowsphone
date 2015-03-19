using System.Collections.Generic;
using Microsoft.Phone.Controls;

namespace Ejemplo_Charting
{
    public partial class LineChart : PhoneApplicationPage
    {
        public LineChart()
        {
            InitializeComponent();

            List<ChartItem> data = new List<ChartItem> 
            {
			    new ChartItem { EjeX = "Prueba 1", EjeY = 35 },
			    new ChartItem { EjeX = "Prueba 2", EjeY = 80 },
			    new ChartItem { EjeX = "Prueba 3", EjeY = 223.7M }
            };

            ContentPanel.DataContext = data;
        }
    }
}