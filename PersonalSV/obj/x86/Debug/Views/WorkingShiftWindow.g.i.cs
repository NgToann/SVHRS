#pragma checksum "..\..\..\..\Views\WorkingShiftWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B4DDCC00CF8893DB2AA75D2FF8B3EB5A236AD68C"
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
    /// WorkingShiftWindow
    /// </summary>
    public partial class WorkingShiftWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Views\WorkingShiftWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpFrom;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\WorkingShiftWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpTo;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\WorkingShiftWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboWorkingShiftNo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\WorkingShiftWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdate;
        
        #line default
        #line hidden
        
        
        #line 312 "..\..\..\..\Views\WorkingShiftWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgShiftNoTemp;
        
        #line default
        #line hidden
        
        
        #line 327 "..\..\..\..\Views\WorkingShiftWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miRemove;
        
        #line default
        #line hidden
        
        
        #line 352 "..\..\..\..\Views\WorkingShiftWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/PersonalSV;component/views/workingshiftwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\WorkingShiftWindow.xaml"
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
            
            #line 8 "..\..\..\..\Views\WorkingShiftWindow.xaml"
            ((PersonalSV.Views.WorkingShiftWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dpFrom = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 3:
            this.dpTo = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.cboWorkingShiftNo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnUpdate = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\..\Views\WorkingShiftWindow.xaml"
            this.btnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.dgShiftNoTemp = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.miRemove = ((System.Windows.Controls.MenuItem)(target));
            
            #line 327 "..\..\..\..\Views\WorkingShiftWindow.xaml"
            this.miRemove.Click += new System.Windows.RoutedEventHandler(this.MiRemove_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 352 "..\..\..\..\Views\WorkingShiftWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

