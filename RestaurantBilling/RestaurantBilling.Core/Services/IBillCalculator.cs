namespace RestaurantBilling.Core.Services
{
    public interface IBillCalculator
    {
        double TipAmount(double subtotal, int gratuity);

        double BillTotal(double subtotal, double tip);
    }
}
