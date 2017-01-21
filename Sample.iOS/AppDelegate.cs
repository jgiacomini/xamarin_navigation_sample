using Foundation;
using UIKit;

namespace Sample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        // Fenêtre principale de l’application
        UIWindow _window;

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            // On précise que la fenêtre prend toute la place de l’écran
            _window = new UIWindow(UIScreen.MainScreen.Bounds);

            // Initialisation du controleur de vue par défaut 
            var viewController = new MainViewController();
            // Initialisation du contrôleur de navigation
            var navigationController = new UINavigationController(viewController);
            _window.RootViewController = navigationController;

            // Affiche la fenêtre principale
            _window.MakeKeyAndVisible();
            return true;
        }
    }

}