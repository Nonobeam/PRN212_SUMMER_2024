﻿#pragma checksum "..\..\..\..\Admin\Dashboard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "245245286929A2CD235B3EB0152CA5874E685F62"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OxyPlot.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace View.Admin {
    
    
    /// <summary>
    /// Dashboard
    /// </summary>
    public partial class Dashboard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Admin\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Admin\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clinic;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Admin\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ClinicDashboard;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Admin\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Account;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Admin\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView PieChart;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Admin\Dashboard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal OxyPlot.Wpf.PlotView LineChart;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/View;component/admin/dashboard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\Dashboard.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Back = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\Admin\Dashboard.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Clinic = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Admin\Dashboard.xaml"
            this.Clinic.Click += new System.Windows.RoutedEventHandler(this.Clinic_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ClinicDashboard = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Admin\Dashboard.xaml"
            this.ClinicDashboard.Click += new System.Windows.RoutedEventHandler(this.Dashboard_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Account = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Admin\Dashboard.xaml"
            this.Account.Click += new System.Windows.RoutedEventHandler(this.Account_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PieChart = ((OxyPlot.Wpf.PlotView)(target));
            return;
            case 6:
            this.LineChart = ((OxyPlot.Wpf.PlotView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

