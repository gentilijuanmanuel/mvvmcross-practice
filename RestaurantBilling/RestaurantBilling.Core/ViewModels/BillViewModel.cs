using RestaurantBilling.Core.Services;
using MvvmCross.ViewModels;
using System.Windows.Input;
using MvvmCross.Commands;

namespace RestaurantBilling.Core.ViewModels
{
    public class BillViewModel : MvxViewModel
    {

        //Mvvm properties
        readonly IBillCalculator _calculation;
        private string _customerEmail;
        double _subtotal;
        int _gratuity;
        double _tip;
        double _total;

        //Command to navigate back to this ViewModel.
        public ICommand NavBack
        {
            get
            {
                //small change in Close(). It's a NavigationService method.
                return new MvxCommand(() => this.NavigationService.Close(this));
            }
        }

        public string CustomerEmail
        {
            get
            {
                return _customerEmail;
            }
            set
            {
                _customerEmail = value;
                RaisePropertyChanged(() => CustomerEmail);
            }
        }

        public double SubTotal
        {
            get
            {
                return _subtotal;
            }
            set
            {
                _subtotal = value;
                RaisePropertyChanged(() => SubTotal);
                this.Recalculate();
            }
        }

        public int Gratuity
        {
            get
            {
                return _gratuity;
            }

            set
            {
                _gratuity = value;
                RaisePropertyChanged(() => Gratuity);
                this.Recalculate();
            }
        }

        public double Tip
        {
            get
            {
                return _tip;
            }

            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        public double Total
        {
            get
            {
                return _total;
            }

            set
            {
                _total = value;
                RaisePropertyChanged(() => Total);
                this.Recalculate();
            }
        }

        //constructor with Dependency Injection
        public BillViewModel(IBillCalculator calculation)
        {
            this._calculation = calculation;
        }

        public void Init(int subtotal)
        {
            SubTotal = SubTotal;
        }

        public override void Start()
        {
            _gratuity = 10;
            Recalculate();
            base.Start();
        }

        //Private Methods
        public void Recalculate()
        {
            Tip = _calculation.TipAmount(SubTotal, Gratuity);
            Total = _calculation.BillTotal(SubTotal, Gratuity);
        }
    }
}
