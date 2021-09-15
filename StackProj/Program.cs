﻿using System;

namespace StackProj
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayListStack arrayListStack = new ArrayListStack();

            arrayListStack.Push(1);
            arrayListStack.Push(.00000002);
            arrayListStack.Push("Take that stack");
            // stack.Push(null);
            arrayListStack.Push(new int[8]);
            arrayListStack.StackCount();
            arrayListStack.Pop();
            arrayListStack.Pop();
            arrayListStack.StackCount();
            arrayListStack.Clear();
            arrayListStack.StackCount();

            Console.WriteLine("\n");

            ArrayStack arrayStack = new ArrayStack(5);

            arrayStack.Pop();

            for(int i =0; i < 5; i++)
            {
                arrayStack.Push(i);
            }

            arrayStack.Peek();
            
            for(int i = 0; i < 2; i++)
            {
                arrayStack.Pop();
            }

            arrayStack.Peek();

            for(int i = 0; i < 3; i++)
            {
                arrayStack.Push(i);
            }

            arrayStack.Peek();
        }
    }
}
