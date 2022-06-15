using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program


    {
        static void Resize (ref int[] array, int index)
        {
            int[] array2 = new int[array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                array2[i] = array[i];
            }
            for (int i = index; i < array2.Length; i++)
            {
                array2[i] = array[i+1];
            }
            array = array2;
        }






        static void Main(string[] args)
        {

            int[] arr = { 2, 3, 5, 6, 8 };

            Resize(ref arr, 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
        }
    }
}
