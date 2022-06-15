using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fuzzbuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            while (true)
            {
                Console.WriteLine("enter number from 1 to 100");
                int number = int.Parse(Console.ReadLine());
                
                if (number < 1 || number >100)
                {
                    Console.WriteLine("wrong number try again");
                    continue;
                }
                else
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (number % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (number % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(number);
                    }
                }
                
            }




        }
    }
}
