using System;
namespace TipCalc.Core
{
    public interface ICalculationService
    {
        double TipAmount(double subTotal, int generosity);
    }
}
