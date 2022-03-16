 public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
    List<int> list = new List<int>();
            ListNode p = head;
            int index = 0;
            int k = 0;
            while (p != null )
            {
                if (p.val == val)
                {
                    list.Add(index - k);
                    k++;
                }
                p = p.next;
                index++;
            }
            for (int j = 0; j < list.Count; j++)
            {
                int i = 1;
                p = head;
                while (i < list[j] )
                {
                    p = p.next;
                    i++;
                }
                if (list[j] == 0)
                    head = head.next ;
               else if (p.next.next == null)
                    p.next = null;
                else
                    p.next = p.next.next;           
            }

            return head;
    }
}