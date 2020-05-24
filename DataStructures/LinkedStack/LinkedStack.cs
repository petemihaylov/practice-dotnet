using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LinkedStack
{
    class LinkedStack<T> : IEnumerable<T>
    {
        public int Count { get; private set; } = 0;

        private StackNode top;
        
        public void Push(T element)
        {
            this.top = new StackNode(element, this.top);
            Count++;
        }

        public T Pop()
        {
            if (Count == 0) throw new InvalidOperationException();

            T output = this.top.Value;
            this.top = this.top.Next;
            this.Count--;

            return output;
        }

        public T Peek()
        {
            if (Count == 0) throw new InvalidOperationException();
            return this.top.Value;
        }

        public T[] ToArray()
        {
            T[] arr = new T[this.Count];

            StackNode stackNode = this.top;

            int index = 0;

            while (stackNode!= null)
            {
                arr[index++] = stackNode.Value;
                stackNode = stackNode.Next;
            }

            return arr;
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class StackNode
        {
            public T Value { get; set; }
            public StackNode Next { get; set; }

            public StackNode(T value, StackNode next)
            {
                this.Value = value;
                this.Next = next;
            }
        }
    }
}
