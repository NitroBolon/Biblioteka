﻿#pragma checksum "..\..\ManageBooks.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6A7688F18D800159AD9F8C9A0894EBEC2F9BB8E6F88EE31D07C2C02FC70D816E"
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
    /// ManageBooks
    /// </summary>
    public partial class ManageBooks : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tytul;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox autor;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idInput;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleInput;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox authorInput;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox yearInput;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button saveButton;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitButton;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ManageBooks.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listView;
        
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
            System.Uri resourceLocater = new System.Uri("/Biblioteka;component/managebooks.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ManageBooks.xaml"
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
            
            #line 7 "..\..\ManageBooks.xaml"
            ((Biblioteka.ManageBooks)(target)).Loaded += new System.Windows.RoutedEventHandler(this.ManageBooks_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tytul = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\ManageBooks.xaml"
            this.tytul.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.user_TextChanged);
            
            #line default
            #line hidden
            
            #line 21 "..\..\ManageBooks.xaml"
            this.tytul.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.user_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 21 "..\..\ManageBooks.xaml"
            this.tytul.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.user_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 3:
            this.autor = ((System.Windows.Controls.TextBox)(target));
            
            #line 22 "..\..\ManageBooks.xaml"
            this.autor.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.book_TextChanged);
            
            #line default
            #line hidden
            
            #line 22 "..\..\ManageBooks.xaml"
            this.autor.GotKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.book_GotKeyboardFocus);
            
            #line default
            #line hidden
            
            #line 22 "..\..\ManageBooks.xaml"
            this.autor.LostKeyboardFocus += new System.Windows.Input.KeyboardFocusChangedEventHandler(this.book_LostKeyboardFocus);
            
            #line default
            #line hidden
            return;
            case 4:
            this.idInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.titleInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.authorInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.yearInput = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.saveButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\ManageBooks.xaml"
            this.saveButton.Click += new System.Windows.RoutedEventHandler(this.save_Book);
            
            #line default
            #line hidden
            return;
            case 9:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\ManageBooks.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.edit_Book);
            
            #line default
            #line hidden
            return;
            case 10:
            this.exitButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\ManageBooks.xaml"
            this.exitButton.Click += new System.Windows.RoutedEventHandler(this.wyjdz_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.listView = ((System.Windows.Controls.ListView)(target));
            
            #line 41 "..\..\ManageBooks.xaml"
            this.listView.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listView_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 44 "..\..\ManageBooks.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Edit);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 45 "..\..\ManageBooks.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.Delete);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

