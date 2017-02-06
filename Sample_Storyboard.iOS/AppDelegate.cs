using Foundation;
using UIKit;

namespace Sample_Storyboard.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window
		{
			get;
			set;
		}

		public static UIViewController initialViewController;

		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			// Création du storyboard
			UIStoryboard storyboard = UIStoryboard.FromName("MainStoryboard", null);

			// Création de la fenêtre principale
			Window = new UIWindow(UIScreen.MainScreen.Bounds);

			// Création du ViewController initial
			var mainViewController = storyboard.InstantiateInitialViewController() as UIViewController;

			Window.RootViewController = initialViewController;
			Window.MakeKeyAndVisible();
			return true;
		}

	}
}

