using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Apple");

            // Clear the whole stack
            stack.Clear();

            stack.Push("Orange");
            stack.Push("Pear");
            stack.Push("Bannana");
            

            Console.WriteLine($"Count: {stack.Count}, Seek: {stack.Seek()}, Pop last element: {stack.Pop()}");


            Console.WriteLine($"Count: {stack.Count}");
            stack.GetElements().ForEach(e => Console.WriteLine(e));
        }
    }
}
