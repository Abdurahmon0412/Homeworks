using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_1
{
    public class OrderCacheService
    {
        public Dictionary<string , int> Cache = new Dictionary<string , int>();


        private static OrderCacheService _instance;

        public static OrderCacheService GetInstance()
        {
            if (_instance is null)
            {
                _instance = new OrderCacheService();
            }
            return _instance;
        }

        private OrderCacheService() { }

        public int Get(string key)
        {
            if (Cache.ContainsKey(key))
            {
                return Cache[key];
            }
            return default;
        }


        public void Set(string key, int value)
        {
                if(!Cache.ContainsKey(key)) 
                {
                    Cache.Add(key, value);
                }
                else
                {
                    throw new Exception("Invalid key");
                }
        }
    }
}
