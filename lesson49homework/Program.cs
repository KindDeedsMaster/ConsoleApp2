using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson49homework
{
    internal class Program
    {
        static void WriteArray (int[] array, int i =0)
        {           
            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                WriteArray (array, i + 1);
            }            
            
        }



        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 6, 8, 9, 46, 5, 4 };


            WriteArray(myArray);

        }
    }
}
