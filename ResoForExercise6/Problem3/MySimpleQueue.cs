using System;

namespace Problem3
{
    class MySimpleQueue
    {
        private readonly int[] buffer;
        private int top;
        private int bot;

        public MySimpleQueue(int size)
        {
            buffer = new int[size];
            top = 0;
            bot = 0;
        }

        public int Count
        {
            get { return top - bot; }
        }

        public void Enqueue(int x)
        {
            if (top == buffer.Length)
            {
                throw new InvalidOperationException("Can't Enqueue, this queue is full size");
            }
            buffer[top++] = x;
        }

        public int Dequeue()
        {
            if (bot >= top)
            {
                throw new InvalidOperationException("Can't Dequeue, this queue is empty");
            }
            return buffer[bot++];
        }

        public int Peek()
        {
            if (bot >= top)
            {
                throw new InvalidOperationException("Can't Peek, this queue is empty");
            }
            return buffer[bot];
        }
    }
}
