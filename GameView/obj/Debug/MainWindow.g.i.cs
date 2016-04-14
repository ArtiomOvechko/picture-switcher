﻿#pragma checksum "..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "64BDB9D4A8867B826995A7BCFB5F8F80"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GameView;
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


namespace GameView {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GameView.MainWindow wind;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newGameBtn;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button topScoreBtn;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button reserScoreBtn;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox blinkyAs;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox pinkyAs;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox inkyAs;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox clydeAs;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas fieldCan;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock records;
        
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
            System.Uri resourceLocater = new System.Uri("/GameView;component/mainwindow.xaml", System.UriKind.Relative);
            
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
            this.wind = ((GameView.MainWindow)(target));
            
            #line 8 "..\..\MainWindow.xaml"
            this.wind.AddHandler(System.Windows.Input.Keyboard.KeyDownEvent, new System.Windows.Input.KeyEventHandler(this.fieldCan_KeyDown));
            
            #line default
            #line hidden
            
            #line 8 "..\..\MainWindow.xaml"
            this.wind.AddHandler(System.Windows.Input.Keyboard.KeyUpEvent, new System.Windows.Input.KeyEventHandler(this.fieldCan_KeyUp));
            
            #line default
            #line hidden
            return;
            case 2:
            this.newGameBtn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.newGameBtn.Click += new System.Windows.RoutedEventHandler(this.newGameBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.topScoreBtn = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\MainWindow.xaml"
            this.topScoreBtn.Click += new System.Windows.RoutedEventHandler(this.TopScoreBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.reserScoreBtn = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.reserScoreBtn.Click += new System.Windows.RoutedEventHandler(this.ResetScoreBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.blinkyAs = ((System.Windows.Controls.ComboBox)(target));
            
            #line 59 "..\..\MainWindow.xaml"
            this.blinkyAs.Loaded += new System.Windows.RoutedEventHandler(this.ghostAs_Loaded);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            this.blinkyAs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ghostAs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.pinkyAs = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\MainWindow.xaml"
            this.pinkyAs.Loaded += new System.Windows.RoutedEventHandler(this.ghostAs_Loaded);
            
            #line default
            #line hidden
            
            #line 60 "..\..\MainWindow.xaml"
            this.pinkyAs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ghostAs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.inkyAs = ((System.Windows.Controls.ComboBox)(target));
            
            #line 61 "..\..\MainWindow.xaml"
            this.inkyAs.Loaded += new System.Windows.RoutedEventHandler(this.ghostAs_Loaded);
            
            #line default
            #line hidden
            
            #line 61 "..\..\MainWindow.xaml"
            this.inkyAs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ghostAs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.clydeAs = ((System.Windows.Controls.ComboBox)(target));
            
            #line 62 "..\..\MainWindow.xaml"
            this.clydeAs.Loaded += new System.Windows.RoutedEventHandler(this.ghostAs_Loaded);
            
            #line default
            #line hidden
            
            #line 62 "..\..\MainWindow.xaml"
            this.clydeAs.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ghostAs_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.fieldCan = ((System.Windows.Controls.Canvas)(target));
            return;
            case 10:
            this.records = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

