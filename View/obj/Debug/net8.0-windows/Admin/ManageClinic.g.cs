<<<<<<< HEAD
﻿#pragma checksum "..\..\..\..\Admin\ManageClinic.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5835EC293902E6C5B6155871DFB7B0338346C16F"
=======
﻿#pragma checksum "..\..\..\..\Admin\ManageClinic.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7919D3A6E6A100D0F0E171503358686A694232AA"
>>>>>>> 197b52513686be5e3511151023bf63e90d363464
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


namespace View.Admin {
    
    
    /// <summary>
    /// ManageClinic
    /// </summary>
    public partial class ManageClinic : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 19 "..\..\..\..\Admin\ManageClinic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Back;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Admin\ManageClinic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clinic;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\Admin\ManageClinic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Dashboard;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Admin\ManageClinic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Account;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Admin\ManageClinic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Admin\ManageClinic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchAddress;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Admin\ManageClinic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Admin\ManageClinic.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ClinicTable;
        
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
            System.Uri resourceLocater = new System.Uri("/View;component/admin/manageclinic.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Admin\ManageClinic.xaml"
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
            
            #line 19 "..\..\..\..\Admin\ManageClinic.xaml"
            this.Back.Click += new System.Windows.RoutedEventHandler(this.Back_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Clinic = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\..\Admin\ManageClinic.xaml"
            this.Clinic.Click += new System.Windows.RoutedEventHandler(this.Clinic_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Dashboard = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\..\Admin\ManageClinic.xaml"
            this.Dashboard.Click += new System.Windows.RoutedEventHandler(this.Dashboard_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Account = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\..\Admin\ManageClinic.xaml"
            this.Account.Click += new System.Windows.RoutedEventHandler(this.Account_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.searchAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Admin\ManageClinic.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.ClinicTable = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.5.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 9:
            
            #line 59 "..\..\..\..\Admin\ManageClinic.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ViewButton_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

