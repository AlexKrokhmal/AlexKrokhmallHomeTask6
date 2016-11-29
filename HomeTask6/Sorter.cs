using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    abstract public class Sorter
    {        
        protected int[] arrayForSorting;


        public int[] ArrayForSorting
        {
            private set
            {
                if (value.Length > 0)
                {
                    arrayForSorting = value;
                }
                else
                {
                    Console.WriteLine("Error: cannot sort array with '0' elements.");
                }
            }

            get { return arrayForSorting; }
        }

        
        public Sorter(int[] arrayForSorting)
        {
            this.ArrayForSorting = arrayForSorting;
        }
        

        abstract public void Sort();

        public virtual void Print()
        {
            foreach (int i in arrayForSorting)
            {
                Console.Write("{0}   ", i);
            }
            Console.WriteLine();
        }

        protected void Swap(int firstIndexForSwap, int secondIndexForSwap)
        {            
            int temp = 0;
            temp = arrayForSorting[firstIndexForSwap];
            arrayForSorting[firstIndexForSwap] = arrayForSorting[secondIndexForSwap];
            arrayForSorting[secondIndexForSwap] = temp;
        }

    }
}
