using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class AbsoluteDiscount : IPriceStrategy
    {
        private decimal _value;
        public AbsoluteDiscount(decimal value)
        {
            Value = value;
        }

        public decimal Value
        {
            get
            {
                return _value;
            }

            private set
            {
                _value = value;
            }
        }

        public decimal GetTotal(Order order)
        {
            return order.Total-Value;
        }
    }
}