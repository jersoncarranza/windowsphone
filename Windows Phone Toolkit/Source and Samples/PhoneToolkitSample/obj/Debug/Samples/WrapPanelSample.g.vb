﻿#ExternalChecksum("C:\a\PhoneToolkit\Public\PhoneToolkitSample\Samples\WrapPanelSample.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","38A1AAC37444C428F7912E2B8170CD44")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.235
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading


Namespace Samples
    
    <Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Public Class WrapPanelSample
        Inherits Microsoft.Phone.Controls.PhoneApplicationPage
        
        Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
        
        Friend WithEvents wrapPanel As Microsoft.Phone.Controls.WrapPanel
        
        Private _contentLoaded As Boolean
        
        '''<summary>
        '''InitializeComponent
        '''</summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true
            System.Windows.Application.LoadComponent(Me, New System.Uri("/PhoneToolkitSample;component/Samples/WrapPanelSample.xaml", System.UriKind.Relative))
            Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
            Me.wrapPanel = CType(Me.FindName("wrapPanel"),Microsoft.Phone.Controls.WrapPanel)
        End Sub
    End Class
End Namespace

