using System;
using MvvmCross;
using MvvmCross.ViewModels;
using RestaurantBilling.Core.Services;
using RestaurantBilling.Core.ViewModels;

namespace RestaurantBilling.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterType<IBillCalculator, BillCalculator>();

            RegisterAppStart<MainMenuViewModel>();
        }
    }
}
