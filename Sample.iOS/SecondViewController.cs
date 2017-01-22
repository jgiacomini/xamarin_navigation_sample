using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UIKit;

namespace Sample.iOS
{
    public class SecondViewController : UIViewController
    {
        public SecondViewController()
        {
            View.BackgroundColor = UIColor.Purple;
            this.EdgesForExtendedLayout = UIRectEdge.None;
        }
    }
}