﻿#pragma checksum "..\..\seviye2Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B45F14BAEAC83E6343771F529A41F008FC5B262D02A0418C26555CAD679A3C09"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using uygulama11;


namespace uygulama11 {
    
    
    /// <summary>
    /// seviye2Window
    /// </summary>
    public partial class seviye2Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\seviye2Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOlumlu;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\seviye2Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnOlumsuz;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\seviye2Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnTarafsiz;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\seviye2Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAlakasız;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/uygulama11;component/seviye2window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\seviye2Window.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.BtnOlumlu = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\seviye2Window.xaml"
            this.BtnOlumlu.Click += new System.Windows.RoutedEventHandler(this.BtnOlumlu_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BtnOlumsuz = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\seviye2Window.xaml"
            this.BtnOlumsuz.Click += new System.Windows.RoutedEventHandler(this.BtnOlumsuz_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnTarafsiz = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\seviye2Window.xaml"
            this.BtnTarafsiz.Click += new System.Windows.RoutedEventHandler(this.BtnTarafsiz_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BtnAlakasız = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\seviye2Window.xaml"
            this.BtnAlakasız.Click += new System.Windows.RoutedEventHandler(this.BtnAlakasız_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

