#pragma checksum "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D3AB01A2A41F22FEABC8570646B4385DD69DCBDF"
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
using Tarea3.UI.Registros;


namespace Tarea3.UI.Registros {
    
    
    /// <summary>
    /// rEjercicio1Cap7
    /// </summary>
    public partial class rEjercicio1Cap7 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CalificacionTexbox;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PromedioTextbox;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MaximaTextbox;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox MinimaTextbox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CalcularButton;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCalificacionButton;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tarea3;component/ui/registros/rejercicio1cap7.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CalificacionTexbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PromedioTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.MaximaTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.MinimaTextbox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CalcularButton = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
            this.CalcularButton.Click += new System.Windows.RoutedEventHandler(this.CalcularButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AddCalificacionButton = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\..\..\UI\Registros\rEjercicio1Cap7.xaml"
            this.AddCalificacionButton.Click += new System.Windows.RoutedEventHandler(this.AddCalificacionButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

