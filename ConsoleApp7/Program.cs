using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        enum MyEnum
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static int Sum(params int [] x)
        {
            
            return x[0];

        }


        static void Main(string[] args)
        {
            Console.WriteLine(MyEnum.Monday+1);
            ConsoleKey keyyyyy = Console.ReadKey().Key;

            Console.WriteLine(keyyyyy);

        }
    }
}
