﻿#pragma checksum "..\..\..\Views\ShellView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CC2AE236BBB28269E22697BFC6A80108"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Caliburn.Micro;
using Gammtek.Conduit.MassEffect.Coalesce;
using Gammtek.Conduit.MassEffect.Coalesce.ViewModels;
using Gammtek.Conduit.Windows.Markup;
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


namespace Gammtek.Conduit.MassEffect.Coalesce.Views {
    
    
    /// <summary>
    /// ShellView
    /// </summary>
    public partial class ShellView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SourceTextBox;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SourceBrowseButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DestinationTextBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DestinationBrowseButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ConvertComboBox;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConvertButton;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\ShellView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ChangeDestinationCheckBox;
        
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
            System.Uri resourceLocater = new System.Uri("/Gammtek.Conduit.MassEffect.Coalesce;component/views/shellview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\ShellView.xaml"
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
            this.SourceTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SourceBrowseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.DestinationTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.DestinationBrowseButton = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.ConvertComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.ConvertButton = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.ChangeDestinationCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
