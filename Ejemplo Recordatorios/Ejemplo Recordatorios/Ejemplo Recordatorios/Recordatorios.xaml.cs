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
using Microsoft.Phone.Scheduler;

namespace Ejemplo_Recordatorios
{
    public partial class Recordatorios : PhoneApplicationPage
    {
        public Recordatorios()
        {
            InitializeComponent();

            ObtenerRecordatorios();
        }

        private void ObtenerRecordatorios()
        {
            IEnumerable<Reminder> recordatorios = ScheduledActionService.GetActions<Reminder>();
            this.lbRecordatorios.ItemsSource = recordatorios;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}