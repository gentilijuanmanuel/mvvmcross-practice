namespace RestaurantBilling.Core.Services
{
    public class BillCalculator : IBillCalculator
    {
        public double TipAmount(double subtotal, int gratuity)
        {
            return subtotal * ((double)gratuity) / 100.00;
        }

        public double BillTotal(double subtotal, double tip)
        {
            return subtotal + tip;
        }
    }
}
