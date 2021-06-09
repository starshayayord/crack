namespace Yord.Crack.Begin.LeetCode
{
    public class Task876
    {
     
        //вернуть среднюю ноду или вторую среднюю, если четное кол-во элементов
        public ListNode MiddleNode2(ListNode head) {
        
            if (head.next == null)
            {
                return head;
            }

            var midPoint = head;

            var needMove = true;
            //head двигаем всегда, а mid - каждый второй раз
            while (head != null)
            {
                needMove = !needMove;
                
                if (needMove)
                {
                    midPoint = midPoint.next;
                }

                head = head.next;
            }

            return midPoint;
        }
        
        public static ListNode MiddleNode(ListNode head)
        {
            var slow = head;
            var fast = head.next;
            while (fast != null)
            {
                slow = slow.next;
                fast = fast.next?.next;
            }

            return slow;
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
