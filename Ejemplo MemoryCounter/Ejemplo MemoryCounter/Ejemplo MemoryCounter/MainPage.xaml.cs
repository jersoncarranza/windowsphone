using System;
using System.Collections.Generic;
using System.Windows;
using Microsoft.Phone.Controls;

namespace Ejemplo_MemoryCounter
{
    public partial class MainPage : PhoneApplicationPage
    {
        List<Byte[]> _memoria;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            _memoria = new List<byte[]>();
        }

        private void btnLoadClick(object sender, RoutedEventArgs e)
        {
            _memoria.Add(new Byte[1024 * 1024 * 10]);
        }

        private void btnClearClick(object sender, RoutedEventArgs e)
        {
            _memoria.Clear();
            GC.Collect();
        }

        private void btnInfoClick(object sender, RoutedEventArgs e)
        {
            string mensaje = string.Format("Memoria usada actualmente: {0}Mb" + Environment.NewLine + "Memoria máxima que se ha llegado a utilizar: {1}Mb", memoryCounter.CurrentMemory, memoryCounter.PeakMemory);
            MessageBox.Show(mensaje);
        }
    }
}