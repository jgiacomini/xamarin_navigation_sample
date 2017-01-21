using CoreGraphics;
using System;

using UIKit;

namespace Sample.iOS
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController()
        {
            View.BackgroundColor = UIColor.Green;
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var button1 = UIButton.FromType(UIButtonType.System);
            button1.SetTitle("Navigation", UIControlState.Normal);
            button1.Frame = new CGRect(10, 10, View.Bounds.Width, 40);
            button1.TouchUpInside += Button_TouchUpInside;

            var button2 = UIButton.FromType(UIButtonType.System);
            button2.SetTitle("Navigation avec donnée", UIControlState.Normal);
            button2.Frame = new CGRect(60, 10, View.Bounds.Width, 40);
            button2.TouchUpInside += Button_TouchUpInside;

            View.AddSubviews(button1, button2);
        }

        private void Button_TouchUpInside(object sender, EventArgs e)
        {
            this.NavigationController.PushViewController(new SecondViewController(), true);
        }

        private void Button2_TouchUpInside(object sender, EventArgs e)
        {
            // Perform any additional setup after loading the view, typically from a nib.
            var targetViewController = new TargetViewController();
            // Passage de donnée via la méthode Initialize
            targetViewController.Initialize("donnée à envoyer à la cible");

            // Navigation vers le contrôleur cible
            this.NavigationController.PushViewController(targetViewController, true);
            
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}