﻿#pragma checksum "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D057F29BF093E0962FEC1895B059C8531D3C08F7DE461612846E33D84EFF7931"
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
    /// TestCovidConfirmResultWindow
    /// </summary>
    public partial class TestCovidConfirmResultWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblHeader;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCardId;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblTotalCheckIn;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock lblConfirmed;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border brDisplay;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbChangeConfirmDate;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpConfirmDate;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboResult;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtConfirmBy;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRemark;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
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
            System.Uri resourceLocater = new System.Uri("/PersonalSV;component/views/testcovidconfirmresultwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
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
            
            #line 6 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
            ((PersonalSV.Views.TestCovidConfirmResultWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblHeader = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.txtCardId = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
            this.txtCardId.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.txtCardId_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 35 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
            this.txtCardId.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.txtCardId_PreviewKeyUp);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblTotalCheckIn = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.lblConfirmed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.brDisplay = ((System.Windows.Controls.Border)(target));
            return;
            case 7:
            this.cbChangeConfirmDate = ((System.Windows.Controls.CheckBox)(target));
            
            #line 89 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
            this.cbChangeConfirmDate.Checked += new System.Windows.RoutedEventHandler(this.cbChangeConfirmDate_Checked);
            
            #line default
            #line hidden
            
            #line 89 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
            this.cbChangeConfirmDate.Unchecked += new System.Windows.RoutedEventHandler(this.cbChangeConfirmDate_Unchecked);
            
            #line default
            #line hidden
            return;
            case 8:
            this.dpConfirmDate = ((System.Windows.Controls.DatePicker)(target));
            
            #line 90 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
            this.dpConfirmDate.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.dpConfirmDate_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cboResult = ((System.Windows.Controls.ComboBox)(target));
            
            #line 101 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
            this.cboResult.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cboResult_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.txtConfirmBy = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            this.txtRemark = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\..\Views\TestCovidConfirmResultWindow.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

