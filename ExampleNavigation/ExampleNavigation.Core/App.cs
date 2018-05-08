using MvvmCross;
using MvvmCross.ViewModels;
using ExampleNavigation.Core.ViewModels;

namespace ExampleNavigation.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

            // Registration: it means creating an entry on the ‘Inversion of Control’ Container - IoC.


            //The app starts with TipViewModel:
            //The same functionality in other words:
            //Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<TipViewModel>());
			RegisterAppStart<FirstViewModel>();

        }
    }
}