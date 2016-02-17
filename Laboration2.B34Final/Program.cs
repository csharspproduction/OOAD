using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2.B34Final
{
    class Program
    {
        static void Main(string[] args)
        {
            /** A customer "walks" in to the store. 
                He wants to order things for himself for Christmas and 
                he needs to order things for his company, which is another customer.
            **/
            //Customer dewd = new Person();
            //dewd.Name = "Åke";
            //dewd.Address = "Åkerivägen 3";

            //Customer leetCrusaders = new Company();
            //leetCrusaders.Name = "Åkes Åkeri";
            //leetCrusaders.Address = "Åkerivägen 3a";
            //((Company)leetCrusaders).ContactPerson = (Person)dewd;

            ////He places a order for himself first;
            //Order o = new Order();
            //o.Customer = dewd;

            ////In that order he wants some things for Christmas.
            //Item toyTruck = new Item();
            //toyTruck.Description = "A miniature blue truck made of plastic";
            //Item tree = new Item();
            //tree.Description = "A small pine";

            ////The "store" has these many of them in storage and this is what they cost
            //toyTruck.Quantity = 90;
            //toyTruck.Price = 5m;
            //tree.Quantity = 50;
            //tree.Price = 20m;

            ////The customer want this quantity in this particular order(its for himself);
            //OrderLineItem toyTrucks = new OrderLineItem();
            //toyTrucks.Item = toyTruck;
            //toyTrucks.Quantity = 10;
            //OrderLineItem trees = new OrderLineItem();
            //trees.Item = tree;
            //trees.Quantity = 1;

            ////The store adds them to his order
            //o.Items = new Dictionary<int, OrderLineItem>();
            //o.Items.Add(0, toyTrucks);
            //o.Items.Add(1, trees);

            ////The store tells him how much everything will cost and if they can fill his order directly
            //Console.WriteLine("Customer: " + o.Customer.Name);
            //Console.WriteLine("Do we have:" + o.Items[0].Item.Description);
            //Console.WriteLine("In storage?: " + o.Items[0].IsFilled());
            //Console.WriteLine("Do we have:" + o.Items[1].Item.Description);
            //Console.WriteLine("In storage? " + o.Items[1].IsFilled());
            //Console.WriteLine("SubTotal: "+o.SubTotal);
            //Console.WriteLine("Shipping: " + o.ShippingCharge);
            //Console.WriteLine("Tax:      "+o.Tax);
            //Console.WriteLine("----------");
            //Console.WriteLine("Total:    " + o.Total);
            //Console.WriteLine();

            ////He then makes a order for his company
            //Order o2 = new Order();
            //o2.Customer = leetCrusaders;

            ////He then adds the items he wants to his order
            //o2.Items = new Dictionary<int, OrderLineItem>();
            //Item realTruck = new Item();
            //realTruck.Description = "A real truck.4 wheels and a engine and everything. Color is red";
            
            ////Unfortunately the shop does not have any real trucks in storage at the moment, it does however has a price for it
            //realTruck.Quantity = 0;
            //realTruck.Price = 10000;

            ////He still wants 1 tho and he doesn't know yet that the shop doesn't have it in storage
            //o2.Items.Add(0, new OrderLineItem());
            //o2.Items[0].Item = realTruck;
            //o2.Items[0].Quantity = 1;

            ////He asks how much it will be.
            ////The store tells him the following
            //Console.WriteLine("Customer: " + o2.Customer.Name);
            //Console.WriteLine("Do we have: " + o2.Items[0].Item.Description);
            //Console.WriteLine("In storage?: " + o2.Items[0].IsFilled());
            //Console.WriteLine("SubTotal: " + o2.SubTotal);
            //Console.WriteLine("Shipping: " + o2.ShippingCharge);
            //Console.WriteLine("Tax:      " + o2.Tax);
            //Console.WriteLine("----------");
            //Console.WriteLine("Total: "+o2.Total);
            //He decides he will wait til they get it in storage and walks off. The End.

            Console.ReadKey();
           
        }
    }
}
