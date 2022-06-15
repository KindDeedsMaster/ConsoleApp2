using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson49homework2
{
    internal class Program
    {
        static int SumArray (int[]array, int i =0)
        {
            if (i >= array.Length)
            {
                return 0;
            }

            int result = SumArray (array,i+1);
            return result+array[i];
        }


        static void Main(string[] args)
        {
            int[] myArray = { 4, 5, 6, 4, 8 };

            int result = SumArray(myArray);
            Console.WriteLine(result);
        }
    }
}
