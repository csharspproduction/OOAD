using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class OrderLineItem : ITax
    {
        private int _id;
        private int _quantity;
        public Order Order { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; }
        public int Id { get; set; }


        public decimal Total
        {
            get
            {
                return Quantity * Item.Total;
            }
        }

        public decimal Tax
        {
            get
            {
                return Quantity*Item.Tax;
            }
        }



        /**
            The warehouse/storage implementation of this is very lacking
         
        **/
        public bool IsFilled()
        {
            if (Item.Quantity >= Quantity && Item.Quantity>0)
            {
                return true;
            }
            return false;
        }
    }
}