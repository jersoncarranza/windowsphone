﻿#pragma checksum "C:\Users\Javi\Desktop\Coding4Fun.Phone\Coding4Fun.Phone.TestApplication\Samples\Color\ColorSlider.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7D9A879939DBA6784316B75A764CBD6F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.239
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Phone.Controls;
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


namespace Coding4Fun.Phone.TestApplication.Samples.Color {
    
    
    public partial class ColorSlider : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Coding4Fun.Phone.Controls.ColorSlider ColorSliderHorizontal;
        
        internal System.Windows.Shapes.Rectangle ColorSliderHorizontalFromEvent;
        
        internal Coding4Fun.Phone.Controls.ColorSlider ColorSliderSetViaEvent;
        
        internal Coding4Fun.Phone.Controls.ColorSlider ColorSliderVertical;
        
        internal Coding4Fun.Phone.Controls.ColorSlider ColorSliderVerticalClone;
        
        internal System.Windows.Shapes.Rectangle ColorSliderVerticalFromEvent;
        
        internal Coding4Fun.Phone.Controls.ColorSlider IsEnabledViaEvent;
        
        internal Microsoft.Phone.Controls.ToggleSwitch isEnableVerification;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Coding4Fun.Phone.TestApplication;component/Samples/Color/ColorSlider.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ColorSliderHorizontal = ((Coding4Fun.Phone.Controls.ColorSlider)(this.FindName("ColorSliderHorizontal")));
            this.ColorSliderHorizontalFromEvent = ((System.Windows.Shapes.Rectangle)(this.FindName("ColorSliderHorizontalFromEvent")));
            this.ColorSliderSetViaEvent = ((Coding4Fun.Phone.Controls.ColorSlider)(this.FindName("ColorSliderSetViaEvent")));
            this.ColorSliderVertical = ((Coding4Fun.Phone.Controls.ColorSlider)(this.FindName("ColorSliderVertical")));
            this.ColorSliderVerticalClone = ((Coding4Fun.Phone.Controls.ColorSlider)(this.FindName("ColorSliderVerticalClone")));
            this.ColorSliderVerticalFromEvent = ((System.Windows.Shapes.Rectangle)(this.FindName("ColorSliderVerticalFromEvent")));
            this.IsEnabledViaEvent = ((Coding4Fun.Phone.Controls.ColorSlider)(this.FindName("IsEnabledViaEvent")));
            this.isEnableVerification = ((Microsoft.Phone.Controls.ToggleSwitch)(this.FindName("isEnableVerification")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
        }
    }
}

