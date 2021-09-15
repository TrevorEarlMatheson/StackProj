using System;
using System.Collections;

namespace StackProj
{
    class Stack
    {
        private ArrayList _Stack;
        private int _Top;

        public Stack()
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
            }
        }

        public Object Pop()
        {
            if(_Stack.Count <= 0)
            {
                throw new InvalidOperationException();
            }
            else
            {
                var obj = _Stack[_Top];
                _Stack.RemoveAt(_Top);
                _Top--;
                return obj;
            }
        }

        public void Clear()
        {
            _Stack.Clear();
        }

        public void StackCount()
        {
            Console.WriteLine("Current stack count: {0}", _Stack.Count);
        }
    }
}
