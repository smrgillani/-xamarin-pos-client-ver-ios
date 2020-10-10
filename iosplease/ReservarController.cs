using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Drawing;
using CoreAnimation;

namespace iosplease
{
    public partial class ReservarController : UIViewController
    {
        MenuTableSourceClass objMenuTableSource;
        UIImageView topmenulogo = new UIImageView();
        UIView leftmenu = new UIView();
        UITableView menutable = new UITableView();
        string getoptionfrompicker = "";
        public ReservarController (IntPtr handle) : base (handle)
        {
        }
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            FnInitializeView();
            float peoplecounterxvalue = 0;
            float peoplecounterbtnxval = 0;
            float datebtnxvalue = 0;
            float pickercomxvalue = 0;

            if ((float)View.Bounds.Width >= 320 && (float)View.Bounds.Width < 375)
            {
                peoplecounterxvalue = 142;
                peoplecounterbtnxval = 215;
                datebtnxvalue = 88;
                pickercomxvalue = 150;
            }
            else if ((float)View.Bounds.Width >= 375)
            {
                peoplecounterxvalue = 248;
                peoplecounterbtnxval = 306;
                datebtnxvalue = 183;
                pickercomxvalue = 245;

            }

            PeopleNumberCounter.Frame = new RectangleF(peoplecounterxvalue, (float)PeopleNumberCounter.Frame.Y, (float)PeopleNumberCounter.Frame.Width, (float)PeopleNumberCounter.Frame.Height);
            PlusMinusBtnView.Frame = new RectangleF(peoplecounterbtnxval, (float)PlusMinusBtnView.Frame.Y, (float)PlusMinusBtnView.Frame.Width, (float)PlusMinusBtnView.Frame.Height);
            __rserver_top_text_.Frame = new RectangleF(20, (float)__rserver_top_text_.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width - 40, (float)__rserver_top_text_.Frame.Height);
            __rserver_top_text_.LineBreakMode = UILineBreakMode.WordWrap;
            __rserver_top_text_.Lines = 0;
            PlusMinusBtnView.Layer.BorderWidth = 1;
            PlusMinusBtnView.Layer.BorderColor = UIColor.FromRGB(2, 114, 236).CGColor;
            PlusMinusBtnView.Layer.CornerRadius = 5;

            _DatePickerBtn_.Frame = new RectangleF(datebtnxvalue, (float)_DatePickerBtn_.Frame.Y, (float)_DatePickerBtn_.Frame.Width, (float)_DatePickerBtn_.Frame.Height);
            PickAnyOfTheItem.Frame = new RectangleF(pickercomxvalue, (float)PickAnyOfTheItem.Frame.Y, (float)PickAnyOfTheItem.Frame.Width, (float)PickAnyOfTheItem.Frame.Height);
            PickerUIViewInt.Frame = new RectangleF((float)PickerUIViewInt.Frame.X, 239, (float)UIScreen.MainScreen.Bounds.Width, (float)PickerUIViewInt.Frame.Height);
            DatePickerView.Frame = new RectangleF((float)DatePickerView.Frame.X, (float)DatePickerView.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width, (float)DatePickerView.Frame.Height);
            DatePickerView.Hidden = true;
            List<string> listofpickers = new List<string>();
            listofpickers.Add("Terraza");
            listofpickers.Add("sala");
            var pickerModel = new PickerModel(listofpickers);
            pickerModel.selectionchanged += (sender , e)=>{
                getoptionfrompicker = pickerModel.selecteditemname;
            };
            PickAnyOfTheItem.Model = pickerModel;

            _ReserverUIBtn_.Frame = new RectangleF((float)_ReserverUIBtn_.Frame.X+20, (float)_ReserverUIBtn_.Frame.Y, (float)View.Bounds.Width -40, (float)_ReserverUIBtn_.Frame.Height);
            _ReserverUIBtn_.Layer.BorderWidth = 1;
            _ReserverUIBtn_.Layer.BorderColor = UIColor.FromRGB(66, 66, 66).CGColor;
            _ReserverUIBtn_.Layer.BackgroundColor = UIColor.FromRGB(68, 38, 160).CGColor;
            _ReserverUIBtn_.Layer.CornerRadius = 5;


            ReserverMainTouchView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
            topmenulogo.Image = UIImage.FromBundle("logoonmenu.png");
            topmenulogo.Frame = new RectangleF(92, 30, 66, 66);
            leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
            menutable.Frame = new RectangleF(0, 110, 250, 132);
            TopNavBar_.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            leftmenu.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            menutable.ScrollEnabled = false;
            menutable.SeparatorStyle = UITableViewCellSeparatorStyle.None;

            leftmenu.Add(topmenulogo);
            leftmenu.Add(menutable);
            leftmenu.Hidden = true;
            View.Add(leftmenu);
            FnBindMenu();
            leftmenu.Hidden = false;
        }

        partial void DateTime_Changed(UIDatePicker sender)
        {
            DateTime tm = new DateTime();
            tm = DateTime.Now;
            tm = (DateTime)sender.Date;
            string selection = tm.ToString("dd MMM yyyy HH:mm");
            _DatePickerBtn_.TitleLabel.Text = selection;
        }


        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            base.TouchesBegan(touches, evt);

            UITouch touch = touches.AnyObject as UITouch;
            if (touch != null)
            {

                var touchLocation = touch.LocationInView(View);

                if (touchLocation.X >= 250 && touchLocation.Y >= 22)
                {
                    DatePickerView.Hidden = true;
                    PickerUIViewInt.Frame = new RectangleF((float)PickerUIViewInt.Frame.X, 239, (float)UIScreen.MainScreen.Bounds.Width, (float)PickerUIViewInt.Frame.Height);
                    if (leftmenu.Frame.X >= 0)
                    {
                        leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                        ReserverMainTouchView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                    }

                }
            }
        }

        partial void PlusMinusBtnsPlus_TouchUpInside(UIButton sender)
        {
            PeopleNumberCounter.Text = (Convert.ToInt16(PeopleNumberCounter.Text) + 1).ToString();
        }

        partial void PlusMinusBtnsMinus_TouchUpInside(UIButton sender)
        {
            PeopleNumberCounter.Text = (Convert.ToInt16(PeopleNumberCounter.Text) == 0 ? "0" : (Convert.ToInt16(PeopleNumberCounter.Text) - 1).ToString());
        }

        partial void _DatePickerBtn__TouchUpInside(UIButton sender)
        {
            DatePickerView.Hidden = false;
            PickerUIViewInt.Frame = new RectangleF((float)PickerUIViewInt.Frame.X, 360, (float)UIScreen.MainScreen.Bounds.Width, (float)PickerUIViewInt.Frame.Height);

        }

        void FnInitializeView()
        {
            var recognizerRight = new UISwipeGestureRecognizer(FnSwipeLeftToRight);
            recognizerRight.Direction = UISwipeGestureRecognizerDirection.Right;
            View.AddGestureRecognizer(recognizerRight);

            var recognizerLeft = new UISwipeGestureRecognizer(FnSwipeRightToLeft);
            recognizerLeft.Direction = UISwipeGestureRecognizerDirection.Left;
            View.AddGestureRecognizer(recognizerLeft);
            btn_Icon.SetBackgroundImage(UIImage.FromBundle("Menu.png"), UIControlState.Normal);

            btn_Icon.TouchUpInside += delegate (object sender, EventArgs e)
            {

                if (leftmenu.Frame.X >= 0)
                {
                    leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    ReserverMainTouchView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                }
                else
                {
                    leftmenu.Frame = new RectangleF(0, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    ReserverMainTouchView.Frame = new RectangleF(250, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                }
                //leftmenu.Hidden = false;

                //FnPerformTableTransition();
            };

        }

        void FnSwipeLeftToRight()
        {
            if (leftmenu.Hidden)
                FnPerformTableTransition();

        }

        void FnSwipeRightToLeft()
        {
            if (!leftmenu.Hidden)
                FnPerformTableTransition();
        }
        void FnPerformTableTransition()
        {
            leftmenu.Hidden = !leftmenu.Hidden;
            var transition = new CATransition();
            transition.Duration = 0.25f;
            transition.Type = CAAnimation.TransitionPush;
            if (leftmenu.Hidden)
            {
                transition.TimingFunction = CAMediaTimingFunction.FromName(new Foundation.NSString("easeOut"));
                transition.Subtype = CAAnimation.TransitionFromRight;
            }
            else
            {
                transition.TimingFunction = CAMediaTimingFunction.FromName(new Foundation.NSString("easeIn"));
                transition.Subtype = CAAnimation.TransitionFromLeft;
            }
            leftmenu.Layer.AddAnimation(transition, null);
        }
        void FnBindMenu()
        {
            if (objMenuTableSource != null)
            {
                objMenuTableSource.MenuSelected -= FnMenuSelected;
                objMenuTableSource = null;
            }
            objMenuTableSource = new MenuTableSourceClass();
            objMenuTableSource.MenuSelected += FnMenuSelected;
            menutable.Source = objMenuTableSource;
        }
        void FnMenuSelected(string strMenuSeleted)
        {
            if (strMenuSeleted.Equals("RESERVAR"))
            {
                //PerformSegue("LinkDashboardToReserver", this);
                FnSwipeRightToLeft();
            }
        }
        void FnAnimateView(nfloat frameY, UIView view)
        {
            UIView.Animate(0.2f, 0.1f, UIViewAnimationOptions.CurveEaseIn, delegate
            {
                var frame = View.Frame;
                frame.Y = frameY;
                view.Frame = frame;
            }, null);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void _ReserverUIBtn__TouchUpInside(UIButton sender)
        {
            //string myData = "";
            //var myViewController = new ResConfController(0);
            //this.PresentViewController(myViewController, true,null);

            ResConfController controller = this.Storyboard.InstantiateViewController("ResConfController") as ResConfController;
            //Here you pass the data from the registerViewController to the secondViewController
            controller.PeopleNumberCounter = PeopleNumberCounter.Text;
            controller.DatePicker = _DatePickerBtn_.TitleLabel.Text;
            controller.OptionToSelect = getoptionfrompicker;

            this.NavigationController.PushViewController(controller, true);

        }
    }
}