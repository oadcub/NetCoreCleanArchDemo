using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.Services.Discount
{
    /// <summary>
    ///  Discount 10% when customer present coupon code "DIS10" or price is more/equal than 2000 
    /// </summary>
    public class DiscountRule1 : IDiscountRuleService
    {
        public double GetDiscount(PurchaseViewModel vm)
        {
            var netAmount =  vm.PricePerPerson * vm.NumberOfCustomer;
            if (vm.CouponCode == "DIS10" || netAmount >= 2000.00)
            {
               return netAmount * 0.10;
            }
            else
            {
                return 0;
            }
        }
    }
}
