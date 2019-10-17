using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class MySimpleQueue
    {
        private int[] arr;

        public MySimpleQueue()
        {
            arr = new int[0];
        }

        public int Count
        {
            get { return arr.Length; }
        }

        public void Enqueue(int item)
        {
            ReAllocMemory("Enqueue");
            arr[Count - 1] = item;
        }

        public int Dequeue()
        {
            int value = arr[0];
            ReAllocMemory("Dequeue");
            return value;
        }

        public int Peek()
        {
            return arr[0];
        }

        private void ReAllocMemory(string act)
        {
            if (act == "Enqueue")
            {
                Array.Resize(ref arr, Count + 1);
            }else if (act == "Dequeue")
            {
                int[] temp = new int[Count - 1];
                Array.Copy(arr, 1, temp, 0, temp.Length);
                arr = temp;
            }
        }
    }
}
