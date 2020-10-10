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
    [Register ("SignUpController")]
    partial class SignUpController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnIcon_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SignupBtn_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SignUpEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SignUpFTextO { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SignUpFTextOTT { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SignUpFTextT { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SignUpNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SignUpPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SignUpPasswordA { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView SignupTopBar { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SignupTopText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView SignupView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel topBarText_ { get; set; }

        [Action ("SignupBtn__TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SignupBtn__TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnIcon_ != null) {
                btnIcon_.Dispose ();
                btnIcon_ = null;
            }

            if (SignupBtn_ != null) {
                SignupBtn_.Dispose ();
                SignupBtn_ = null;
            }

            if (SignUpEmail != null) {
                SignUpEmail.Dispose ();
                SignUpEmail = null;
            }

            if (SignUpFTextO != null) {
                SignUpFTextO.Dispose ();
                SignUpFTextO = null;
            }

            if (SignUpFTextOTT != null) {
                SignUpFTextOTT.Dispose ();
                SignUpFTextOTT = null;
            }

            if (SignUpFTextT != null) {
                SignUpFTextT.Dispose ();
                SignUpFTextT = null;
            }

            if (SignUpNumber != null) {
                SignUpNumber.Dispose ();
                SignUpNumber = null;
            }

            if (SignUpPassword != null) {
                SignUpPassword.Dispose ();
                SignUpPassword = null;
            }

            if (SignUpPasswordA != null) {
                SignUpPasswordA.Dispose ();
                SignUpPasswordA = null;
            }

            if (SignupTopBar != null) {
                SignupTopBar.Dispose ();
                SignupTopBar = null;
            }

            if (SignupTopText != null) {
                SignupTopText.Dispose ();
                SignupTopText = null;
            }

            if (SignupView != null) {
                SignupView.Dispose ();
                SignupView = null;
            }

            if (topBarText_ != null) {
                topBarText_.Dispose ();
                topBarText_ = null;
            }
        }
    }
}