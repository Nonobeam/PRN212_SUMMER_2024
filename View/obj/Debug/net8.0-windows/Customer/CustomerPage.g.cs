﻿#pragma checksum "..\..\..\..\Customer\CustomerPage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AAAA48C1AB383975BA86B596E160B1FF24B7784"
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
using View.Customer;


namespace View.Customer {
    
    
    /// <summary>
    /// CustomerPage
    /// </summary>
    public partial class CustomerPage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\Customer\CustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button logout;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Customer\CustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button booking;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Customer\CustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clinic;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Customer\CustomerPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button history;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/customer/customerpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Customer\CustomerPage.xaml"
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
            this.logout = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\..\Customer\CustomerPage.xaml"
            this.logout.Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.booking = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Customer\CustomerPage.xaml"
            this.booking.Click += new System.Windows.RoutedEventHandler(this.Booking_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.clinic = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Customer\CustomerPage.xaml"
            this.clinic.Click += new System.Windows.RoutedEventHandler(this.Clinic_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.history = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\Customer\CustomerPage.xaml"
            this.history.Click += new System.Windows.RoutedEventHandler(this.History_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

