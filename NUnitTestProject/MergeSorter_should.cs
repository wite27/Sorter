using NUnit.Framework;
using NUnitTestProject;
using Sorter;
using Sorter.SorterImplementations;

namespace NUnitTestProject
{
    [TestFixture]
    public class MergeSorter_should : Sorter_should<int>
    {
        public override Sorter<int> GetSorter()
        {
            return new MergeSorter<int>();
        }
    }
}