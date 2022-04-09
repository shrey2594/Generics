using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_new
{
    class GenericClass<T>
    {
        public T[] arr;
        public GenericClass(T[] arr)
        {
            this.arr = arr;
        }

        public void PrintAnArray()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
