using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    public class CircularBufferQueue : Buffer
    {        
        private int queueHead;
        private int queueTail;
        private int numberOfUtilizedQueueElements;

        
        public CircularBufferQueue(int size) : base (size)
        {            
            queueHead = 0;
            queueTail = 0;
            numberOfUtilizedQueueElements = 0;
        }


        public int Dequeue()
        {
            int returnValue = 0;

            if (!IsEmpty())
            {
                returnValue = arrayForElements[queueHead];
                arrayForElements[queueHead] = 0;
                queueHead = WhatIsNextCellIndexForTailOrHead(queueHead);
                numberOfUtilizedQueueElements--;
            }
            else
            {
                Console.WriteLine("Cannot dequeue from the queue");
                returnValue = 0;
            }

            return returnValue;
        }

        public void Enqueue(int valueToBeAddedToQueue)
        {
            if (!IsFull())
            {
                arrayForElements[queueTail] = valueToBeAddedToQueue;
                queueTail = WhatIsNextCellIndexForTailOrHead(queueTail);
                numberOfUtilizedQueueElements++;
            }
            else
            {
                Console.WriteLine("Cannot enqueue the queue.");
            }
        }

        public override bool IsFull()
        {
            bool returnValue = false;

            if (numberOfUtilizedQueueElements == arrayForElements.Length)
            {
                Console.WriteLine("The queue is full.");
                returnValue = true;
            }

            return returnValue;
        }

        private int WhatIsNextCellIndexForTailOrHead(int currentIndex)
        {
            int returnValue = 0;

            if (currentIndex < arrayForElements.Length - 1)
            {
                returnValue = currentIndex + 1;
            }

            return returnValue;
        }

        public override bool IsEmpty()
        {
            bool returnValue = false;

            if (numberOfUtilizedQueueElements == 0)
            {
                Console.WriteLine("The queue is empty.");
                returnValue = true;
            }

            return returnValue;
        }

    }
}
