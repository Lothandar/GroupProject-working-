﻿#pragma checksum "..\..\..\Pages\Admin.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2D1A074C78FA9626239E29201CAD5326"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GroupProject.Pages;
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


namespace GroupProject.Pages {
    
    
    /// <summary>
    /// Admin
    /// </summary>
    public partial class Admin : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ItemsData;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ___GroupProject_component_Final_logo_for_group_project_jpg;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout_button;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Submit_Button;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Executive_Button;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid OrderData;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\Admin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
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
            System.Uri resourceLocater = new System.Uri("/GroupProject;component/pages/admin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Admin.xaml"
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
            
            #line 9 "..\..\..\Pages\Admin.xaml"
            ((GroupProject.Pages.Admin)(target)).Initialized += new System.EventHandler(this.UserControl_Initialized);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ItemsData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.___GroupProject_component_Final_logo_for_group_project_jpg = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.Logout_button = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Pages\Admin.xaml"
            this.Logout_button.Click += new System.Windows.RoutedEventHandler(this.Logout_button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Submit_Button = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Pages\Admin.xaml"
            this.Submit_Button.Click += new System.Windows.RoutedEventHandler(this.Submit_Button_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Executive_Button = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Pages\Admin.xaml"
            this.Executive_Button.Click += new System.Windows.RoutedEventHandler(this.Executive_Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.OrderData = ((System.Windows.Controls.DataGrid)(target));
            
            #line 21 "..\..\..\Pages\Admin.xaml"
            this.OrderData.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OrderData_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.button = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

