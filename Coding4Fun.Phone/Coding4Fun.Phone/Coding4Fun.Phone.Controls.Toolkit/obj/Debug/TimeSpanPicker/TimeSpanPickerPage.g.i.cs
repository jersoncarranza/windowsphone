﻿#pragma checksum "C:\Users\Javi\Desktop\Coding4Fun.Phone\Coding4Fun.Phone.Controls.Toolkit\TimeSpanPicker\TimeSpanPickerPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DA3C83320BF14DA55747FD6FBC63E289"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.239
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Phone.Controls.Primitives;
using Coding4Fun.Phone.Controls.Toolkit.Primitives;
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


namespace Coding4Fun.Phone.Controls.Toolkit {
    
    
    public partial class TimeSpanPickerPage : Coding4Fun.Phone.Controls.Primitives.TimeSpanPickerBasePage {
        
        internal System.Windows.VisualStateGroup VisibilityStates;
        
        internal System.Windows.VisualState Open;
        
        internal System.Windows.VisualState Closed;
        
        internal System.Windows.Media.PlaneProjection PlaneProjection;
        
        internal System.Windows.Shapes.Rectangle SystemTrayPlaceholder;
        
        internal Coding4Fun.Phone.Controls.Toolkit.Primitives.LoopingSelector PrimarySelector;
        
        internal Coding4Fun.Phone.Controls.Toolkit.Primitives.LoopingSelector SecondarySelector;
        
        internal Coding4Fun.Phone.Controls.Toolkit.Primitives.LoopingSelector TertiarySelector;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Coding4Fun.Phone.Controls.Toolkit;component/TimeSpanPicker/TimeSpanPickerPage.xa" +
                        "ml", System.UriKind.Relative));
            this.VisibilityStates = ((System.Windows.VisualStateGroup)(this.FindName("VisibilityStates")));
            this.Open = ((System.Windows.VisualState)(this.FindName("Open")));
            this.Closed = ((System.Windows.VisualState)(this.FindName("Closed")));
            this.PlaneProjection = ((System.Windows.Media.PlaneProjection)(this.FindName("PlaneProjection")));
            this.SystemTrayPlaceholder = ((System.Windows.Shapes.Rectangle)(this.FindName("SystemTrayPlaceholder")));
            this.PrimarySelector = ((Coding4Fun.Phone.Controls.Toolkit.Primitives.LoopingSelector)(this.FindName("PrimarySelector")));
            this.SecondarySelector = ((Coding4Fun.Phone.Controls.Toolkit.Primitives.LoopingSelector)(this.FindName("SecondarySelector")));
            this.TertiarySelector = ((Coding4Fun.Phone.Controls.Toolkit.Primitives.LoopingSelector)(this.FindName("TertiarySelector")));
        }
    }
}

