using CoreAnimation;
using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace iosplease
{
    public partial class SignUpController : UIViewController
    {
        MenuTableSourceClass objMenuTableSource;
        UIImageView topmenulogo = new UIImageView();
        UIView leftmenu = new UIView();
        UITableView menutable = new UITableView();

        public SignUpController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            float textfieldstm = 0;

            if ((float)View.Bounds.Width >= 320 && (float)View.Bounds.Width < 375)
            {
                textfieldstm = 70;
            }
            else if ((float)View.Bounds.Width >= 375)
            {


            }
            
            float marginoftf = 20;
            SignupTopText.Frame = new RectangleF((float)SignupTopText.Frame.X, (float)SignupTopText.Frame.Y - textfieldstm, (float)View.Bounds.Width, (float)SignupTopText.Frame.Height);
            SignUpNumber.Frame = new RectangleF((float)SignUpNumber.Frame.X + marginoftf, (float)SignUpNumber.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, 40);
            SignUpEmail.Frame = new RectangleF((float)SignUpEmail.Frame.X + marginoftf, (float)SignUpEmail.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, 40);
            SignUpPassword.Frame = new RectangleF((float)SignUpPassword.Frame.X + marginoftf, (float)SignUpPassword.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, 40);
            SignUpPasswordA.Frame = new RectangleF((float)SignUpPasswordA.Frame.X + marginoftf, (float)SignUpPasswordA.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, 40);


            SignUpNumber.Layer.BorderWidth = 1;
            SignUpNumber.Layer.BorderColor = UIColor.FromRGB(252, 189, 82).CGColor;
            SignUpNumber.Layer.CornerRadius = 5;

            SignUpEmail.Layer.BorderWidth = 1;
            SignUpEmail.Layer.BorderColor = UIColor.FromRGB(252, 189, 82).CGColor;
            SignUpEmail.Layer.CornerRadius = 5;

            SignUpPassword.Layer.BorderWidth = 1;
            SignUpPassword.Layer.BorderColor = UIColor.FromRGB(252, 189, 82).CGColor;
            SignUpPassword.Layer.CornerRadius = 5;

            SignUpPasswordA.Layer.BorderWidth = 1;
            SignUpPasswordA.Layer.BorderColor = UIColor.FromRGB(252, 189, 82).CGColor;
            SignUpPasswordA.Layer.CornerRadius = 5;

            SignUpFTextO.Frame = new RectangleF((float)SignUpFTextO.Frame.X, (float)SignUpFTextO.Frame.Y - textfieldstm, (float)View.Bounds.Width,(float)SignUpFTextO.Frame.Height);
            SignUpFTextT.Frame = new RectangleF((float)SignUpFTextT.Frame.X, (float)SignUpFTextT.Frame.Y - textfieldstm, (float)View.Bounds.Width, (float)SignUpFTextT.Frame.Height);
            SignUpFTextOTT.Frame = new RectangleF((float)SignUpFTextOTT.Frame.X, (float)SignUpFTextOTT.Frame.Y - textfieldstm, (float)View.Bounds.Width, (float)SignUpFTextOTT.Frame.Height);


            SignupBtn_.Frame = new RectangleF((float)SignupBtn_.Frame.X + marginoftf, (float)SignupBtn_.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, (float)SignupBtn_.Frame.Height);
            SignupBtn_.Layer.BorderWidth = 1;
            SignupBtn_.Layer.BorderColor = UIColor.FromRGB(66, 66, 66).CGColor;
            SignupBtn_.Layer.BackgroundColor = UIColor.FromRGB(68, 38, 160).CGColor;
            SignupBtn_.Layer.CornerRadius = 5;


            FnInitializeView();


            SignupView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
            topmenulogo.Image = UIImage.FromBundle("logoonmenu.png");
            topmenulogo.Frame = new RectangleF(92, 30, 66, 66);
            leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
            menutable.Frame = new RectangleF(0, 110, 250, 132);
            SignupTopBar.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            leftmenu.Layer.BackgroundColor = UIColor.FromRGB(234, 132, 53).CGColor;
            //ResListTable.Frame = new RectangleF((float)DashboardMainView.Frame.X, (float)ResListTable.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height + 4000);
            menutable.ScrollEnabled = false;
            menutable.SeparatorStyle = UITableViewCellSeparatorStyle.None;

            leftmenu.Add(topmenulogo);
            leftmenu.Add(menutable);
            leftmenu.Hidden = true;
            View.Add(leftmenu);
            FnBindMenu();
            leftmenu.Hidden = false;
        }

        partial void SignupBtn__TouchUpInside(UIButton sender)
        {
            UIAlertView alert = new UIAlertView("Confirmación de Cuenta", "En breve recibirás un correo electrónico con la confirmación de tu cuenta.", null, NSBundle.MainBundle.LocalizedString("Aceptar", "Aceptar"));
            alert.Show();

            PerformSegue("LinkSignUpToDashboard", this);
        }
             

        void FnInitializeView()
        {
            var recognizerRight = new UISwipeGestureRecognizer(FnSwipeLeftToRight);
            recognizerRight.Direction = UISwipeGestureRecognizerDirection.Right;
            View.AddGestureRecognizer(recognizerRight);

            var recognizerLeft = new UISwipeGestureRecognizer(FnSwipeRightToLeft);
            recognizerLeft.Direction = UISwipeGestureRecognizerDirection.Left;
            View.AddGestureRecognizer(recognizerLeft);
            btnIcon_.SetBackgroundImage(UIImage.FromBundle("Menu.png"), UIControlState.Normal);

            btnIcon_.TouchUpInside += delegate (object sender, EventArgs e)
            {

                if (leftmenu.Frame.X >= 0)
                {
                    leftmenu.Frame = new RectangleF(-250, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    SignupView.Frame = new RectangleF(0, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
                }
                else
                {
                    leftmenu.Frame = new RectangleF(0, 0, 250, (float)UIScreen.MainScreen.Bounds.Height);
                    SignupView.Frame = new RectangleF(250, 0, (float)UIScreen.MainScreen.Bounds.Width, (float)UIScreen.MainScreen.Bounds.Height);
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
                FnSwipeRightToLeft();
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