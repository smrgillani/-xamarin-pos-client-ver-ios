// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace iosplease
{
    [Register ("MenuTableViewCell")]
    partial class MenuTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView imgViewMenuIcon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblMenuText { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (imgViewMenuIcon != null) {
                imgViewMenuIcon.Dispose ();
                imgViewMenuIcon = null;
            }

            if (lblMenuText != null) {
                lblMenuText.Dispose ();
                lblMenuText = null;
            }
        }
    }
}