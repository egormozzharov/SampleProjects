using NUnit.Framework;
using Substring;

namespace SubstringTests
{
    public class StringExtensionsTests
    {
        [Test]
        [TestCase("String in which substring", "st", 0)]
        [TestCase("String in which substring", "in", 3)]
        [TestCase("String in which substring", "which", 10)]
        [TestCase("String in which substring", "substring", 16)]
        [TestCase("substring", "verylongsubstring", -1)]
        [TestCase("", "", 0)]
        [TestCase("aaaaaa", "bb", -1)]

        public void ShouldReturnCorrectIndex(string testString, string substring, int expected)
        {
            // Act
            int actualResult = testString.MySubstring(substring);

            // Assert
            Assert.AreEqual(expected, actualResult);
        }
    }
}