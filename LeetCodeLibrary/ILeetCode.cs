namespace LeetCodeLibrary
{
    public interface ILeetCode
    {
        /// <summary>
        /// Комментарий с описанием задачи.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        ListNode AddTwoNumbers(string[] l1, string[] l2);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        bool CanJump(int[] nums);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        int LengthOfLongestSubstring(string s);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        void Rotate(int[] nums, int k);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        bool IsValidBST(int[] array);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dividend"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        int Divide(int dividend, int divisor);
    }
}
