namespace LeetCodeLibrary
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class LeetCode
    {
        
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            string number1 = "", number2 = "";
            while (l1 is not null || l2 is not null)
            {
                if (l1 is not null && l2 is not null)
                {
                    number1 += l1.val.ToString();
                    number2 += l2.val.ToString();
                    l1 = l1.next;
                    l2 = l2.next;
                }
                else if (l1 is not null)
                {
                    number1 += l1.val.ToString();
                    l1 = l1.next;
                }
                else
                {
                    number2 += l2.val.ToString();
                    l2 = l2.next;
                }
            }
            var res = (Int32.Parse(number1) + Int32.Parse(number2)).ToString();
            ListNode node = new ListNode();
            ListNode firstNode = node;
            for (var i = res.Length - 1; i > -1; i--)
            {
                node.val = Int32.Parse(res[i].ToString());
                if (i != 0)
                {
                    node.next = new ListNode();
                    node = node.next;
                }
            }
            return firstNode;
        }
        public static int Divide(int dividend, int divisor)
        {
            if (divisor == dividend) return 1;
            if (divisor == 1) return dividend;

            if (divisor == -1)
            {
                if (dividend == Int32.MinValue)
                    return Int32.MaxValue;
                else
                    return -dividend;
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
        public static bool CanJump(int[] nums)
        {
            int finishIndex = nums.Length - 1;
            for (int i = finishIndex; i >= 0; i--)
            {
                if (i + nums[i] >= finishIndex)
                {
                    finishIndex = i;
                }
            }
            return finishIndex == 0 ? true : false;
        }
        public static int LengthOfLongestSubstring(string s)
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
        public static void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
        }
        List<int> inorder = new List<int>();
        public bool IsValidBST(TreeNode root)
        {
            Inorder(root);

            if (inorder.Count() == 0) return false;

            int prev = inorder[0];
            for (int i = 1; i < inorder.Count(); i++)
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
        private void Inorder(TreeNode node)
        {
            if (node == null) return;

            if (node.left != null || node.right != null)
            {
                Inorder(node.left);
                inorder.Add(node.val);
                Inorder(node.right);
            }
            else
            {
                inorder.Add(node.val);
            }

        }
        public static ListNode Init(int[] mas)
        {

            var node = new ListNode(mas[^1]);
            for (int i = mas.Length - 2; i >= 0; i--)
            {
                var nextNode = new ListNode(mas[i], node);
                node = nextNode;
            }
            return node;
        }
        public static TreeNode InitTree(int[] nodes)
        {
            TreeNode tree = new TreeNode(nodes[0]);
            for (int i = 1; i < nodes.Length; ++i)
            {
                tree = InsertRec(tree, nodes[i]);
            }
            return tree;
        }
        private static TreeNode InsertRec(TreeNode node, int value)
        {
            if (value == 0)
            {
                return node;
            }

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
