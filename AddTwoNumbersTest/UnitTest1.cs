using LeetCodeLibrary;
namespace AddTwoNumbersTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddTwoNumbersMethodTest()
        {
            var mas1 = LeetCode.Init([2, 4, 3]);
            var mas2 = LeetCode.Init([5, 6, 4]);
            var res = new LeetCode().AddTwoNumbers(mas1, mas2);
            var answer = LeetCode.Init([7, 0, 8]);
            while(res is not null)
            {
                Assert.AreEqual(res.val, answer.val);
                res = res.next;
                answer = answer.next;
            }
        }
        [TestMethod]
        public void DivideTest() {
            var answer = LeetCode.Divide(-2147483648, 1);
            var answer1 = LeetCode.Divide(10, 3);
            var answer2 = LeetCode.Divide(7, -3);
            Assert.AreEqual(answer, -2147483648);
            Assert.AreEqual(answer1, 3);
            Assert.AreEqual(answer2, -2);
        }
        [TestMethod]
        public void CanJumpTest()
        {
            var answer = LeetCode.CanJump([2, 3, 1, 1, 4]);
            var answer1 = LeetCode.CanJump([3, 2, 1, 0, 4]);
            Assert.AreEqual(answer, true);
            Assert.AreEqual(answer1, false);
        }
        [TestMethod]
        public void LengthOfLongestSubstringTest()
        {
            var answer = LeetCode.LengthOfLongestSubstring("abcabcbb");
            var answer1 = LeetCode.LengthOfLongestSubstring("bbbbb");
            var answer2 = LeetCode.LengthOfLongestSubstring("pwwkew");
            Assert.AreEqual(answer, 3);
            Assert.AreEqual(answer1, 1);
            Assert.AreEqual(answer2, 3);
        }
        [TestMethod]
        public void RotateTest()
        {
            int[] mas1 = [1, 2, 3, 4, 5, 6, 7];
            int[] mas2 = [-1, -100, 3, 99];

            LeetCode.Rotate(mas1, 3);
            LeetCode.Rotate(mas2, 2);
            
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