using System;
using System.Collections.Generic;
using System.Text;

namespace CircularQueue
{
    class CircularQueue<T>
    {
        private const int DefaultCapacity = 4;
        private T[] elements;

        private int startIndex;
        private int endIndex;

        public int Count { get; private set; }


        public CircularQueue(int capacity = DefaultCapacity)
        {
            this.elements = new T[capacity];
        }

        public void Enqueue(T element)
        {
            if (this.Count >= this.elements.Length)
            {
                this.Resize();
            }

            this.elements[this.endIndex] = element;
            endIndex = (this.endIndex + 1) % this.elements.Length;
            this.Count++;
        }

        private void Resize()
        {
            T[] newArray = new T[this.elements.Length * 2];
            this.CopyAllElements(newArray);

            this.elements = newArray;
            this.startIndex = 0;
            this.endIndex = Count;
        }

        private void CopyAllElements(T[] newArray)
        {
            int currentIndex = 0;
            int currentHead = this.startIndex;

            while (currentIndex < this.Count)
            {
                newArray[currentIndex++] = this.elements[currentHead];

                currentHead = (currentHead + 1) % this.elements.Length;
            }
        }

        public T Dequeue()
        {
            if (this.Count == 0) throw new InvalidOperationException();

            T result = this.elements[startIndex];
            this.startIndex = (this.startIndex + 1) % this.elements.Length;

            this.Count--;

            return result;
        }

        public T[] ToArray()
        {
            T[] result = new T[Count];

            if (endIndex < elements.Length && endIndex > startIndex)
            {
                for (int k = 0,  i = startIndex; i < endIndex; i++)
                    result[k++] = elements[i];
  

            }
            else
            {
                int j = 0;
                for (int i = startIndex; i < elements.Length; i++)
                    result[j++] = elements[i];

                for (int i = 0; i < endIndex; i++)
                    result[j++] = elements[i];
                
            }

            return result;
        }
    }
}
