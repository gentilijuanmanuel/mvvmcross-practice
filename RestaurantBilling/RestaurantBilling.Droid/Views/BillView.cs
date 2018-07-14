using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using RestaurantBilling.Core.ViewModels;

namespace RestaurantBilling.Droid.Views
{
    [Activity(Label = "Create bill")]
    public class BillView : MvxActivity<BillViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.BillView);
        }
    }
}
