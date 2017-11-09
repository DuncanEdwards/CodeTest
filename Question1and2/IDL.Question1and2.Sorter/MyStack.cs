using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDL.Question1and2.Sorter
{
    public class MyStack
    {

        readonly private List<object> _stackValues = new List<object>();


        public object Peek()
        {
            if (!_stackValues.Any())
            {
                // Assumption, return null if nothing in stack
                return null;
            }
            return _stackValues.Last();
            
        }

        public object Pop()
        {
            if (!_stackValues.Any())
            {
                // Assumption, return null if nothing in stack
                return null;
            }
            var lastValue = _stackValues.Last();
            _stackValues.Remove(lastValue);
            return lastValue;
        }

        public void Push(object value)
        {
            _stackValues.Add(value);
        }

        public void Clear()
        {
            _stackValues.Clear();
        }
    }
}
