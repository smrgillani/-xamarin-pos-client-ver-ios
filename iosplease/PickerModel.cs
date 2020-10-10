using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace iosplease
{
    public class PickerModel : UIPickerViewModel
    {

        private List<string> _myItems;
        protected int selectedIndex = 0;
        public string selecteditemname { get; private set; }
        public event EventHandler selectionchanged;

        public PickerModel(List<string> items)
        {
            this._myItems = items;
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 2;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return _myItems.Count();
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            if (component == 0)
                return _myItems[Convert.ToInt32(row)];
            else
                return row.ToString();
        }

        public override void Selected(UIPickerView pickerView, nint row, nint component)
        {
            var itemtext = _myItems[Convert.ToInt32(row)];
            selecteditemname = itemtext;
            selectionchanged?.Invoke(null,null);
            //personLabel.Text = $"This person is: {_myItems[Convert.ToInt32(pickerView.SelectedRowInComponent(0))]},\n they are number {pickerView.SelectedRowInComponent(1)}";
        }

        public override nfloat GetComponentWidth(UIPickerView picker, nint component)
        {
            if (component == 0)
                return 240f;
            else
                return 40f;
        }

        public override nfloat GetRowHeight(UIPickerView picker, nint component)
        {
            return 40f;
        }
    }
}