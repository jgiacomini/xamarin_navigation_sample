using Foundation;
using UIKit;

namespace Sample_Storyboard.iOS
{


    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
		public override UIWindow Window
		{
			get;
			set;
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            // Création du storyboard
            UIStoryboard storyboard = UIStoryboard.FromName("Main", null);

            // Création de la fenêtre principale
            Window = new UIWindow(UIScreen.MainScreen.Bounds);

            // Création du ViewController initial
            var mainViewController = storyboard.InstantiateInitialViewController();

            Window.RootViewController = mainViewController;
            Window.MakeKeyAndVisible();
            return true;
        }
    }
}

