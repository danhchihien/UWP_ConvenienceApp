﻿#pragma checksum "C:\Users\danhc\OneDrive\Desktop\ProjectCSharp\Convenience_App\Convenience_App\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "012ECAD60AEE6647C577E90195698B2F0841656C29FA125716B58C6B7C73BA11"
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
    partial class MainPage : 
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
            case 2: // MainPage.xaml line 12
                {
                    this.MyNavigationView = (global::Windows.UI.Xaml.Controls.NavigationView)(target);
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.MyNavigationView).ItemInvoked += this.MyNavigationView_ItemInvoked;
                    ((global::Windows.UI.Xaml.Controls.NavigationView)this.MyNavigationView).BackRequested += this.MyNavigationView_BackRequested;
                }
                break;
            case 3: // MainPage.xaml line 15
                {
                    this.HomeItem = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 4: // MainPage.xaml line 16
                {
                    this.CalendarItem = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 5: // MainPage.xaml line 18
                {
                    this.PlayItem = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 6: // MainPage.xaml line 20
                {
                    this.CalculatorItem = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 7: // MainPage.xaml line 22
                {
                    this.AddFriendItem = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 8: // MainPage.xaml line 24
                {
                    this.ContactInfoItem = (global::Windows.UI.Xaml.Controls.NavigationViewItem)(target);
                }
                break;
            case 9: // MainPage.xaml line 28
                {
                    this.ContentFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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
