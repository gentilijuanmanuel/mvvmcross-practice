using System;
using System.Threading.Tasks;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace ExampleNavigation.Core.ViewModels
{
	public class FirstViewModel : MvxViewModel
    {
		private readonly IMvxNavigationService _navigationService;

        public FirstViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

            NavigateCommand = new MvxAsyncCommand(() => _navigationService.Navigate<SecondViewModel>());
        }

		public override async Task Initialize()
        {
            await base.Initialize();

			//_name = "Juan Manuel Gentili";
        }

        /*
		private string _name;
		public string Name
        {
            get => _name;
            set
            {
				_name = value;
				RaisePropertyChanged(() => Name);                
            }
        }
        */

        //Mvvm Commands
        public IMvxAsyncCommand NavigateCommand { get; private set; }
    }
}
