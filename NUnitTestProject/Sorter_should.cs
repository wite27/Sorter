using System;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using Sorter;

namespace NUnitTestProject
{
    //[TestFixture]
    public abstract class Sorter_should<T> where T : IComparable<T>
    {
        public abstract Sorter<T> GetSorter();

        [TestCase(new int[] { }, TestName = "Empty array")]
        [TestCase(new[] { 1 }, TestName = "Single number")]
        [TestCase(new[] { 6, 5, 4, 3, 2, 1 }, TestName = "Descending order")]
        [TestCase(new[] { 5, 7, 5, 3, 5, 10, 1, 20, 10, 5, 3, 1, 1 }, TestName = "Repeating values")]
        [TestCase(new[] { -5, 0, 5, -3, 5, -10, -1, 20, -10, 5, 3, -1, 1 }, TestName = "Negative values")]
        public void SortIntSequences(T[] seq)
        {
            var expectedSeq = seq.ToArray();
            Array.Sort(expectedSeq);

            GetSorter().Sort(seq);

            seq.Should().Equal(expectedSeq);
        }
    }
}