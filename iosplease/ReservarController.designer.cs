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
    [Register ("ReservarController")]
    partial class ReservarController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel __PersonReserverLabel_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView __Reserver_Persons_Label_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel __rserver_top_text_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _DatePickerBtn_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton _ReserverUIBtn_ { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btn_Icon { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIDatePicker DatePickerCompo { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView DatePickerView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PeopleNumberCounter { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView PickAnyOfTheItem { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView PickerUIViewInt { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PlusMinusBtnsMinus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton PlusMinusBtnsPlus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView PlusMinusBtnView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ReserverMainTouchView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView TopNavBar_ { get; set; }

        [Action ("_DatePickerBtn__TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _DatePickerBtn__TouchUpInside (UIKit.UIButton sender);

        [Action ("_ReserverUIBtn__TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void _ReserverUIBtn__TouchUpInside (UIKit.UIButton sender);

        [Action ("DateTime_Changed:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DateTime_Changed (UIKit.UIDatePicker sender);

        [Action ("PlusMinusBtnsMinus_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PlusMinusBtnsMinus_TouchUpInside (UIKit.UIButton sender);

        [Action ("PlusMinusBtnsPlus_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PlusMinusBtnsPlus_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (__PersonReserverLabel_ != null) {
                __PersonReserverLabel_.Dispose ();
                __PersonReserverLabel_ = null;
            }

            if (__Reserver_Persons_Label_ != null) {
                __Reserver_Persons_Label_.Dispose ();
                __Reserver_Persons_Label_ = null;
            }

            if (__rserver_top_text_ != null) {
                __rserver_top_text_.Dispose ();
                __rserver_top_text_ = null;
            }

            if (_DatePickerBtn_ != null) {
                _DatePickerBtn_.Dispose ();
                _DatePickerBtn_ = null;
            }

            if (_ReserverUIBtn_ != null) {
                _ReserverUIBtn_.Dispose ();
                _ReserverUIBtn_ = null;
            }

            if (btn_Icon != null) {
                btn_Icon.Dispose ();
                btn_Icon = null;
            }

            if (DatePickerCompo != null) {
                DatePickerCompo.Dispose ();
                DatePickerCompo = null;
            }

            if (DatePickerView != null) {
                DatePickerView.Dispose ();
                DatePickerView = null;
            }

            if (PeopleNumberCounter != null) {
                PeopleNumberCounter.Dispose ();
                PeopleNumberCounter = null;
            }

            if (PickAnyOfTheItem != null) {
                PickAnyOfTheItem.Dispose ();
                PickAnyOfTheItem = null;
            }

            if (PickerUIViewInt != null) {
                PickerUIViewInt.Dispose ();
                PickerUIViewInt = null;
            }

            if (PlusMinusBtnsMinus != null) {
                PlusMinusBtnsMinus.Dispose ();
                PlusMinusBtnsMinus = null;
            }

            if (PlusMinusBtnsPlus != null) {
                PlusMinusBtnsPlus.Dispose ();
                PlusMinusBtnsPlus = null;
            }

            if (PlusMinusBtnView != null) {
                PlusMinusBtnView.Dispose ();
                PlusMinusBtnView = null;
            }

            if (ReserverMainTouchView != null) {
                ReserverMainTouchView.Dispose ();
                ReserverMainTouchView = null;
            }

            if (TopNavBar_ != null) {
                TopNavBar_.Dispose ();
                TopNavBar_ = null;
            }
        }
    }
}