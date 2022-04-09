using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_new
{
    class FindMaximum
    {
        public static int FindMax(int first,int second, int third)
        {
            if(first.CompareTo(second) >0 && first.CompareTo(third)>0)    // >0 means first is greater  
            {
                Console.WriteLine("first is having max value " + first);
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("second is having max value"+second);
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("second is having max value"+third);
                return third;
            }
            else
            {
                Console.WriteLine("ALL VALUES ARE SAME");
                return first;
            }
        }


        public static float FindMax(float first, float second, float third)
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
                return first;
            }
        }
    }
}
