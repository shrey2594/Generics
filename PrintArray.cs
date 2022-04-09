using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_new
{
    class PrintArray
    {
        public static void PrintAnArray(int[] arr)
        {
            foreach(int element in arr)
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintAnArray(double[] arr)
        {
            foreach (double element in arr)
            {
                Console.WriteLine(element);
            }
        }

        public static void PrintAnArray(char[] arr)
        {
            foreach (char element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
