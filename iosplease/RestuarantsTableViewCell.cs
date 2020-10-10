using System;
using System.Drawing;
using Foundation;
using UIKit;

namespace iosplease
{
    public partial class RestuarantsTableViewCell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("RestuarantsTableViewCell");
        public static readonly UINib Nib;

        static RestuarantsTableViewCell()
        {
            Nib = UINib.FromName("RestuarantsTableViewCell", NSBundle.MainBundle);
        }

        protected RestuarantsTableViewCell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public static RestuarantsTableViewCell Create()
        {
            return (RestuarantsTableViewCell)Nib.Instantiate(null, null)[0];
        }

        internal void BindData(string heading, string subheading , string addressone , string addresstwo , string addressthree , string imagename)
        {
            Heading.Text = heading;
            HeadingSub.Text = subheading;
            AddressOne.Text = addressone;
            AddressTwo.Text = addresstwo;
            AddressThree.Text = addressthree;
            ImgView.Image = UIImage.FromBundle(imagename);
            ImgView.Frame = new RectangleF((float)ImgView.Frame.X,(float)ImgView.Frame.Y,(float)UIScreen.MainScreen.Bounds.Width,(float)ImgView.Frame.Height);
            MainViewCell.Frame = new RectangleF((float)MainViewCell.Frame.X, (float)MainViewCell.Frame.Y, (float)UIScreen.MainScreen.Bounds.Width, (float)MainViewCell.Frame.Height);
        }
    }
}
