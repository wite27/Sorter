using NUnit.Framework;
using Sorter;
using Sorter.SorterImplementations;

namespace NUnitTestProject
{
    [TestFixture]
    public class BubbleSorter_should : Sorter_should<int>
    {
        public override Sorter<int> GetSorter()
        {
            return new BubbleSorter<int>();
        }
    }
}