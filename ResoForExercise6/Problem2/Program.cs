using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            MySimpleStack S = new MySimpleStack();
            S.Put(1);   //Stack contains 1
            S.Put(2);   //Stack contains 1 2
            S.Put(3);   //Stack contains 1 2 3
            Console.WriteLine(S.Pop()); //Prints 3, stack contains 1 2
            Console.WriteLine(S.Pop()); //Prints 2, stack contains 1
            Console.WriteLine(S.Count);
        }
    }
}
