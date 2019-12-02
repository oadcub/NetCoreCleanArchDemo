using ChanaweeDemo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Application.Interfaces
{
    public interface IDiscountRuleService
    {
        double GetDiscount(PurchaseViewModel purchaseViewModel);
    }
}
