using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class ThresholdDiscount : IPriceStrategy
    {
        private decimal _threshold;
        private decimal _discount;

        public ThresholdDiscount(decimal threshold,decimal discount)
        {
            Threshold = threshold;
            Discount = discount;
        }
        public decimal Threshold
        {
            get
            {
                return _threshold;
            }

            private set
            {
                _threshold = value;
            }
        }

        public decimal Discount
        {
            get
            {
                return _discount;
            }

            private set
            {
                _discount = value;
            }
        }

        public decimal GetTotal(Order order)
        {
            if (order.Total > Threshold)
            {
                return order.Total - Discount;
            }
            return 0;
        }
    }
}