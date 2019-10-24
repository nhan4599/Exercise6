using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //MySimpleStack S = new MySimpleStack(10);
            //S.Push(1);   //Stack contains 1
            //S.Push(2);   //Stack contains 1 2
            //S.Push(3);   //Stack contains 1 2 3
            //Console.WriteLine(S.Pop()); //Prints 3, stack contains 1 2
            //Console.WriteLine(S.Pop()); //Prints 2, stack contains 1
            //Console.WriteLine(S.Count);

            string[] name = { "Pham", "Ngoc", "Duy" };

            MySimpleStack s = new MySimpleStack(name.Length);

            for (int i = 0; i < name.Length; i++)
            {
                s.Push(name[i]);
            }

            for (int i = 0; i < name.Length; i++)
            {
                name[i] = s.Pop().ToString();
            }

            foreach (string i in name)
            {
                Console.Write(i + " ");
            }
        }
    }

}
