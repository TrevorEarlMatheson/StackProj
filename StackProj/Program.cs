using System;

namespace StackProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(.00000002);
            stack.Push("Take that stack");
            // stack.Push(null);
            stack.Push(new int[8]);

            stack.StackCount();

            Console.WriteLine(stack.Pop());

            Console.WriteLine(stack.Pop());

            stack.StackCount();

            stack.Clear();

            stack.StackCount();
        }
    }
}
