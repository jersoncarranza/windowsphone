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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, RoutedEventArgs e)
        {
            if (ScheduledActionService.Find("Recordatorio") != null)
                ScheduledActionService.Remove("Recordatorio");

            Reminder reminder = new Reminder("Recordatorio");
            reminder.Title = this.txtTitulo.Text;
            reminder.Content = this.txtContenido.Text;
            double seconds = 5.0;
            reminder.BeginTime = DateTime.Now.AddSeconds(seconds);
            reminder.ExpirationTime = reminder.BeginTime.AddSeconds(5.0);
            reminder.RecurrenceType = RecurrenceInterval.Daily;

            string parametro = "Texto parametro";
            reminder.NavigationUri = new Uri(string.Format("/Recordatorio.xaml?parametro={0}", parametro), UriKind.Relative);

            ScheduledActionService.Add(reminder);
        }

        private void btnVerRecordatorios_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Recordatorios.xaml", UriKind.Relative));
        }
    }
}