using System;

namespace CircularQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<int> queue = new CircularQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();




            Console.WriteLine(string.Join(", ", queue.ToArray()));
        }
    }
}
