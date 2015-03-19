using System.Collections.Generic;
using Microsoft.Phone.Controls;
using System.Windows.Controls.DataVisualization.Charting.Compatible;

namespace Ejemplo_Charting
{
    public partial class BarChart : PhoneApplicationPage
    {
        public BarChart()
        {
            InitializeComponent();

            List<ChartItem> data = new List<ChartItem> 
            {
			    new ChartItem { EjeX = "Prueba 1", EjeY = 50 },
			    new ChartItem { EjeX = "Prueba 2", EjeY = 100 },
			    new ChartItem { EjeX = "Prueba 3", EjeY = 163.2M }
            };

            ContentPanel.DataContext = data;
        }
    }
}