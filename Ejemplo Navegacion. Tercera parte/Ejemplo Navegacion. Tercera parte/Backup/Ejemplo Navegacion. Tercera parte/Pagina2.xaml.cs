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

namespace Ejemplo_Navegacion.Tercera_parte
{
    public partial class Pagina2 : PhoneApplicationPage
    {
        private Telefono _tel;
        public Telefono Tel
        {
            get { return _tel; }
            set
            {
                _tel = value;
            }
        }

        public Pagina2()
        {
            InitializeComponent();
        }
    }
}