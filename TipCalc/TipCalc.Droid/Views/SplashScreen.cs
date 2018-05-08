using Android.App;
using MvvmCross.Platforms.Android.Views;
using TipCalc.Droid;

namespace CalcApp.UI.Droid
{
    [Activity(Label = "My App", MainLauncher = true, NoHistory = true)]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}