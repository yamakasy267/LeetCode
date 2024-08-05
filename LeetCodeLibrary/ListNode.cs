namespace LeetCodeLibrary
{
    public class ListNode : IEquatable<ListNode>
    {
        public string val;
        public ListNode next;
        public ListNode(string val = "")
        {
            this.val = val;
        }

        public ListNode(string[] mas) : this(mas[0])
        {
            if (mas.Length > 1)
            {
                this.next = new ListNode(mas[1..]);
            }
        }

        public bool Equals(ListNode? other)
        {
            if (other == null) return false;
            // If run-time types are not exactly the same, return false.
            if (this.GetType() != other.GetType())
            {
                return false;
            }
            if (val != other.val) return false;
            return (next is null && other.next is null) || (next != null && next.Equals(other.next));
        }
    }
}
