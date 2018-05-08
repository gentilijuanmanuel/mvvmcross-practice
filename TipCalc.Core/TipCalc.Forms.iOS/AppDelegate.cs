using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using TipCalc.Core;
using TipCalc.Forms.UI;
using UIKit;

namespace TipCalc.Forms.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<App, FormsApp>, App, FormsApp>
    {
        // class-level declarations

        public override UIWindow Window
        {
            get;
            set;
        }

        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            // Override point for customization after application launch.
            // If not required for your application you can safely delete this method

            return base.FinishedLaunching(uiApplication, launchOptions);
        }

    }
}

