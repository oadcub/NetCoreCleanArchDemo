using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IEnumerable<IDiscountRuleService> _discountRuleServices;
        public PurchaseService(IEnumerable<IDiscountRuleService> discountRuleServices)
        {
            _discountRuleServices = discountRuleServices;
        }
        public double CalculatePrice(PurchaseViewModel vm)
        {
            var maxDiscount = 0.00;
            foreach(var s in _discountRuleServices)
            {
                var dicountAmount = s.GetDiscount(vm);
                if (maxDiscount < dicountAmount)
                {
                    maxDiscount = dicountAmount;
                }
            }
            var netAmount = vm.PricePerPerson * vm.NumberOfCustomer - maxDiscount;
            //for round up
            netAmount = Math.Ceiling(netAmount * 100) / 100;
            return netAmount;
        }
    }
}
