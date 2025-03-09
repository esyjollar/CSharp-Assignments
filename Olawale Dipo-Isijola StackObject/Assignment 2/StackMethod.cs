using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class Stack
    {
        private List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add null to the stack.");

            _list.Add(obj);
        }

        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("Stack is empty.");

            var lastIndex = _list.Count - 1;
            var top = _list[lastIndex];
            _list.RemoveAt(lastIndex);
            return top;
        }

        public void Clear()
        {
            _list.Clear();
        }
    }
}
