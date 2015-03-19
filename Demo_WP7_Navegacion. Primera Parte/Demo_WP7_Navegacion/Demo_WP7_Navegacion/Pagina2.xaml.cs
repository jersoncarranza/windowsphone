﻿using System;
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

namespace Demo_WP7_Navegacion
{
    public partial class Pagina2 : PhoneApplicationPage
    {
        public Pagina2()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string parametro = string.Empty;
            if (NavigationContext.QueryString.TryGetValue("parametro", out parametro))
                tbNombre.Text = parametro;

        }
    }
}