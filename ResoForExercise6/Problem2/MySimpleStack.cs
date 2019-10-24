using System;

namespace Problem2
{
    public class MySimpleStack
    {
        private readonly int[] buffer;
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
            if (top == buffer.Length - 1)
            {
                throw new InvalidOperationException("Can't Push, this stack is full size");
            }
            buffer[++top] = x;
        }

        public object Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Can't Pop, this stack is empty");
            }
            return buffer[top--];
        }

        public void Clear()
        {
            top = -1;
        }
    }
}
