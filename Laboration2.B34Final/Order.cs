using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class Order : ITax
    {
        private int _id;
        private Dictionary<int, OrderLineItem> _items;

        public int Id { get; set; }
        public virtual Dictionary<int, OrderLineItem> Items { get; set; }
        public virtual Customer Customer { get; set; }

        /**
            Lazy implementation, in a "real" system i would probably add a shipping "item" to the order
        **/
        public virtual decimal ShippingCharge
        {
            get{
                if (SubTotal < 100)
                {
                    return SubTotal * 0.10m;
                }
                else
                    return 0m;
            }
        }

        public decimal SubTotal
        {
            get
            {
                decimal _subtotal = 0;
                IEnumerator<OrderLineItem> e = Items.Values.GetEnumerator();
                while (e.MoveNext())
                {
                    _subtotal += e.Current.Item.Price * e.Current.Quantity;
                }
                return _subtotal;

            }
        }

        public decimal Total
        {
            get
            {
                return SubTotal+ShippingCharge+Tax;
            }
        }

        public decimal Tax
        {
            get
            {
                decimal _tax = 0;
                IEnumerator<OrderLineItem> e = Items.Values.GetEnumerator();
                while (e.MoveNext())
                {
                    _tax += e.Current.Tax;
                }
                return _tax;
            }
        }
    }
}
