﻿#pragma checksum "..\..\..\..\MyContrlClass\DataPager.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2B4DF32A34884A3066F914D25FD0F61F"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
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
using Trace.MyContrlClass;


namespace Trace {
    
    
    /// <summary>
    /// DataPager
    /// </summary>
    public partial class DataPager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 7 "..\..\..\..\MyContrlClass\DataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Trace.DataPager dp;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\MyContrlClass\DataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboPageSize;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\MyContrlClass\DataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Trace.MyContrlClass.ImageButton2 btnFirst;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\MyContrlClass\DataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Trace.MyContrlClass.ImageButton2 btnPrev;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\MyContrlClass\DataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPageIndex;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\MyContrlClass\DataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Trace.MyContrlClass.ImageButton2 btnNext;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\MyContrlClass\DataPager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Trace.MyContrlClass.ImageButton2 btnLast;
        
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
            System.Uri resourceLocater = new System.Uri("/Trace;component/mycontrlclass/datapager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MyContrlClass\DataPager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this.dp = ((Trace.DataPager)(target));
            
            #line 9 "..\..\..\..\MyContrlClass\DataPager.xaml"
            this.dp.Loaded += new System.Windows.RoutedEventHandler(this.DataPager_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboPageSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 29 "..\..\..\..\MyContrlClass\DataPager.xaml"
            this.cboPageSize.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbpPageSize_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnFirst = ((Trace.MyContrlClass.ImageButton2)(target));
            return;
            case 4:
            this.btnPrev = ((Trace.MyContrlClass.ImageButton2)(target));
            return;
            case 5:
            this.tbPageIndex = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\..\MyContrlClass\DataPager.xaml"
            this.tbPageIndex.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.tbPageIndex_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\..\MyContrlClass\DataPager.xaml"
            this.tbPageIndex.LostFocus += new System.Windows.RoutedEventHandler(this.tbPageIndex_LostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnNext = ((Trace.MyContrlClass.ImageButton2)(target));
            return;
            case 7:
            this.btnLast = ((Trace.MyContrlClass.ImageButton2)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

