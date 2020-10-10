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
    [Register ("ResConfController")]
    partial class ResConfController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel fechasetupdate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel restaurenttxt_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel setNumberofPeople { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel setuptheareanow { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (fechasetupdate != null) {
                fechasetupdate.Dispose ();
                fechasetupdate = null;
            }

            if (restaurenttxt_ != null) {
                restaurenttxt_.Dispose ();
                restaurenttxt_ = null;
            }

            if (setNumberofPeople != null) {
                setNumberofPeople.Dispose ();
                setNumberofPeople = null;
            }

            if (setuptheareanow != null) {
                setuptheareanow.Dispose ();
                setuptheareanow = null;
            }
        }
    }
}