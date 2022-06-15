using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace del12
{



    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int[] array = new int[10];
            int[] array2 = new int[10];
            int count=0;


            for (int i = 0; i < 10; i++)
            {
                array[i] = random.Next(0,50); 
            }

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    Console.WriteLine(array[i]);
                }
                else
                    Console.WriteLine($"{array[i]} is odd");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i]%2)==0)
                {
                    array2[i] = array[i];
                    count++;
                }

            }
            foreach  (int x in array2)
            {
                Console.Write($"{x} |");
            }

            int h = int.Parse(Console.ReadLine());

            int[] ar = new int[h];

            foreach (int x in ar)
                Console.WriteLine(x);

            //Console.WriteLine("enter number");
            //int number = int.Parse(Console.ReadLine());
            //if ((number % 2) == 0)
            //{
            //    Console.WriteLine($"{number} is even");
            //}
            //else
            //{
            //    Console.WriteLine("{0} is odd ", number);
            //}




        }
    }
}
