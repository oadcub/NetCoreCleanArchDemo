using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Domain.Commands
{
    public class CreateProductCommand : ProductCommand
    {
        public CreateProductCommand(string name,double price)
        {
            Name = name;
            Price = price;
        }
    }
}
