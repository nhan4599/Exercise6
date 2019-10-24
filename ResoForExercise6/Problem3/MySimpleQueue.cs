using System;

namespace Problem3
{
    class MySimpleQueue
    {
        private int[] buffer;
        private int top;
        private int bot;

        public MySimpleQueue(int size)
        {
            buffer = new int[size];
            top = -1;
            bot = -1;
        }

        public int Count
        {
            get { return top - bot + 1; }
        }

        public void Enqueue(int x)
        {
            buffer[++top] = x;
            bot = top == 1 ? 0 : bot;
        }

        public int Dequeue()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Can't dequeue, this queue didn't have anything");
            }
            return buffer[bot++];
        }

        public int Peek()
        {
            return buffer[bot];
        }
    }
}
