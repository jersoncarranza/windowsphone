﻿#pragma checksum "C:\Users\Javi\Desktop\Coding4Fun.Phone\Coding4Fun.Phone.TestApplication\Samples\ButtonControls.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "28272953F503EC8558C3DD586FAFAA08"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.239
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Coding4Fun.Phone.TestApplication.Samples {
    
    
    public partial class ButtonControls : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Media.Animation.Storyboard trexStoryboard;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot ButtonPivot;
        
        internal System.Windows.Controls.Image image;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Coding4Fun.Phone.TestApplication;component/Samples/ButtonControls.xaml", System.UriKind.Relative));
            this.trexStoryboard = ((System.Windows.Media.Animation.Storyboard)(this.FindName("trexStoryboard")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ButtonPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("ButtonPivot")));
            this.image = ((System.Windows.Controls.Image)(this.FindName("image")));
        }
    }
}

