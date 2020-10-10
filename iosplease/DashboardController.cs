using CoreAnimation;
using CoreGraphics;
using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace iosplease
{
    public partial class DashboardController : UIViewController
    {
        MenuTableSourceClass objMenuTableSource;
        RestuarentsTableSource objResTableSource;
        UIImageView topmenulogo = new UIImageView();
        UIView leftmenu = new UIView();
        UITableView menutable = new UITableView();

        public DashboardController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            FnInitializeView();
            
            DashboardMainView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
            topmenulogo.Image = UIImage.FromBundle("logoonmenu.png");
            topmenulogo.Frame = new RectangleF(92, 30, 66, 66);
            leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
            menutable.Frame = new RectangleF(0, 110, 250, 132);
            TopNavBar.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            leftmenu.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            ResListTable.Frame = new RectangleF((float)ResListTable.Frame.X, (float)ResListTable.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width, (float)ResListTable.Frame.Height);
            menutable.ScrollEnabled = false;
            menutable.SeparatorStyle = UITableViewCellSeparatorStyle.None;
            
            leftmenu.Add(topmenulogo);
            leftmenu.Add(menutable);
            leftmenu.Hidden = true;
            View.Add(leftmenu);
            FnBindMenu();
            FnBindResTable();
            leftmenu.Hidden = false;

        }

        void FnBindResTable()
        {
            if (objResTableSource != null)
            {
                //objResTableSource.MenuSelected -= FnMenuSelected;
                objResTableSource = null;
            }
            objResTableSource = new RestuarentsTableSource();
            var sizeofscreen = objResTableSource.GetTotalRows();
            objResTableSource.MenuSelected += FnMenuSelected;
            ResListTable.Source = objResTableSource;
            ResListTable.ContentInset = new UIEdgeInsets(0, 0, ResListTable.Frame.Size.Height - 150, 0);
            //ResListTable.ScrollToRow(sizeofscreen, UITableViewScrollPosition.Middle, true);
            //ResListTable.SetContentOffset(new CGPoint(0, ResListTable.ContentSize.Height - ResListTable.Frame.Size.Height), true);
            //ResListTable.ScrollToRow(NSIndexPath.Create(sizeofscreen), UITableViewScrollPosition.Bottom, false);
            ResListTable.ReloadData();
        }

        void FnInitializeView()
        {
            var recognizerRight = new UISwipeGestureRecognizer(FnSwipeLeftToRight);
            recognizerRight.Direction = UISwipeGestureRecognizerDirection.Right;
            View.AddGestureRecognizer(recognizerRight);

            var recognizerLeft = new UISwipeGestureRecognizer(FnSwipeRightToLeft);
            recognizerLeft.Direction = UISwipeGestureRecognizerDirection.Left;
            View.AddGestureRecognizer(recognizerLeft);
            btnIcon.SetBackgroundImage(UIImage.FromBundle("Menu.png"), UIControlState.Normal);

            btnIcon.TouchUpInside += delegate (object sender, EventArgs e)
            {

                if (leftmenu.Frame.X >= 0)
                {
                    leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    DashboardMainView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                }
                else
                {
                    leftmenu.Frame = new RectangleF(0, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    DashboardMainView.Frame = new RectangleF(250, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
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
                PerformSegue("LinkDashboardToReserver", this);
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
    }
}