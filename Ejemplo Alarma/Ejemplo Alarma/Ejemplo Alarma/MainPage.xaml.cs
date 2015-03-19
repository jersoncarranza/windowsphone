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

namespace Ejemplo_Alarma
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            if (ScheduledActionService.Find("Ejemplo Alarma 1") != null)
                ScheduledActionService.Remove("Ejemplo Alarma 1");

            Alarm alarma = new Alarm("Ejemplo Alarma 1");
            alarma.BeginTime = DateTime.Now.AddSeconds(5);
            alarma.Content = txtContenido.Text;
            alarma.RecurrenceType = RecurrenceInterval.None;

            ScheduledActionService.Add(alarma);

            if (ScheduledActionService.Find("Ejemplo Alarma 2") != null)
                ScheduledActionService.Remove("Ejemplo Alarma 2");

            Alarm alarma2 = new Alarm("Ejemplo Alarma 2");
            alarma2.BeginTime = DateTime.Now.AddSeconds(5);
            alarma2.Content = txtContenido.Text;
            alarma2.RecurrenceType = RecurrenceInterval.None;
            alarma2.Sound = new Uri("alarma.mp3", UriKind.Relative);
            ScheduledActionService.Add(alarma2);
        }

        private void btnVerAlarmas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Alarmas.xaml", UriKind.Relative));
        }
    }
}