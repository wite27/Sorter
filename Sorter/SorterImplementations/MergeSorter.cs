using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter.SorterImplementations
{
    public class MergeSorter<T> : Sorter<T> where T : IComparable<T>
    {
        public override void Sort(T[] coll)
        {
            if (coll.Length == 0 || coll.Length == 1)
                return;
            sort(0, coll.Length-1, coll);
        }

        private void sort(int low, int high, T[] coll)
        {
            if (low == high)
                return;

            var med = (high + low) / 2;

            sort(low, med, coll);
            sort(med+1, high, coll);
            merge(low, med, med+1, high, coll);
        }

        private void merge(int firstLow, int firstHigh, int secondLow, int secondHigh, T[] coll)
        {
            var firstCurrent  = firstLow;
            var secondCurrent = secondLow;

            var temp = new T[(firstHigh - firstLow + 1) + (secondHigh - secondLow + 1)];
            var tempCurrent = 0;
            while (firstCurrent <= firstHigh &&
                   secondCurrent <= secondHigh)
            {
                if (coll[firstCurrent].CompareTo(coll[secondCurrent]) < 0)
                {
                    temp[tempCurrent++] = coll[firstCurrent++];
                }
                else
                {
                    temp[tempCurrent++] = coll[secondCurrent++];
                }
            }
            while (firstCurrent <= firstHigh)
                temp[tempCurrent++] = coll[firstCurrent++];
            while (secondCurrent <= secondHigh)
                temp[tempCurrent++] = coll[secondCurrent++];

            Array.Copy(temp, 0, coll, firstLow, temp.Length);
        }
    }
}
