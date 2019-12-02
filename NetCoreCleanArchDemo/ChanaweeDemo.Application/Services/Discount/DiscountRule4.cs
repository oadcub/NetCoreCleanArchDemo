using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.Services.Discount
{
    /// <summary>
    /// Discount 25% when price more/equal that 2500 baht.
    /// </summary>
    public class DiscountRule4 : IDiscountRuleService
    {
        public double GetDiscount(PurchaseViewModel vm)
        {
            var netAmount = vm.PricePerPerson * vm.NumberOfCustomer;
            if (netAmount >= 2500)
            {
                return netAmount * 0.25;
            }
            else
            {
                return 0;
            }
        }
    }
}
