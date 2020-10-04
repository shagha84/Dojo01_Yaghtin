using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo01_Yaghtin
{
    class Stapel<T>
    {

        private StapelElement<T> _currentElement; //stores the latest entry of the stack

        /// Adds new Elements to the stack 
        /// <param name="item">item which should be added to the stack</param>
        public void Push(T item)
        {
            if (_currentElement == null)
            {
                _currentElement = new StapelElement<T>() { ValueOfElement = item, Successor = null };
            }
            else
            {
                StapelElement<T> temp = new StapelElement<T>() { ValueOfElement = item, Successor = _currentElement };
                _currentElement = temp;
            }

        }
        /// Removes the last entry from the Stack
        /// If the stack is empty pop will return a default value
        /// <returns>deleted stack entry</returns>
        public T Pop()
        {
            if (_currentElement != null)
            {
                T temp = _currentElement.ValueOfElement;
                _currentElement = _currentElement.Successor;
                return temp;
            }
            else
            {
                throw new NullReferenceException(); //throw an exception because stack is entry
            }
        }
        /// Returns the value of the last entry (on top of the stack)
        /// If the stack is empty pop will return a default value
        /// <returns>value of current stack entry</returns>
        public T Peek()
        {
            if (_currentElement != null)
            {
                return _currentElement.ValueOfElement;
            }
            else
            {
                return default(T);
            }
        }

    }
}