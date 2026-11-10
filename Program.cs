using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caldwell_Evolve_PreInterview
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Integers:");
            Console.Write("First Integer: ");
            int firstParam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Integer: ");
            int secondParam = Convert.ToInt32(Console.ReadLine());

            PrintNumbers(firstParam, secondParam);
        }

        static void PrintNumbers(int firstParam, int secondParam)
        {
            int lowest = Math.Min(firstParam, secondParam);
            int highest = Math.Max(firstParam, secondParam);

            Console.WriteLine("Output:");
            for (int i = 2; i <= highest; i = i + 2)
            {
                if (i % lowest == 0 && i >= lowest)
                {

                    Console.WriteLine(i);
                }
            }
        }
    }
}
