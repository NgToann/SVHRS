﻿#pragma checksum "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "742146446C851A065716750A3BB222BCCA513E25FA00E1D2CEBDFB71BA2399B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PersonalSV.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace PersonalSV.Views {
    
    
    /// <summary>
    /// TestCovidCreateTestTermWindow
    /// </summary>
    public partial class TestCovidCreateTestTermWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtGroupSummaryHeader;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpTestDate;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink hlViewWorkerList;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCreate;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgRandomList;
        
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
            System.Uri resourceLocater = new System.Uri("/PersonalSV;component/views/testcovidcreatetesttermwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
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
            this.txtGroupSummaryHeader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.dpTestDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.hlViewWorkerList = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 38 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
            this.hlViewWorkerList.Click += new System.Windows.RoutedEventHandler(this.hlViewWorkerList_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnCreate = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
            this.btnCreate.Click += new System.Windows.RoutedEventHandler(this.btnCreate_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dgRandomList = ((System.Windows.Controls.DataGrid)(target));
            
            #line 59 "..\..\..\..\Views\TestCovidCreateTestTermWindow.xaml"
            this.dgRandomList.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dgRandomList_LoadingRow);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

