using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_new
{
    class GenericPrintArray
    {
        public static void PrintAnArray<T>(T[] arr)
        {
            foreach (T element in arr)
            {
                Console.WriteLine(element);
            }
        }
    }
}
