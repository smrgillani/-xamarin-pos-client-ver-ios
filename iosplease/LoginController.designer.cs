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
    [Register ("LoginController")]
    partial class LoginController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField EmailText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton LoginBtn { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView LoginUpperIamge { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PasswordText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SignupBtn { get; set; }

        [Action ("LoginBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void LoginBtn_TouchUpInside (UIKit.UIButton sender);

        [Action ("SignupBtn_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SignupBtn_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (EmailText != null) {
                EmailText.Dispose ();
                EmailText = null;
            }

            if (LoginBtn != null) {
                LoginBtn.Dispose ();
                LoginBtn = null;
            }

            if (LoginUpperIamge != null) {
                LoginUpperIamge.Dispose ();
                LoginUpperIamge = null;
            }

            if (PasswordText != null) {
                PasswordText.Dispose ();
                PasswordText = null;
            }

            if (SignupBtn != null) {
                SignupBtn.Dispose ();
                SignupBtn = null;
            }
        }
    }
}