using System;
using System.Collections;

namespace StackProj
{
    class Stack
    {
        private ArrayList _Stack;

        public Stack()
        {
            _Stack = new ArrayList();
        }

        public void Push(Object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException();
            }
            else
            {
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
                var obj = _Stack[_Stack.Count - 1];
                _Stack.RemoveAt(_Stack.Count - 1);
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
