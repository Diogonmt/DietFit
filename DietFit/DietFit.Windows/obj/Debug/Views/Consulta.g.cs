﻿

#pragma checksum "C:\Users\Mário\Source\Repos\DietFit\DietFit\DietFit.Windows\Views\Consulta.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E1AB25D174281F4126BAAB792BE119E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DietFit.Views
{
    partial class Consulta : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 56 "..\..\Views\Consulta.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.Selector)(target)).SelectionChanged += this.listBox_SelectionChanged;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 57 "..\..\Views\Consulta.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.button_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


