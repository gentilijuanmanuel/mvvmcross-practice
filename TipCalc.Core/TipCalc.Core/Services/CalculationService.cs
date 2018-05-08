using System;
namespace TipCalc.Core.Services
{
    public class CalculationService : ICalculationService
    {
        public CalculationService()
        {
        }

        public double TipAmount(double subTotal, int generosity)
        {
            return subTotal * ((double)generosity) / 100;
        }
    }
}
