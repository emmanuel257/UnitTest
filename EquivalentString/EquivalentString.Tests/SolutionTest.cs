using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquivalentString.Tests
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void TwoEmptyArraysShouldBeEqual()
        {
            //Arrange
            var word1 = new string[] { };
            var word2 = new string[] { };
            var sut = new Solution();

            //Act
            var isEqual = sut.ArrayStringsAreEqual(word1, word2);

            //Assert
            Assert.IsTrue(isEqual, "Array of String are not Equal");
        }

        [TestMethod]
        public void TwoIncorrectArraysShouldNotBeEqual()
        {
            //Arrange
            var word1 = new string[] { "a", "cb" };
            var word2 = new string[] { "ab", "c" };
            var sut = new Solution();

            //Act
            var isEqual = sut.ArrayStringsAreEqual(word1, word2);

            //Assert
            Assert.IsFalse(isEqual, "Array of String should not be Equal");
        }

        [TestMethod]
        public void TwoCorrectArraysShouldBeEqual()
        {
            //Arrange
            var word1 = new string[] { "ab", "c" };
            var word2 = new string[] { "a", "bc" };
            var sut = new Solution();

            //Act
            var isEqual = sut.ArrayStringsAreEqual(word1, word2);

            //Assert
            Assert.IsTrue(isEqual, "Array of String should be Equal");
        }

    }
}
