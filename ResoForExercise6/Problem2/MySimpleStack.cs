using System;

namespace Problem2
{
    class MySimpleStack
    {
        private int[] arr;

        public int Count
        {
            get { return arr.Length; }
        }

        public MySimpleStack()
        {
            arr = new int[0];
        }

        public void Put(int item)
        {
            ReAllocMemory("PUT");
            arr[Count - 1] = item;
        }

        public int Pop()
        {
            int value = arr[Count - 1];
            ReAllocMemory("POP");
            return value;
        }

        public int Peek()
        {
            return arr[Count - 1];
        }

        private void ReAllocMemory(string act)
        {
            if (act == "PUT")
            {
                Array.Resize(ref arr, Count + 1);
            }else if (act == "POP")
            {
                Array.Resize(ref arr, Count - 1);
            }
        }
    }
}
