using System;

namespace StackProj
{
    public class ArrayStack
    {
        private int[] _stack;
        private int _top;

        public ArrayStack(int stackSize)
        {
            _stack = new int[stackSize];
            _top = -1;
        }

        public void Push(int value)
        {
            if (!IsFull())
            {
                _stack[++_top] = value;
            }
            else
            {
                Console.WriteLine("Could not add {0} because the stack is full.", value);
            }

        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                _stack[_top--] = 0;
            }
            else
            {
                Console.WriteLine("Stack is empty.");
            }
        }

        public void Peek()
        {
            Console.WriteLine("{0} is the top element.", _stack[_top]);
        }

        private Boolean IsEmpty()
        {
            return _top == -1;
        }

        private Boolean IsFull()
        {
            return _top == _stack.Length - 1;
        }
    }
}
