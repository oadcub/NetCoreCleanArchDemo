using ChanaweeDemo.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChanaweeDemo.Domain.Commands
{
    public abstract class ProductCommand : Command
    {
        public string Name { get; protected set; }
        public double Price { get; protected set; }
    }
}
