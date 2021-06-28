namespace Yord.Crack.Begin.LeetCode
{
    // реверснуть связынй список
    public class Task_206
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

        public static ListNode ReverseList2(ListNode head)
        {
            return Swap(head, null);
        }

        private static ListNode Swap(ListNode node, ListNode prev)
        {
            if (node == null)
            {
                return prev;
            }

            var next = node.next;
            node.next = prev;
             return Swap(next, node);

        }
        public static ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            var node = head;
            while (node != null)
            {
                var next = node.next;
                node.next = prev;
                prev = node;
                node = next;
            }

            return prev;
        }
    }
}
