﻿using System;
namespace RestaurantBilling.Core.Services
{
    public interface IBillCalculator
    {
        double TipAmount(double subtotal, int gratuity);

        double BillTotal(double subtotal, int gratuity);
    }
}
