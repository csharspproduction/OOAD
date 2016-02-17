using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public class Customer
    {
        private string _name;
        private string _address;
        //A Customer can have several orders
        public virtual Dictionary<int,Order> Orders { get; set; }

        public string Address { get; set; }
        public string Name { get; set; }
    }
}