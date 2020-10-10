using Foundation;
using System;
using System.Drawing;
using UIKit;

namespace iosplease
{
    public partial class LoginController : UIViewController
    {
        public LoginController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.NavigationItem.SetHidesBackButton(true, false);
            UIApplication.SharedApplication.SetStatusBarHidden(true, true);
            NavigationController.SetNavigationBarHidden(true, true);

            float imageheight = 0;
            float textfieldstm = 0;

            if ((float)View.Bounds.Width >= 320 && (float)View.Bounds.Width < 375)
            {
                imageheight = 150;
                textfieldstm = 100;
            }
            else if ((float)View.Bounds.Width >= 375)
            {
                imageheight = 270;

            }
            //var LoginUpperIamge_ = new UIImageView(new CoreGraphics.CGRect(0, 0, View.Bounds.Width, View.Bounds.Height));
            //LoginUpperIamge.Frame = new CGRect(0, 0, View.Bounds.Width, View.Bounds.Height);
            LoginUpperIamge.Frame = new RectangleF(0, 0, (float)View.Bounds.Width, imageheight);
            LoginUpperIamge.Image = UIImage.FromBundle("logoupperimage.png");
            LoginUpperIamge.ContentMode = UIViewContentMode.ScaleAspectFill;


            View.AddConstraints(new NSLayoutConstraint[] {
                NSLayoutConstraint.Create(LoginUpperIamge,NSLayoutAttribute.CenterX, NSLayoutRelation.Equal, LoginUpperIamge, NSLayoutAttribute.CenterX, 1f, 0f),
                NSLayoutConstraint.Create(LoginUpperIamge,NSLayoutAttribute.CenterY, NSLayoutRelation.Equal, LoginUpperIamge, NSLayoutAttribute.CenterY, 1f, 0f),
                NSLayoutConstraint.Create(LoginUpperIamge,NSLayoutAttribute.Width, NSLayoutRelation.Equal, LoginUpperIamge, NSLayoutAttribute.Width, .5f, 0f),
                NSLayoutConstraint.Create(LoginUpperIamge,NSLayoutAttribute.Height, NSLayoutRelation.Equal, LoginUpperIamge, NSLayoutAttribute.Height, .5f, 0f)});

            float marginoftf = 20;
            EmailText.Frame = new RectangleF((float)EmailText.Frame.X + marginoftf, (float)EmailText.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, 40);
            PasswordText.Frame = new RectangleF((float)PasswordText.Frame.X + marginoftf, (float)PasswordText.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, 40);
            EmailText.Layer.BorderWidth = 1;
            EmailText.Layer.BorderColor = UIColor.FromRGB(252, 189, 82).CGColor;
            EmailText.Layer.CornerRadius = 5;
            PasswordText.Layer.BorderWidth = 1;
            PasswordText.Layer.BorderColor = UIColor.FromRGB(252, 189, 82).CGColor;
            PasswordText.Layer.CornerRadius = 5;

            LoginBtn.Frame = new RectangleF((float)LoginBtn.Frame.X + marginoftf, (float)LoginBtn.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, (float)LoginBtn.Frame.Height);
            SignupBtn.Frame = new RectangleF((float)SignupBtn.Frame.X + marginoftf, (float)SignupBtn.Frame.Y - textfieldstm, (float)View.Bounds.Width - marginoftf - marginoftf, (float)SignupBtn.Frame.Height);
            LoginBtn.Layer.BorderWidth = 1;
            LoginBtn.Layer.BorderColor = UIColor.FromRGB(68, 38, 160).CGColor;
            LoginBtn.Layer.BackgroundColor = UIColor.FromRGB(68, 38, 160).CGColor;
            LoginBtn.Layer.CornerRadius = 5;
            SignupBtn.Layer.BorderWidth = 1;
            SignupBtn.Layer.BorderColor = UIColor.FromRGB(66, 66, 66).CGColor;
            SignupBtn.Layer.BackgroundColor = UIColor.FromRGB(66, 66, 66).CGColor;
            SignupBtn.Layer.CornerRadius = 5;

            //EmailText.Text = (LoginUpperIamge.Frame.Height).ToString();
            //View.AddConstraint(NSLayoutConstraint.Create(EmailText, NSLayoutAttribute.Width, NSLayoutRelation.Equal, null, NSLayoutAttribute.Width, 1, 250.0f));
            //View.AddConstraints(new NSLayoutConstraint[] {
            //    NSLayoutConstraint.Create(EmailText,NSLayoutAttribute.Width, NSLayoutRelation.Equal, EmailText, NSLayoutAttribute.Width, 0f, 0f),
            //    NSLayoutConstraint.Create(EmailText,NSLayoutAttribute.Height, NSLayoutRelation.Equal, EmailText, NSLayoutAttribute.Height, 0f, 0f)});

            //LoginUpperIamge = LoginUpperIamge_;
            //View.Add(LoginUpperIamge_);
            //  var imagewidth = NavigationController.NavigationBar.Frame.Width;
            // var imageheight = NavigationController.NavigationBar.Frame.Height;
            // LoginUpperIamge.Frame = new CGRect(  x, y, imagewidth, imageheight);
            // LoginUpperIamge.ContentMode = UIViewContentMode.ScaleAspectFit;

            // UserText.Text = UIDevice.CurrentDevice.Model + UIScreen.MainScreen.Bounds.Width;
            // LoginUpperIamge.WidthRequest = 0;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void LoginBtn_TouchUpInside(UIButton sender)
        {
            PerformSegue("LinkToDashboard", this);
        }

        partial void SignupBtn_TouchUpInside(UIButton sender)
        {
            PerformSegue("LinkToSignup", this);
        }

        //partial void LoginBtn_TouchUpInside(UIButton sender)
        //{
        //    PerformSegue("thisisjustexm", this);
        //}
    }
}