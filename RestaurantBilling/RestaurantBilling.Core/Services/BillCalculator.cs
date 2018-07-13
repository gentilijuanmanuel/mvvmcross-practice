using System;
namespace RestaurantBilling.Core.Services
{
    public class BillCalculator : IBillCalculator
    {
        public double BillTotal(double subtotal, int gratuity)
        {
            return subtotal * ((double)gratuity) / 100.00;
        }

        public double TipAmount(double subtotal, int gratuity)
        {
            return subtotal + TipAmount(subtotal, gratuity);
        }
    }
}
