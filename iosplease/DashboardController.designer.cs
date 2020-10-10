// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace iosplease
{
    [Register ("DashboardController")]
    partial class DashboardController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView DashboardMainView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ResListTable { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView TopNavBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel txtActionBarText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnIcon != null) {
                btnIcon.Dispose ();
                btnIcon = null;
            }

            if (DashboardMainView != null) {
                DashboardMainView.Dispose ();
                DashboardMainView = null;
            }

            if (ResListTable != null) {
                ResListTable.Dispose ();
                ResListTable = null;
            }

            if (TopNavBar != null) {
                TopNavBar.Dispose ();
                TopNavBar = null;
            }

            if (txtActionBarText != null) {
                txtActionBarText.Dispose ();
                txtActionBarText = null;
            }
        }
    }
}