using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject.Stack
{
    /// <summary>
    /// create stack class has private property index, maxSize and generic array
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class StackProject<T>
    {
        private int _maxSize { get; set; }
        private int _index { get; set; } = -1;
        private T[] _stack { get; set; }
        public StackProject(int maxSize)
        {
            this._maxSize = maxSize;
            _stack = new T[maxSize];
        }
        /// <summary>
        /// add element to stack, increase index when index  = 0 stack has
        /// 1 element
        /// </summary>
        /// <param name="item"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public void Push(T item)
        {
            if (_index == _stack.Length - 1)
            {
                throw new InvalidOperationException("Can not push");
            }
            else
            {
                _index++;
                _stack[_index] = item;
            }
        }
        /// <summary>
        /// removes and returns the item at the top of stack.
        /// decrease the index
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public T Pop()
        {
            if (_index == -1)
            {
                throw new InvalidOperationException("Cannot pop item from an empty stack.");
            }
            else
            {
                T item = _stack[_index];
                _index--;
                return item;
            }
        }
        /// <summary>
        /// return the first element from stack
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public T Peek()
        {
            if (_index == -1)
            {
                throw new InvalidOperationException("Cannot peek at an empty stack.");
            }
            return _stack[_index];
        }
        /// <summary>
        /// when stack empty index  = -1 so when stack has 1 element 
        /// count() = 0, -1 + 1
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _index + 1;
        }
        /// <summary>
        /// set the array to new empty array and set _maxSize = 0
        /// </summary>
        public void Clear()
        {
            Array.Clear(_stack, 0, _maxSize);
            _index = -1;
        }

    }
}
