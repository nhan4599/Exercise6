using System;

namespace Problem2
{
    class MySimpleStack
    {
        private int[] buffer;
        private int top;

        public int Count
        {
            get { return top + 1; }
        }

        public MySimpleStack(int size)
        {
            buffer = new int[size];
            top = -1;
        }

        public void Push(int x)
        {
            buffer[++top] = x;
        }

        public int Pop()
        {
            return buffer[top--];
        }

        public void Clear()
        {
            top = -1;
        }
    }
}
