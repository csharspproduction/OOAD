using Microsoft.VisualStudio.TestTools.UnitTesting;
using Laboration2.B34Final;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration2.B34Final.Tests
{
    [TestClass()]
    public class PriceStrategyFactoryTests
    {
        [TestMethod()]
        public void GetPriceStrategyTest()
        {
            Customer dewd = new Person();
            dewd.Name = "Åke";
            dewd.Address = "Åkerivägen 3";

            Customer leetCrusaders = new Company();
            leetCrusaders.Name = "Åkes Åkeri";
            leetCrusaders.Address = "Åkerivägen 3a";
            ((Company)leetCrusaders).ContactPerson = (Person)dewd;
            
            Order o2 = new Order();
            o2.Customer = leetCrusaders;

            
            o2.Items = new Dictionary<int, OrderLineItem>();
            Item realTruck = new Item();
            realTruck.Description = "A real truck.4 wheels and a engine and everything. Color is red";

            
            realTruck.Quantity = 1;
            realTruck.Price = 10000;

         
            o2.Items.Add(0, new OrderLineItem());
            o2.Items[0].Item = realTruck;
            o2.Items[0].Quantity = 1;

            IPriceStrategy ips = PriceStrategyFactory.GetPriceStrategy(o2);

            Assert.IsInstanceOfType(ips,typeof(BestForCustomer));
            decimal temp = o2.Total;
            temp =temp - 0.25m*temp;
            decimal temp2 = ips.GetTotal(o2);
            Assert.AreEqual(ips.GetTotal(o2), temp);
        }
    }
}