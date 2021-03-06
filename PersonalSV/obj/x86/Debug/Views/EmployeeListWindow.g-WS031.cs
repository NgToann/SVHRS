#pragma checksum "..\..\..\..\Views\EmployeeListWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "420E7D2F448F19D296735B511FC461897F0715A4"
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
        
        
        #line 38 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmployeeSearch;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSearch;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboSection;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboDepartment;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\EmployeeListWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddNew;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\EmployeeListWindow.xaml"
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
            
            #line 4 "..\..\..\..\Views\EmployeeListWindow.xaml"
            ((PersonalSV.Views.EmployeeListWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtEmployeeSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.txtEmployeeSearch.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.TxtEmployeeSearch_PreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 38 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.txtEmployeeSearch.PreviewGotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.TxtEmployeeSearch_PreviewGotKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnSearch = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.btnSearch.Click += new System.Windows.RoutedEventHandler(this.BtnSearch_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cboSection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 41 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.cboSection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboSection_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cboDepartment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.cboDepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CboDepartment_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddNew = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.btnAddNew.Click += new System.Windows.RoutedEventHandler(this.btnAddNew_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dgEmployee = ((System.Windows.Controls.DataGrid)(target));
            
            #line 50 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.dgEmployee.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DgEmployee_LoadingRow);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\..\Views\EmployeeListWindow.xaml"
            this.dgEmployee.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.DgEmployee_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

