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

        public TargetViewController()
        {
            this.EdgesForExtendedLayout = UIRectEdge.None;
        }

        public void Initialize(string data)
        {
            _data = data;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var label = new UILabel();
            label.Text = _data;
            label.Frame = new CGRect(10, 10, View.Bounds.Width, 40);
        }
    }

}
