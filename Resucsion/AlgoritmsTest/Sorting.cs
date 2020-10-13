using Algoritms;
using NUnit.Framework;
using System.Collections.Generic;

namespace AlgoritmsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        #region QSort

        [Test]
        public void Test1()
        {
            // Arrange
            var list = new List<int>() { 6, 2, 4, 1, 3, 7 };

            // Act
            var actualResult = Sorting.QSort(list);

            // Assert
            var expected = new List<int>() { 1, 2, 3, 4, 6, 7 };
            Assert.That(actualResult, Is.EquivalentTo(expected));
        }

        #endregion
    }
}