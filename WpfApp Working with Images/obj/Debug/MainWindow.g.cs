#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1542B9BEDB7B724AD31276BDC8778CC509D9DB79FDE0047C17530258BC217C34"
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
using WpfApp_Working_with_Images;


namespace WpfApp_Working_with_Images {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MnItmTiles;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MnItmSmallIcons;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem MnItmNormalIcons;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LstBxImage;
        
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
            System.Uri resourceLocater = new System.Uri("/WpfApp Working with Images;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            
            #line 8 "..\..\MainWindow.xaml"
            ((WpfApp_Working_with_Images.MainWindow)(target)).SizeChanged += new System.Windows.SizeChangedEventHandler(this.Window_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MnItmTiles = ((System.Windows.Controls.MenuItem)(target));
            
            #line 38 "..\..\MainWindow.xaml"
            this.MnItmTiles.Click += new System.Windows.RoutedEventHandler(this.MnItmTiles_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MnItmSmallIcons = ((System.Windows.Controls.MenuItem)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.MnItmSmallIcons.Click += new System.Windows.RoutedEventHandler(this.MnItmSmallIcons_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MnItmNormalIcons = ((System.Windows.Controls.MenuItem)(target));
            
            #line 40 "..\..\MainWindow.xaml"
            this.MnItmNormalIcons.Click += new System.Windows.RoutedEventHandler(this.MnItmNormalIcons_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LstBxImage = ((System.Windows.Controls.ListBox)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.LstBxImage.DragEnter += new System.Windows.DragEventHandler(this.LstBxImage_DragEnter);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            this.LstBxImage.DragLeave += new System.Windows.DragEventHandler(this.LstBxImage_DragLeave);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            this.LstBxImage.Drop += new System.Windows.DragEventHandler(this.LstBxImage_Drop);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

