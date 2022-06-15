using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boblesorting
{
    internal class Program
    {
        static void ArrayPrint(int [] array)
        {
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }


        }


        static void Main(string[] args)
        {
            int[] myarray = { 101,9,1};
            int temp;

            for (int i = 0; i < myarray.Length-1; i++)
            {
                for (int k = 0; k < myarray.Length-1; k++)
                {
                    if (myarray[k] > myarray[k+1])
                    {
                        temp = myarray[k];
                        myarray[k] = myarray[k+1];
                        myarray[k+1] = temp;                    
                    }

                    
                
                }
            }


            

           

        }
    }
}
