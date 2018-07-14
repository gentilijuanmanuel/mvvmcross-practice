using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace RestaurantBilling.Core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public MainMenuViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCreateBillCommand = new MvxAsyncCommand(() => _navigationService.Navigate<BillViewModel>());
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public IMvxAsyncCommand NavigateCreateBillCommand { get; private set; }
    }
}
