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
    [Register ("RestuarantsTableViewCell")]
    partial class RestuarantsTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AddressOne { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AddressThree { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel AddressTwo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Heading { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel HeadingSub { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView ImgView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView MainViewCell { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AddressOne != null) {
                AddressOne.Dispose ();
                AddressOne = null;
            }

            if (AddressThree != null) {
                AddressThree.Dispose ();
                AddressThree = null;
            }

            if (AddressTwo != null) {
                AddressTwo.Dispose ();
                AddressTwo = null;
            }

            if (Heading != null) {
                Heading.Dispose ();
                Heading = null;
            }

            if (HeadingSub != null) {
                HeadingSub.Dispose ();
                HeadingSub = null;
            }

            if (ImgView != null) {
                ImgView.Dispose ();
                ImgView = null;
            }

            if (MainViewCell != null) {
                MainViewCell.Dispose ();
                MainViewCell = null;
            }
        }
    }
}