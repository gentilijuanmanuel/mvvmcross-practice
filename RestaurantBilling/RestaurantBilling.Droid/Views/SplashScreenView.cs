
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross.Platforms.Android.Views;

namespace RestaurantBilling.Droid.Views
{
    [Activity(Label = "Restaurant Billing", MainLauncher = true, NoHistory = true)]
    public class SplashScreenView : MvxSplashScreenActivity
    {
        public SplashScreenView() : base(Resource.Layout.SplashScreenView)
        {
        }
    }
}
