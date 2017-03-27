using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.SorterImplementations
{
    class MergeSorter<T> : Sorter<T> where T : IComparable<T>
    {
        public override void Sort(T[] coll)
        {
            throw new NotImplementedException();
        }
    }
}
