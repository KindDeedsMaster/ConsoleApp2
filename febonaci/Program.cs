using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("please enter sequence length");
            int length = int.Parse(Console.ReadLine());

            int[] result = new int[length];
            result[0] = 0;
            result[1] = 1;

            for (int i = 2; i < length; i++)
            {
                result[i] = result[i - 1] + result[i-2];
            }

            foreach  (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
