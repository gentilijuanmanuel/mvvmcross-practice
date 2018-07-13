using System;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace RestaurantBilling.Core.ViewModels
{
    public class MainMenuViewModel : MvxViewModel
    {
        public ICommand NavigateCreateBill
        {
            get
            {
                return new MvxCommand(() => this.NavigationService.Navigate<BillViewModel>());
            }
        }
    }
}
