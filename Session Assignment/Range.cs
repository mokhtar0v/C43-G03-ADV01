using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Assignment
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; }
        public T Max { get; }
        public Range(T Min, T Max)
        {
            this.Min = Min;
            this.Max = Max;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }
        public dynamic Length()
        {
            return (dynamic)Max - Min;

        }
    }
}
