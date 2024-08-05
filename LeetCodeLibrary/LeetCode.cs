namespace LeetCodeLibrary
{
    public class LeetCode : ILeetCode
    {

        public ListNode AddTwoNumbers(string[] mas1, string[] mas2)
        {
            var listNode1 = new ListNode(mas1);
            var listNode2 = new ListNode(mas2);
            string number1 = string.Empty;
            string number2 = string.Empty;
            while (listNode1 is not null || listNode2 is not null)
            {
                if (listNode1 is not null && listNode2 is not null)
                {
                    number1 += listNode1.val;
                    number2 += listNode2.val;
                    listNode1 = listNode1.next;
                    listNode2 = listNode2.next;
                }
                else if (listNode1 is not null)
                {
                    number1 += listNode1.val;
                    listNode1 = listNode1.next;
                }
                else
                {
                    number2 += listNode2.val;
                    listNode2 = listNode2.next;
                }
            }
            var res = (int.Parse(number1) + int.Parse(number2))
                .ToString()
                .Reverse()
                .Select(c => c.ToString())
                .ToArray();
            return new ListNode(res);
        }
        public int Divide(int dividend, int divisor)
        {
            if (divisor == dividend) return 1;
            if (divisor == 1) return dividend;
            if (divisor == -1)
            {
                return dividend == int.MinValue ? int.MaxValue : -dividend;
            }

            int result = 0;
            if (dividend > 0 && divisor > 0)
            {
                while (dividend >= 0)
                {
                    if (Int32.MaxValue - 1 == result) return Int32.MaxValue;
                    result++;
                    dividend -= divisor;
                }
                result--;
            }
            else if (dividend < 0 && divisor < 0)
            {
                while (dividend <= 0)
                {
                    if (Int32.MaxValue - 1 == result) return Int32.MaxValue;
                    result++;
                    dividend -= divisor;
                }
                result--;
            }
            else if (dividend < 0 && divisor > 0)
            {
                while (dividend <= 0)
                {
                    if (Int32.MinValue + 1 == result) return Int32.MinValue;
                    result--;
                    dividend += divisor;
                }
                result++;
            }
            else if (dividend > 0 && divisor < 0)
            {
                while (dividend >= 0)
                {
                    if (Int32.MinValue + 1 == result) return Int32.MinValue;
                    result--;
                    dividend += divisor;
                }
                result++;
            }

            return result;
        }
        public bool CanJump(int[] nums)
        {
            int finishIndex = nums.Length - 1;
            for (int i = finishIndex; i >= 0; i--)
            {
                if (i + nums[i] >= finishIndex)
                {
                    finishIndex = i;
                }
            }
            return finishIndex == 0;
        }
        public int LengthOfLongestSubstring(string s)
        {
            int size = s.Length;
            int right = 0;
            int left = 0;
            int maxLength = 0;
            List<char> sub = new List<char>();

            while (right < size)
            {
                if (!sub.Contains(s[right]))
                {
                    sub.Add(s[right]);
                    right++;
                    maxLength = Math.Max(maxLength, right - left);
                }
                else
                {
                    sub.Remove(s[left]);
                    left++;
                }
            }
            return maxLength;
        }
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
        }
        public bool IsValidBST(int[] array)
        {
            TreeNode root = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; ++i)
            {
                root = InsertRec(root, array[i]);
            }
            List<int> inorder = Inorder(root);
            if (inorder.Count == 0) return false;

            int prev = inorder[0];
            for (int i = 1; i < inorder.Count; i++)
            {
                if (prev < inorder[i])
                {
                    prev = inorder[i];
                }
                else
                    return false;
            }
            return true;
        }
        private List<int> Inorder(TreeNode node)
        {
            var result = new List<int>();
            if (node == null) return result;
            result.Add(node.val);
            if (node.left != null)
            {
                result.AddRange(Inorder(node.left));
            }
            if (node.right != null)
            {
                result.AddRange(Inorder(node.right));
            }
            return result;
        }
        private TreeNode InsertRec(TreeNode node, int value)
        {
            if (value == 0) return node;
            int comparison = Comparer<int>.Default.Compare(value, node.val);
            if (comparison < 0)
            {
                node.left = InsertRec(node.left, value);
            }
            else if (comparison > 0)
            {
                node.right = InsertRec(node.right, value);
            }
            return node;
        }
    }
}
