using System;

namespace Problem2
{
    public class MySimpleStack
    {
        private object[] buffer;
        private int top;

        public int Count
        {
            get { return top + 1; }
        }

        public MySimpleStack(int size)
        {
            buffer = new object[size];
            top = -1;
        }

        public void Push(object x)
        {
            buffer[++top] = x;
        }

        public object Pop()
        {
            return buffer[top--];
        }

        public void Clear()
        {
            top = -1;
        }
    }
}
