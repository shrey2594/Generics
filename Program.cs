using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_new
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, };
            double[] doubleArr = { 1.3, 3.6 };
            char[] charArr = { 'E', 'T' };

            Console.WriteLine("\n1.Print array without generic method.\n2.Print Array with generic Method.\n3.Print array with generic class.\n4.Find Max\n5.Find Max\n6.Find max with generics\n7.Find Max value using Array Sort");
            var enterInput=Convert.ToInt32(Console.ReadLine());
            switch (enterInput)
            {
                case 1:
                    Console.WriteLine("without generic method");
                    PrintArray.PrintAnArray(intArr);
                    PrintArray.PrintAnArray(doubleArr);
                    PrintArray.PrintAnArray(charArr);
                    break;
                case 2:
                    Console.WriteLine("with generic method");
                    GenericPrintArray.PrintAnArray(intArr);
                    GenericPrintArray.PrintAnArray(doubleArr);
                    GenericPrintArray.PrintAnArray(charArr);
                    break ;
                case 3:
                    Console.WriteLine("with generic class");
                    new GenericClass<int>(intArr).PrintAnArray();
                    new GenericClass<double>(doubleArr).PrintAnArray();
                    new GenericClass<char>(charArr).PrintAnArray();
                    break;
                case 4:
                    Console.WriteLine("Find Max without generics for integer values");
                    Console.WriteLine("\nPlease enter first number:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter second number:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter third number:");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("Find Max without generics for float values");
                    Console.WriteLine("\nPlease enter first number:");
                    float num4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter second number:");
                    float num5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nPlease enter third number:");
                    float num6 = Convert.ToInt32(Console.ReadLine());
                    break;
                case 6:
                    Console.WriteLine("Find max with Generics for any data type.");
                    new GenericFindMaximum<int>(5784, 3243, 634635).TestMaximumValue();
                    new GenericFindMaximum<float>(57.84f, 3.243f, 634.635f).TestMaximumValue();
                    new GenericFindMaximum<string>("fae","feas","grs").TestMaximumValue();
                    break;
                case 7:
                    new FindMaxUsingSort<int>(intArr).PrintResult();
                    break;
            }
            //Console.WriteLine("without generic method");
            //PrintArray.PrintAnArray(intArr);
            //PrintArray.PrintAnArray(doubleArr);
            //PrintArray.PrintAnArray(charArr);
            //Console.WriteLine("-------------------");
            //GenericPrintArray.PrintAnArray(intArr);
            //GenericPrintArray.PrintAnArray(doubleArr);
            //GenericPrintArray.PrintAnArray(charArr);
            //Console.WriteLine("with generic class");
            //new GenericClass<int>(intArr).PrintAnArray();
            //GenericClass<int> intObj = new GenericClass<int>;

        }
    }
}