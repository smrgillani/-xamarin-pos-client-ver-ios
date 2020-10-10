using Foundation;
using System;
using UIKit;

namespace iosplease
{
    public partial class ResConfController : UIViewController
    {
        public string PeopleNumberCounter = "";
        public string DatePicker = "";
        public string OptionToSelect = "";
        public ResConfController(IntPtr handle) : base(handle)
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            setNumberofPeople.Text = ": " + PeopleNumberCounter;
            fechasetupdate.Text = ": " + DatePicker;
            setuptheareanow.Text = ": " + OptionToSelect;
            //testinglabelcheck.Text = PeopleNumberCounter + DatePicker + OptionToSelect;
        }
    }
}