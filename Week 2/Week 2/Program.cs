using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Week_2
{
    class Program
    {
    
        
        static void Main(string[] args)
        {
            LinkedList<int> test = new LinkedList<int>();
            Pstack<int> test2 = new Pstack<int>();
            Pqueue<int> test3 = new Pqueue<int>();
            test.AddItem(2);
            test.AddItem(2);
            test.AddItem(3);
            test.AddItem(6);
            test.AddItem(3);
           
            test.Delete(2);
            //test.Display();

            //Console.Write(test.Index(6));

            test2.Push(1);
            test2.Push(2);
            test2.Push(3);
            //Console.WriteLine(test2.Pop());
            //Console.WriteLine(test2.Peek());
            //test2.Display();

            test3.Enqueue(12);
            test3.Enqueue(123);
            test3.Enqueue(1234);
            test3.Enqueue(12345);
            test3.Enqueue(121234);

            test3.Display();
            Console.WriteLine(test3.Size());
        }
    }
}
