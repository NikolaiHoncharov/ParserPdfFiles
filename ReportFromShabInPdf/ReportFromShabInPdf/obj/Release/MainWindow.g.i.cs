﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A553832124C7654D4CE8F14927CF4AF325A45CE2A653C33032118A4D6C020762"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ReportFromShabInPdf;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace ReportFromShabInPdf {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DockPanel mainDock;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExit;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnMin;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.WrapPanel wrpPnlOne;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateStart;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dateEnd;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDownloadRp;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeFileSystem;
        
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
            System.Uri resourceLocater = new System.Uri("/ReportFromShabInPdf;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.mainDock = ((System.Windows.Controls.DockPanel)(target));
            return;
            case 2:
            
            #line 17 "..\..\MainWindow.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnExit = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.btnExit.Click += new System.Windows.RoutedEventHandler(this.BtnExit_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnMin = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\MainWindow.xaml"
            this.btnMin.Click += new System.Windows.RoutedEventHandler(this.BtnMin_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.wrpPnlOne = ((System.Windows.Controls.WrapPanel)(target));
            return;
            case 6:
            this.dateStart = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 7:
            this.dateEnd = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 8:
            this.btnDownloadRp = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\MainWindow.xaml"
            this.btnDownloadRp.Click += new System.Windows.RoutedEventHandler(this.BtnDownloadRp_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.treeFileSystem = ((System.Windows.Controls.TreeView)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.treeFileSystem.AddHandler(System.Windows.Controls.TreeViewItem.ExpandedEvent, new System.Windows.RoutedEventHandler(this.item_Expanded));
            
            #line default
            #line hidden
            
            #line 38 "..\..\MainWindow.xaml"
            this.treeFileSystem.KeyDown += new System.Windows.Input.KeyEventHandler(this.treeFileSystem_KeyDown);
            
            #line default
            #line hidden
            
            #line 38 "..\..\MainWindow.xaml"
            this.treeFileSystem.SelectedItemChanged += new System.Windows.RoutedPropertyChangedEventHandler<object>(this.treeFileSystem_SelectedItemChanged);
            
            #line default
            #line hidden
            
            #line 39 "..\..\MainWindow.xaml"
            this.treeFileSystem.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.treeFileSystem_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
