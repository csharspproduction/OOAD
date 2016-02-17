using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public abstract class CompositePriceStrategy : IPriceStrategy
    {
        protected List<IPriceStrategy> priceStrategyList;

 
        public CompositePriceStrategy()
        {
            priceStrategyList = new List<IPriceStrategy>();
        }
        public  void Add(IPriceStrategy iStrategyObject)
        {
            if(priceStrategyList!=null)
                priceStrategyList.Add(iStrategyObject);
        }

        public abstract decimal GetTotal(Order order);
    }
}