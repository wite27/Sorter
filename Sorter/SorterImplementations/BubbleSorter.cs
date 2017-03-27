using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.SorterImplementations
{
    public class BubbleSorter<T> : Sorter<T> where T : IComparable<T>
    {
        public override void Sort(T[] coll)
        {
            int len = coll.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (coll[j].CompareTo(coll[i]) > 0)
                        Swap(ref coll[j], ref coll[i]);
                }
            }
        }
    }
}
