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
                Console.WriteLine("Added {0} to the stack", value);
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
                Console.WriteLine("Removed {0} from the stack", _stack[_top]);
                _stack[_top--] = 0;
            }
            else
            {
                Console.WriteLine("Cannot remove from an empty stack.");
            }
        }

        public void Peek()
        {
            Console.WriteLine("{0} is the top element.", _stack[_top]);
        }

        public void Count()
        {
            Console.WriteLine("There are {0}/{1} elements in the stack.", _top + 1, _stack.Length);
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
