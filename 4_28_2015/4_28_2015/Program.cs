using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_28_2015
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void puppies(int[] in_treats) {
            int maxHappiness = 0;

            Array.Sort(in_treats);
            int[] out_treatOrder = new int[in_treats.Length];
            in_treats.CopyTo(out_treatOrder, 0);

            //reorder for maximum happiness
            for (int i = in_treats.Length - 1; i >= 0; i--)
            {

            }

            //calculate happieness
            for (int i = 0; i < in_treats.Length; i++)
            {
                if (i == 0)
                {

                }
            }

            Console.WriteLine(maxHappiness);
            for (int i = 0; i < out_treatOrder.Length; i++)
            {
                Console.Write(out_treatOrder[i]);
                if (i < out_treatOrder.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}
