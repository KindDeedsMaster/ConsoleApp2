using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = { 99, 55, 66, 44, 55, 22,20,21,5,3,1};
            int temp;

            for (int i = 0; i < myarray.Length-1; i++)
            {
                for(int k=0; k < myarray.Length-1; k++)
                {
                    if (myarray[k] > myarray[k+1])
                    {
                        temp = myarray[k];
                        myarray[k] = myarray[k + 1];
                        myarray[k + 1] = temp;

                    }
                }
                foreach (int z in myarray)
                {
                    Console.Write(z);
                    Console.WriteLine();

                }

            }
           
          
         


        }
    }
}
