﻿#pragma checksum "..\..\ManageBorrows.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7D5FC9C7FE20F0404E0056B0B0F62945A333A004FB43D8045C083B96FC5C4B59"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using Biblioteka;
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


namespace Biblioteka {
    
    
    /// <summary>
    /// ManageBorrows
    /// </summary>
    public partial class ManageBorrows : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_user;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox search_book;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox index;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox user;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox book;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button add;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mod;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button del;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ManageBorrows.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView borrowList;
        
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
            System.Uri resourceLocater = new System.Uri("/Biblioteka;component/manageborrows.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManageBorrows.xaml"
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
            
            #line 7 "..\..\ManageBorrows.xaml"
            ((Biblioteka.ManageBorrows)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ManageBorrows_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.search_user = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.search_book = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.index = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.user = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.book = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.add = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\ManageBorrows.xaml"
            this.add.Click += new System.Windows.RoutedEventHandler(this.save_Borrow);
            
            #line default
            #line hidden
            return;
            case 8:
            this.mod = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\ManageBorrows.xaml"
            this.mod.Click += new System.Windows.RoutedEventHandler(this.edit_Client);
            
            #line default
            #line hidden
            return;
            case 9:
            this.del = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\ManageBorrows.xaml"
            this.del.Click += new System.Windows.RoutedEventHandler(this.wyjdz_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.borrowList = ((System.Windows.Controls.ListView)(target));
            return;
            case 11:
            
            #line 52 "..\..\ManageBorrows.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 53 "..\..\ManageBorrows.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

