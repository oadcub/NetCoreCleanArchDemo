using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.Services.Discount
{
    /// <summary>
    /// Discount 30% when customer present coupon code "STARCARD" for 2 customers
    /// </summary>
    public class DiscountRule2 : IDiscountRuleService
    {
        public double GetDiscount(PurchaseViewModel vm)
        {
            if (vm.CouponCode == "STARCARD" && vm.NumberOfCustomer >= 2.00)
            {

                return 2 * vm.PricePerPerson * 0.30;
            }
            else
            {
                return 0;
            }
        }
    }
}
