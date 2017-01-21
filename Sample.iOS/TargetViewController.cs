using CoreGraphics;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;

namespace Sample.iOS
{

    public class TargetViewController : UIViewController
    {
        private string _data;

        public void Initialize(string data)
        {
            _data = data;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var button = new UILabel();
            button.Text = _data;
            button.Frame = new CGRect(10, 10, View.Bounds.Width, 40);

        }
    }

}
