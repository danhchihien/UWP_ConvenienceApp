﻿#pragma checksum "C:\Users\danhc\OneDrive\Desktop\ProjectCSharp\Convenience_App\Convenience_App\CalendarPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3C4F98332125C9102296064F6D1DF8E015A4871EEAA7413A555456534F194C2E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Convenience_App
{
    partial class CalendarPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // CalendarPage.xaml line 16
                {
                    this.Picker = (global::Windows.UI.Xaml.Controls.CalendarDatePicker)(target);
                    ((global::Windows.UI.Xaml.Controls.CalendarDatePicker)this.Picker).DateChanged += this.Picker_DateChanged;
                }
                break;
            case 3: // CalendarPage.xaml line 18
                {
                    this.Display = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.Display).Loaded += this.Display_Loaded;
                }
                break;
            case 4: // CalendarPage.xaml line 49
                {
                    this.Add = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.Add).Click += this.Add_Click;
                }
                break;
            case 6: // CalendarPage.xaml line 41
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element6 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element6).Click += this.Edit_Click;
                }
                break;
            case 7: // CalendarPage.xaml line 42
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.Delete_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 0.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

