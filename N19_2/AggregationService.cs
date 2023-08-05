using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N19_2
{
    public static class AggregationService
    {
        public static int Sum(params int[] values)
        {
            var sum = 0;
            foreach ( var value in values )
            {
                sum += value;
            }
            return sum;
        }


        public static int Average(params int[] values)
        {
            var avrage = 0;
            foreach ( var value in values)
            {
                avrage += (int)value;
            }
            return avrage / values.Length;
        }

        public static int Max(params int[] values)
        {
            var max = 0;
            foreach ( var value in values)
            {
                if( value > max)
                {
                    max = value;
                }
            }
            return max;
        }

        public static int Min(params int[] values)
        {
            var min = values[0];
            foreach (var value in values)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }

        public static void Increment(ref int value)
        {
            if (int.MaxValue > value)
            {
                value +=1;
            }
        }

        public static void Decrement(ref int value)
        {
            if(int.MinValue < value)
            {
                value -=1;
            }
        }

    }
}
