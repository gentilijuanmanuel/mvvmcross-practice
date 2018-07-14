using System.Threading.Tasks;
using MvvmCross.ViewModels;
using RestaurantBilling.Core.Services;

namespace RestaurantBilling.Core.ViewModels
{
    public class BillViewModel : MvxViewModel
    {
        readonly IBillCalculator _calculationService;

        public BillViewModel(IBillCalculator calculationService)
        {
            this._calculationService = calculationService;
        }

        //MVVM Methods
        public override async Task Initialize()
        {
            await base.Initialize();

            this.SubTotal = 100;
            this.Gratuity = 10;

            this.Recalculate();
        }

        //Private properties

        private string _customerEmail;
        public string CustomerEmail
        {
            get => _customerEmail;
            set
            {
                _customerEmail = value;
                RaisePropertyChanged(() => CustomerEmail);
            }
        }

        private double _subtotal;
        public double SubTotal
        {
            get => _subtotal;
            set
            {
                _subtotal = value;
                RaisePropertyChanged(() => SubTotal);
                this.Recalculate();
            }
        }

        private int _gratuity;
        public int Gratuity
        {
            get => _gratuity;
            set
            {
                _gratuity = value;
                RaisePropertyChanged(() => Gratuity);
                this.Recalculate();
            }
        }

        private double _tip;
        public double Tip
        {
            get => _tip;
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        private double _total;
        public double Total
        {
            get => _total;
            set
            {
                _total = value;
                RaisePropertyChanged(() => Total);
            }
        }

        //Private Methods
        public void Recalculate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Gratuity);
            Total = _calculationService.BillTotal(SubTotal, Tip);
        }
    }
}
