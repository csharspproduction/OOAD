using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboration2.B34Final
{
    public static class PriceStrategyFactory
    {

        
        private static ThresholdDiscount _thousandThresholdDiscount;
        private static ThresholdDiscount _tenThousandThresholdDiscount;
        private static ProcentDiscount _pd;
        private static BestForCustomer _bfc;
        private static BestForStore _bfs;


        public static ThresholdDiscount ThousandThresholdDiscount
        {
            get
            {
                if(_thousandThresholdDiscount==null)
                     _thousandThresholdDiscount= new ThresholdDiscount(1000, 50);
                return _thousandThresholdDiscount;
            }

            private set
            {
                _thousandThresholdDiscount = value;
            }
        }

        public static ThresholdDiscount TenThousandThresholdDiscount
        {
            get
            {
                if(_tenThousandThresholdDiscount==null)
                    _tenThousandThresholdDiscount = new ThresholdDiscount(10000, 500);
                return _tenThousandThresholdDiscount;
            }

            private set
            {
                _tenThousandThresholdDiscount = value;
            }
        }

        public static ProcentDiscount Pd
        {
            get
            {
                if(_pd==null)
                    _pd = new ProcentDiscount(0.25m);
                return _pd;
            }

            private set
            {
                _pd = value;
            }
        }

        public static BestForCustomer Bfc
        {
            get
            {
                if (_bfc == null)
                    _bfc = new BestForCustomer();
                return _bfc;
            }

            private set
            {
                _bfc = value;
            }
        }

        public static BestForStore Bfs
        {
            get
            {
                if(_bfs==null)
                _bfs = new BestForStore();
                return _bfs;
            }

            private set
            {
                _bfs = value;
            }
        }

        public static IPriceStrategy GetPriceStrategy(Order order)
        {
            CompositePriceStrategy ips;

         
            if (order.Customer is Company)
                {
                
                ips = Bfc;
                ips.Add(Pd);
                }
            else
            {
                ips = Bfs;
            }
            ips.Add(TenThousandThresholdDiscount);
            ips.Add(ThousandThresholdDiscount);

            return ips;
     
        }

    }

}