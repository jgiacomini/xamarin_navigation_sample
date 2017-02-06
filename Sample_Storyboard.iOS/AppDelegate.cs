using Foundation;
using UIKit;

namespace Sample_Storyboard.iOS
{
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			// Création du storyboard
			UIStoryboard storyboard = UIStoryboard.FromName("MainStoryboard", null);

			// Création de la fenêtre principale
			var window = new UIWindow(UIScreen.MainScreen.Bounds);

			// Création du ViewController initial
			var mainViewController = storyboard.InstantiateInitialViewController() as UIViewController;

			Window.RootViewController = mainViewController;
			Window.MakeKeyAndVisible();
			return true;
		}
	}
}

