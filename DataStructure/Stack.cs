using System;
using System.Collections.Generic;

namespace DataStructure
{
    
    public class Stack<T>
    {
        private List<T> _stack = new List<T>();
        public Stack()
        {

        }

        public void Push(T item)
        {
            if (item != null)
            {
                _stack.Add(item);
            }

        }

        public void Pop()
        {
            if (_stack.Count > 0)
            {

                _stack.RemoveAt(_stack.Count - 1);
            }
        }

        public T Peek()
        {
            //DRAWback of using Generics, you cannot return default generic as default can be a actual value in the stack.
            //If peek is called on an empty stack it will throw an error.
            return _stack[_stack.Count - 1];
        }
    }
}
