using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson49homework3
{
    internal class Program
    {
        static int Sum (int sumValue)
        {

            if (sumValue < 10)
                return sumValue;

            int x = sumValue % 10;
            sumValue /= 10;

            return x + Sum(sumValue);

        }



        static void Main(string[] args)
        {
            int value = 123456;
            Console.WriteLine(Sum(value));
           
        }
    }
}
