using CoreGraphics;
using Foundation;
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


            // EXEMPLE DE CODE DE Sauvegarde d'état
            // Nom de la clef de restauration
            RestorationIdentifier = nameof(MainViewController) + "RestorationId";
            // Définition de la classe restaurée
            RestorationClass = new ObjCRuntime.Class(typeof(MainViewController));
        }

        private int _nbTimeViewControllerDisplayed = 1;


        public override void EncodeRestorableState(NSCoder coder)
        {
            coder.Encode(_nbTimeViewControllerDisplayed, "NbTimeViewControllerDisplayed");
            base.EncodeRestorableState(coder);
        }

        public override void DecodeRestorableState(NSCoder coder)
        {
            _nbTimeViewControllerDisplayed = coder.DecodeInt("NbTimeViewControllerDisplayed");
            base.DecodeRestorableState(coder);
        }

        public override void ApplicationFinishedRestoringState()
        {
            _nbTimeViewControllerDisplayed++;
            base.ApplicationFinishedRestoringState();
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