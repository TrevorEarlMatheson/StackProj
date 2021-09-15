using System;
using System.Collections;

namespace StackProj
{
    class ArrayListStack
    {
        private ArrayList _Stack;
        private int _Top;

        public ArrayListStack()
        {
            _Stack = new ArrayList();
            _Top = -1;
        }

        public void Push(Object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
                _Top++;
                _Stack.Add(obj);
                Console.WriteLine("\"{0}\" added to the stack.", _Stack[_Top]);
            }
        }

        public void Pop()
        {
            if(_Stack.Count <= 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                Console.WriteLine("\"{0}\" removed from the stack.", _Stack[_Top]);
                _Stack.RemoveAt(_Top);
                _Top--;
            }
        }

        public void Clear()
        {
            Console.WriteLine("The stack has been cleared");
            _Stack.Clear();
        }

        public void StackCount()
        {
            Console.WriteLine("Current stack count: {0}", _Stack.Count);
        }
    }
}
