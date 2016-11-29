using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    class TestQueue
    {
        //Method that contains set of actions to test the Queue with lenght 5
        public void TestTheQueue()
        {
            var newQueue = new CircularBufferQueue(5);

            Console.WriteLine("-----------------\n");
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            int dequeuedValue = 0;
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(1);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(2);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(3);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(4);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(5);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(6);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(7);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(8);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(9);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(10);
            newQueue.Print();
            Console.WriteLine("-----------------\n");

        }
    }
}
