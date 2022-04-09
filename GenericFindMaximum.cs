using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_new
{
    internal class GenericFindMaximum<T> where T: IComparable
    {
        public T first, second, third;
        public GenericFindMaximum(T first,T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public static T FindMax(T first, T second, T third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)    // >0 means first is greater  
            {
                Console.WriteLine("first is having max value " + first);
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("second is having max value" + second);
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("second is having max value" + third);
                return third;
            }
            else
            {
                Console.WriteLine("ALL VALUES ARE SAME");
                return default;
            }
        }

        public void TestMaximumValue()
        {
            T res=FindMax(first, second, third);
            Console.WriteLine("max value:" + res);
        }
    }
}
