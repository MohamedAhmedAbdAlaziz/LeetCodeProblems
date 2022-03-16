public class Solution {
    public ListNode DeleteMiddle(ListNode head) {
           ListNode p = head;
          int index = 0;
            while (p != null)
            {  p = p.next;
                index++;
            }
          if(index==1) return null;
            index = index / 2;
           index = index + 1;
            int i = 1;
           p = head;
            while (i < index-1)
            {
                p = p.next;
                i++;
            }
            p.next = p.next.next;

            return head;
    }
}