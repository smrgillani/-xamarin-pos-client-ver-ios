using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace iosplease
{
    public class RestuarentsTableSource : UITableViewSource
    {
        readonly string[] nameHeading;
        readonly string[] nameHeadingSub;
        readonly string[] addressOne;
        readonly string[] addressTwo;
        readonly string[] addressThree;
        readonly string[] tableimgIcon;
        internal event Action<string> MenuSelected;

        public RestuarentsTableSource()
        {
            nameHeading = ResConstants.nameHeading;
            nameHeadingSub = ResConstants.nameHeadingSub;
            addressOne = ResConstants.addressOne;
            addressTwo = ResConstants.addressTwo;
            addressThree = ResConstants.addressThree;
            tableimgIcon = ResConstants.tableimgIcon;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return nameHeading.Length;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            RestuarantsTableViewCell cell = tableView.DequeueReusableCell(RestuarantsTableViewCell.Key) as RestuarantsTableViewCell ?? RestuarantsTableViewCell.Create();
            cell.BindData(nameHeading[indexPath.Row],nameHeadingSub[indexPath.Row],addressOne[indexPath.Row],addressTwo[indexPath.Row],addressThree[indexPath.Row],tableimgIcon[indexPath.Row]);
            
            //cell.SeparatorInset = UIEdgeInsetsMake(0, 0, 0, CGRectGetWidth(tableView.bounds));

            return cell;
        }

        public int GetTotalRows()
        {
            return nameHeading.Length;
        }

        public override void RowSelected(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            if (MenuSelected != null)
                MenuSelected(nameHeading[indexPath.Row]);

            tableView.DeselectRow(indexPath, true);
        }

        public override UIView GetViewForFooter(UITableView tableView, nint section)
        {
            return new UIView();
        }
    }
}