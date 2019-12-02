using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.Services.Discount
{
    /// <summary>
    /// Come 4 pay 3 when customer present coupon code "STARCARD"
    /// </summary>
    public class DiscountRule3 : IDiscountRuleService
    {
        public double GetDiscount(PurchaseViewModel vm)
        {
            if (vm.CouponCode == "STARCARD" && vm.NumberOfCustomer >= 4.00)
            {
                return Math.Floor(vm.NumberOfCustomer / 4.00) * vm.PricePerPerson;
            }
            else
            {
                return 0;
            }
        }
    }
}
