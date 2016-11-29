using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask6
{
    class TestStack
    {
        public void TestTheStack()
        {
            var newStack = new Stack(3);
            newStack.Print();

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(5);
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(6);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(7);
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(8);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(9);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(10);
            newStack.Print();
            Console.WriteLine("-----------------");

            newStack.Push(11);
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.Print();
            Console.WriteLine("-----------------");
        }

    }
}
