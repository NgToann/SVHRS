﻿#pragma checksum "..\..\..\..\Views\EmployeeListWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D730C6C6E294389AC119F5AD7420D831B7CF4CA01D698F6D6A447DF40A6968D9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using PersonalSV.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.DataVisualization;
using System.Windows.Controls.DataVisualization.Charting;
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
    /// EmployeeListWindow
    /// </summary>
    public partial class EmployeeListWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChart;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeSearch;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSection;
        
        #line default
        #line hidden
        
        
        #line 122 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboDepartment;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddNew;
        
        #line default
        #line hidden
        
        
        #line 141 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgEmployee;
        
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
            System.Uri resourceLocater = new System.Uri("/PersonalSV;component/views/employeelistwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\EmployeeListWindow.xaml"
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
            
            #line 13 "..\..\..\..\Views\EmployeeListWindow.xaml"
            ((PersonalSV.Views.EmployeeListWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnChart = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.btnChart.Click += new System.Windows.RoutedEventHandler(this.btnChart_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtEmployeeSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 101 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.txtEmployeeSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEmployeeSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cboSection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 121 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.cboSection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboSection_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cboDepartment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 122 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.cboDepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboDepartment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddNew = ((System.Windows.Controls.Button)(target));
            
            #line 128 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.btnAddNew.Click += new System.Windows.RoutedEventHandler(this.btnAddNew_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgEmployee = ((System.Windows.Controls.DataGrid)(target));
            
            #line 141 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.dgEmployee.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DgEmployee_LoadingRow);
            
            #line default
            #line hidden
            
            #line 143 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.dgEmployee.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DgEmployee_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

