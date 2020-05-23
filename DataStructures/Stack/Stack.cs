using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    // Implementation using an array
    class Stack<T>
    {
        private const int defaultValue = 1; // default value
        private static int length = defaultValue;  
        private T[] array = new T[length];
        public int Count { get; private set; } = 0;
    

        public void Push(T item)
        {
             if(Count < length)
            {
                length *= 2;
                T[] newArray = new T[length];
                array.CopyTo( newArray ,0);
                array = newArray;
            }
            array[Count++] = item;
        
        }

        public T Pop()
        {
            if (Count == 0) return array[Count];
                return array[--Count];
        }

        public T Seek()
        {
            if (Count == 0) return array[Count];
            return array[Count - 1];
        }

        public void Clear()
        {
            array = new T[defaultValue];
            length = defaultValue;
            Count = 0;
        }

        public List<T> GetElements()
        {
            T[] newArray = new T[Count];
            Array.Copy(array, 0, newArray, 0, Count);
            return newArray.OfType<T>().ToList();
        }

    }
}
