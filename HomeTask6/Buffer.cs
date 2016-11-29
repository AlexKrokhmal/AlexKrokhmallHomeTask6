using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    public class Buffer
    {        
        protected int[] arrayForElements;


        //public int[] ArrayForElements { protected set; get; }


        public Buffer(int size)
        {
            arrayForElements = new int[size];
        }


        public virtual bool IsFull()
        {
            Console.WriteLine("\nThe method is empty (virtual)\n");
            return true;                        
        }

        public virtual bool IsEmpty()
        {
            Console.WriteLine("\nThe method is empty (virtual)\n");
            return false;
        }

        public void Print()
        {
            Console.WriteLine();
            foreach (int i in arrayForElements)
            {
                Console.Write("{0}  ", i);
            }
            Console.WriteLine();
        }               

    }
}
