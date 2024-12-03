using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40 };
            long sum = SumArray(numbers);

            Console.WriteLine(sum);
            Console.WriteLine("press any key to continue...");
            Console.ReadKey();
        }
        static long SumArray(int[] numbers)
        {
            long sum = 0;
            foreach (int item in numbers)
            {
                sum +
                = item;
            }
            return sum;
        }
    }
}
