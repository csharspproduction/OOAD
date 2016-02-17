using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class ProcentDiscount : IPriceStrategy
    {
        private decimal _procent;

        public decimal Procent
        {
            get
            {
                return _procent;
            }

            private set
            {
                if (value > 0 && value < 1)
                {

                    _procent = value;
                }
                else
                {
                    value = 0;
                }
            }
        }
        public ProcentDiscount(decimal procent)
        {
            Procent = procent;
        }

        public decimal GetTotal(Order order)
        {
            return order.Total-(order.Total* Procent);
        }
    }
}