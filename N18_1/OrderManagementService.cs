using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_1
{
    public class OrderManagementService
    {
        private List<int> Orders = new List<int>();

        OrderCacheService Cache = OrderCacheService.GetInstance();

        public int Max()
        {
            var key = CacheKeyConstants.Max(Orders);
            var max = Cache.Get(key);
            if(max != default)
            {
                return max;
            }
            else
            {
                var maxB = 0;
                foreach(var item in Orders)
                {
                    if(maxB < item)
                    {
                        maxB = item;
                    }
                }
                Cache.Set(key, maxB);
                return maxB;
            }
        }

        public int Min()
        {
            var key = CacheKeyConstants.Min(Orders);
            var min = Cache.Get(key);
            if(min != default)
            {
                return min;
            }
            else
            {
                var minB = Orders[0];
                foreach(var item in Orders)
                {
                    if(minB > item)
                    {
                        minB = item;
                    }
                }
                Cache.Set(key, minB);
                return minB;
            }
        }

        public int Sum()
        {
            var key = CacheKeyConstants.Sum(Orders);
            var sum = Cache.Get(key);
            if(sum != default)
            {
                return sum;
            }
            else
            {
                foreach(var item in Orders)
                {
                    sum += item;
                }
                return sum;
            }
        }


        public void Add(int amount)
        {
            //if (amount > 0)
            //{
                Orders.Add(amount);

            //}
            //else
            //{
            //    throw new Exception("Amount mavjud emas");
            //    // 0 dan validatsa
            //}
        }
    }
}
