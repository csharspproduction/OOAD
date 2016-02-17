using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class BestForCustomer : CompositePriceStrategy
    {
        public override decimal GetTotal(Order order)
        {
            return priceStrategyList.Min(x => x.GetTotal(order));
        }
    }
}