using System;
using System.Collections.Generic;
using System.Text;

namespace _03.RangeExceptions
{
    class InvalidRangeException<T> where T : IComparable
    {
        private T start;
        private T end;

        public InvalidRangeException (T _start, T _end)
        {
            start = _start;
            end = _end;
        }

        public bool CheckRange(T _value)
        {
            if(start.CompareTo(_value) <= 0 && _value.CompareTo(end) <= 0)
            {
                return true;
            }
            return false;
        }

    }
}
