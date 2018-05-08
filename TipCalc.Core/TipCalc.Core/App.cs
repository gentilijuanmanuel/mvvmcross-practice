using MvvmCross;
using MvvmCross.ViewModels;
using TipCalc.Core.Services;
using TipCalc.Core.ViewModels;

namespace TipCalc.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

            // Registration: it means creating an entry on the ‘Inversion of Control’ Container - IoC.
            Mvx.RegisterType<ICalculationService, CalculationService>();


            //The app starts with TipViewModel:
            //The same functionality in other words:
            //Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
            RegisterAppStart<TipViewModel>();

        }
    }
}