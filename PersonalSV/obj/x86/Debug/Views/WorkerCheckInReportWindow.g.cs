﻿#pragma checksum "..\..\..\..\Views\WorkerCheckInReportWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "17D216BEEBE7888A535C0B4452EEFC8696795F9A406096E2C21820B56FF3E3ED"
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
    /// WorkerCheckInReportWindow
    /// </summary>
    public partial class WorkerCheckInReportWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtGroupSummaryHeader;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFindWhat;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpFilterDate;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel stkRadio;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTimeIn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTimeOut;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPreview;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgReport;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblTotalWorker;
        
        #line default
        #line hidden
        
        
        #line 158 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExportExcel;
        
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
            System.Uri resourceLocater = new System.Uri("/PersonalSV;component/views/workercheckinreportwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
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
            
            #line 6 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
            ((PersonalSV.Views.WorkerCheckInReportWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtGroupSummaryHeader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtFindWhat = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
            this.txtFindWhat.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.txtFindWhat_PreviewKeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dpFilterDate = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.stkRadio = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 6:
            this.txtTimeIn = ((System.Windows.Controls.TextBox)(target));
            
            #line 48 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
            this.txtTimeIn.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtTimeIn_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtTimeOut = ((System.Windows.Controls.TextBox)(target));
            
            #line 50 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
            this.txtTimeOut.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtTimeOut_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnPreview = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
            this.btnPreview.Click += new System.Windows.RoutedEventHandler(this.btnPreview_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgReport = ((System.Windows.Controls.DataGrid)(target));
            
            #line 69 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
            this.dgReport.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.dgReport_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lblTotalWorker = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.btnExportExcel = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\..\Views\WorkerCheckInReportWindow.xaml"
            this.btnExportExcel.Click += new System.Windows.RoutedEventHandler(this.btnExportExcel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

