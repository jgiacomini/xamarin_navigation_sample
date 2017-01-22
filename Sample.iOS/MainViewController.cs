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
            this.View.BackgroundColor = UIColor.Green;
            this.EdgesForExtendedLayout = UIRectEdge.None;
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
            button2.Frame = new CGRect(10, 60, View.Bounds.Width, 40);
            button2.TouchUpInside += NavigationAvecDonnee;


            var button3 = UIButton.FromType(UIButtonType.System);
			button3.SetTitle("Navigation modale", UIControlState.Normal);
			button3.Frame = new CGRect(10, 110, View.Bounds.Width, 40);
			button3.TouchUpInside += NavigationModale;


            View.AddSubviews(button1, button2,button3);


            // EXEMPLE DE CODE DE Sauvegarde d'état
            // Nom de la clef de restauration
            RestorationIdentifier = nameof(MainViewController) + "RestorationId";
            // Définition de la classe restaurée
            RestorationClass = new ObjCRuntime.Class(typeof(MainViewController));
        }

        private void Button_TouchUpInside(object sender, EventArgs e)
        {
            this.NavigationController.PushViewController(new SecondViewController(), true);

        }

        private void NavigationAvecDonnee(object sender, EventArgs e)
        {
            // Perform any additional setup after loading the view, typically from a nib.
            var targetViewController = new TargetViewController();
            // Passage de donnée via la méthode Initialize
            targetViewController.Initialize("donnée à envoyer à la cible");

            // Navigation vers le contrôleur cible
            this.NavigationController.PushViewController(targetViewController, true);
        }


        private void NavigationModale(object sender, EventArgs e)
		{
			this.NavigationController.PresentViewController(new ModalViewController(), true,null);

		}

        #region Sauvegarde et Restauration d'état
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
        #endregion
    }
}