using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Resize (ref int [] array, int indexx, int change)
        {
            int[] newArray = new int[array.Length+1];
            newArray[indexx] = change;

            for (int i = 0; i < indexx; i++)
            {
                newArray[i]=array[i];                              
            }
            for ( int i = indexx+1 ;  i < newArray.Length; i++)
            {
                newArray[i] = array[i-1];
            }
            array = newArray;       
        }
        static void ResFirst (ref int[] array, int change)
        {
            Resize(ref array, 0, change);

        }
        static void ResLast (ref int[]array ,int change)
        {
            Resize(ref array, array.Length, change);
        }


        static void Main(string[] args)
        {
            int[] arr = {2,3,5,6,8};

            Resize(ref arr, 2,10);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                
            }
            Console.WriteLine();
            ResFirst(ref arr, 99);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine();
            ResLast(ref arr, 88);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
