using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            MySimpleQueue Q = new MySimpleQueue(10);
            Console.WriteLine(Q.Dequeue());
            Q.Enqueue(1);	//Queue contains 1
            Q.Enqueue(2);	//Queue contains 1 2
            Q.Enqueue(3);	//Queue contains 1 2 3
            Console.WriteLine(Q.Dequeue()); //Prints 1, queue contains 2 3
            Console.WriteLine(Q.Dequeue()); //Prints 2, queue contains 3
            Console.WriteLine(Q.Dequeue());
            Console.WriteLine(Q.Count);
        }
    }
}
