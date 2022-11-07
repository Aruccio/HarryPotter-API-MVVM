﻿#pragma checksum "..\..\..\..\View\CharacterListView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C6E50F8521AF42F783AE3F09931AF22E5E087E76"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HarryPotter.Infrastructure.Model;
using HarryPotter.MainApplication;
using HarryPotter.MainApplication.ViewModel;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace HarryPotter.MainApplication.View {
    
    
    /// <summary>
    /// CharacterListView
    /// </summary>
    public partial class CharacterListView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 69 "..\..\..\..\View\CharacterListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid allCharactersList;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\View\CharacterListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nameColumn;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\View\CharacterListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn genderColumn;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\..\View\CharacterListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn wizardBoolColumn;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\View\CharacterListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid favCharactersList;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\View\CharacterListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn nameColumnFav;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\View\CharacterListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn genderColumnFav;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\View\CharacterListView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn wizardBoolColumnFav;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HarryPotter.MainApplication;V1.0.0.0;component/view/characterlistview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\CharacterListView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.allCharactersList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.nameColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.genderColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.wizardBoolColumn = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.favCharactersList = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 6:
            this.nameColumnFav = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.genderColumnFav = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 8:
            this.wizardBoolColumnFav = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
