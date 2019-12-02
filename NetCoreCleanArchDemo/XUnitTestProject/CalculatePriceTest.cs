using ChanaweeDemo.Application.Interfaces;
using ChanaweeDemo.Application.Services;
using ChanaweeDemo.Application.Services.Discount;
using ChanaweeDemo.Application.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject
{
    public class CalculatePriceTest
    {
        private readonly IPurchaseService _purchaseService;
        public CalculatePriceTest()
        {
            var services = new ServiceCollection();
            services.AddTransient<IPurchaseService, PurchaseService>();
            services.AddTransient<IDiscountRuleService, DiscountRule1>();
            services.AddTransient<IDiscountRuleService, DiscountRule2>();
            services.AddTransient<IDiscountRuleService, DiscountRule3>();
            services.AddTransient<IDiscountRuleService, DiscountRule4>();
            var serviceProvider = services.BuildServiceProvider();
            _purchaseService = serviceProvider.GetService<IPurchaseService>();
        }
        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void Calulate(PurchaseViewModel vm, double expect)
        {
            Assert.Equal(expect, _purchaseService.CalculatePrice(vm));
        }
    }
    public class CalculatorTestData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            { new PurchaseViewModel() {CouponCode = "DIS10", NumberOfCustomer = 1.00, PricePerPerson = 500.00 },450.00 };
            yield return new object[]
            { new PurchaseViewModel() {CouponCode = "STARCARD", NumberOfCustomer = 1.00, PricePerPerson = 2000.00 },1800.00 };
            yield return new object[]
            { new PurchaseViewModel() {CouponCode = "DIS10", NumberOfCustomer = 2.00, PricePerPerson = 1500.00 },2250 };

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
