using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class Item : ITax
    {
        private int _id;
        private decimal _price;
        private string _description;
        private int _quantity;


        public decimal Price { get; set; }

        public decimal Tax
        {
            get
            {
                return decimal.Multiply(0.25m,Price);
            }
        }

        public decimal Total
        {
            get
            {
                return decimal.Add(Tax,Price);
            }
        }

        public int Id { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}