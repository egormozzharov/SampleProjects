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

        public void ShouldReturnCorrectIndex(string testString, string substring, int expected)
        {
            // Act
            int actualResult = testString.MySubstring(substring);

            // Assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase("substring", "verylongsubstring")]
        public void ShouldReturnNotFoundIndexIfSubstringIsLongerThanSourceString(string testString, string substring)
        {
            // Act
            int actualResult = testString.MySubstring(substring);

            // Assert
            Assert.AreEqual(-1, actualResult);
        }
    }
}