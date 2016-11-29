using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    public class InsertionSorter : Sorter
    {

        public InsertionSorter(int[] arrayForSorting) : base(arrayForSorting) 
        { }


        public override void Sort()
        {
            Console.WriteLine("\n\n***** Insetion Sorting *****\n");
            Console.WriteLine("Incoming array before sorting");
            Print();

            for (int i = 1; i < arrayForSorting.Length; i++)
            {

                Console.WriteLine("\nIteration {0}:", i);
                Print();

                int j = i;

                while (j > 0 && arrayForSorting[j] < arrayForSorting[j - 1])
                {
                    Swap(j, j - 1);
                    j--;
                }
            }

            Console.WriteLine("\nThe result is:");
            Print();

        }






    }
}
