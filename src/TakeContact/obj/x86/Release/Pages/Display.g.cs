﻿#pragma checksum "..\..\..\..\Pages\Display.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "81051531D950B7E22E4CBE341D5495CA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18063
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


namespace ViewFormulaire {
    
    
    /// <summary>
    /// ViewList
    /// </summary>
    public partial class ViewList : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Pages\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridList;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Pages\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn cLastName;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\Pages\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn cFirstName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Pages\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn cEmail;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\..\Pages\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnContinue;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Pages\Display.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPrint;
        
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
            System.Uri resourceLocater = new System.Uri("/TakeContact;component/pages/display.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\Display.xaml"
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
            this.gridList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.cLastName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.cFirstName = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.cEmail = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.btnContinue = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\..\Pages\Display.xaml"
            this.btnContinue.Click += new System.Windows.RoutedEventHandler(this.btnContinue_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnPrint = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\Pages\Display.xaml"
            this.btnPrint.Click += new System.Windows.RoutedEventHandler(this.btnPrint_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

