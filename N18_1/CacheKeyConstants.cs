using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N18_1
{
    public static class CacheKeyConstants
    {
        public static  string Sum(List<int> hashcode)
        {
            int sum = 0;
            foreach(var item in hashcode)
            {
                sum += item.GetHashCode();
            }
            return $"{sum} - sum";
        }

        public static string Min(List<int> hashcode)
        {
            int min = 0;
            foreach (var item in hashcode)
            {
                min += item.GetHashCode();
            }
            return $"{min} - min";
        }
        
        public static string Max(List<int> hashcode)
        {
            int max = 0;
            foreach (var item in hashcode)
            {
                max += item.GetHashCode();
            }
            return $"{max} - max";
        }

    }
}
