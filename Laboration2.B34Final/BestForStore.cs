using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class BestForStore : CompositePriceStrategy
    {
        public override decimal GetTotal(Order order)
        {
            return priceStrategyList.Max(x => x.GetTotal(order));
        }
    }
}