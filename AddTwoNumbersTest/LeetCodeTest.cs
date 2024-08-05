using LeetCodeLibrary;
namespace AddTwoNumbersTest
{
    [TestClass]
    public class LeetCodeTest
    {
        private readonly LeetCode leetCode;
        public LeetCodeTest()
        {
            // Arrange
            leetCode = new LeetCode();
        }

        [TestMethod]
        [DataRow(new string[] { "2", "4", "3" }, new string[] { "5", "6", "4" }, new string[] { "7", "0", "8" })]
        [DataRow(new string[] { "1", "7", "4" }, new string[] { "4", "5", "3" }, new string[] { "7", "2", "6" })]
        public void AddTwoNumbersMethodTest(string[] mas1, string[] mas2, string[] result)
        {
            // Arrange
            // Act
            var res = leetCode.AddTwoNumbers(mas1, mas2);
            var answer = new ListNode(result);
            // Assert
            Assert.IsTrue(answer.Equals(res));
        }
        [TestMethod]
        public void DivideTest()
        {
            var answer = leetCode.Divide(-2147483648, 1);
            var answer1 = leetCode.Divide(10, 3);
            var answer2 = leetCode.Divide(7, -3);
            Assert.AreEqual(answer, -2147483648);
            Assert.AreEqual(answer1, 3);
            Assert.AreEqual(answer2, -2);
        }
        [TestMethod]
        public void CanJumpTest()
        {
            var answer = leetCode.CanJump([2, 3, 1, 1, 4]);
            var answer1 = leetCode.CanJump([3, 2, 1, 0, 4]);
            Assert.AreEqual(answer, true);
            Assert.AreEqual(answer1, false);
        }
        [TestMethod]
        public void LengthOfLongestSubstringTest()
        {
            var answer = leetCode.LengthOfLongestSubstring("abcabcbb");
            var answer1 = leetCode.LengthOfLongestSubstring("bbbbb");
            var answer2 = leetCode.LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(answer, 3);
            Assert.AreEqual(answer1, 1);
            Assert.AreEqual(answer2, 3);
        }
        [TestMethod]
        public void RotateTest()
        {
            int[] mas1 = [1, 2, 3, 4, 5, 6, 7];
            int[] mas2 = [-1, -100, 3, 99];

            leetCode.Rotate(mas1, 3);
            leetCode.Rotate(mas2, 2);

            CollectionAssert.AreEqual(mas1, (int[])[5, 6, 7, 1, 2, 3, 4]);
            CollectionAssert.AreEqual(mas2, (int[])[3, 99, -1, -100]);
        }
        public void IsValidBSTTest()
        {
            int[] mas1 = [2, 1, 3];
            int[] mas2 = [5, 1, 4, 0, 0, 3, 6];
        }
    }

}