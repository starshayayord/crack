namespace Yord.Crack.Begin.LeetCode
{
    //сконвертировать связный списко в число 
    // head = [1,0,0,1,0,0,1,1,1,0,0,0,0,0,0] => 18880
    public class Task_1290
    {
        public int GetDecimalValue(ListNode head)
        {
            while (true)
            {
                if (head.next == null) return head.val;
                head.next.val += head.val << 1;
                head = head.next;
            }
        }

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
    }
}
