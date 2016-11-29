using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    public class Stack : Buffer
    {        
        private int stackTail;


        public Stack(int size) : base (size)
        {            
            stackTail = 0;
        }


        public int Pop()
        {
            Console.WriteLine("\nTry to pop the element.");

            int valueToReturn = 0;

            if (!IsEmpty())
            {
                valueToReturn = arrayForElements[stackTail - 1];
                arrayForElements[stackTail - 1] = 0;
                stackTail--;
            }
            else
            {
                Console.WriteLine("Cannot pop element from the stack. The stack is empty.");
            }

            return valueToReturn;
        }

        public void Push(int valueToAdd)
        {
            Console.WriteLine("\nTry to push the element.");

            if (!IsFull())
            {
                arrayForElements[stackTail] = valueToAdd;
                stackTail++;
            }
            else
            {
                Console.WriteLine("Cannot add value to the stack. The stack is already full.");
            }
        }

        public int Peek()
        {
            Console.WriteLine("\nTry to peek the element.");

            int valueToReturn = 0;

            if (!IsEmpty())
            {
                valueToReturn = arrayForElements[stackTail - 1];
            }
            else
            {
                Console.WriteLine("Cannot peek element from the stack. The stack is empty.");
            }

            return valueToReturn;
        }

        public override bool IsFull()
        {
            if (stackTail == arrayForElements.Length)
            {
                Console.WriteLine("The stack is full.");
                return true;
            }
            else
            {
                Console.WriteLine("The stack is not full.");
                return false;
            }
        }

        public override bool IsEmpty()
        {
            if (stackTail == 0)
            {
                Console.WriteLine("The stack is empty.");
                return true;
            }
            else
            {
                Console.WriteLine("The stack is not empty.");
                return false;
            }
        }

    }
}
