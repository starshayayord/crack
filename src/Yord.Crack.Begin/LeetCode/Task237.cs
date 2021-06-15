namespace Yord.Crack.Begin.LeetCode
{
    //удалить полученную ноду из связного списка (она не хвостовая)
    public class Task237
    {
        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int x)
            {
                val = x;
            }
        }

        //скопировать значение следующей в текущуи и уничтожить следующую
        public static void DeleteNode(ListNode node)
        {

            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
