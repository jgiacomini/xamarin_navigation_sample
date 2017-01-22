using CoreGraphics;
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

            var buttonBack = UIButton.FromType(UIButtonType.System);
            buttonBack.SetTitle("Bouton retour", UIControlState.Normal);
            buttonBack.Frame = new CGRect(0, 0, View.Bounds.Width, 40);
            buttonBack.TouchUpInside += ButtonBack_TouchUpInside;
            this.View.AddSubview(buttonBack);
        }

        private void ButtonBack_TouchUpInside(object sender, EventArgs e)
        {
            NavigationController.PopViewController(true);
        }
    }
}