using System;

namespace Sorter
{
    public abstract class Sorter<T> where T : IComparable<T>
    {
        public abstract void Sort(T[] coll);

        protected void Swap(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
