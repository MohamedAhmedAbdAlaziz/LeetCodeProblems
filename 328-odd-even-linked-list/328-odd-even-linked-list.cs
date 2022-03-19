public class Solution {
    public ListNode OddEvenList(ListNode head) {
         if(head==null) return null;     
        if(head.next==null) return head;    
        if(head.next.next==null) return head;


        ListNode p = head.next;
            ListNode p2 = head.next.next;
            int t = 0;
            while (p2!=null  )
            {
                int temp = p.val;
                p.val = p2.val;
                 p2.val = temp;
                ListNode k = p.next;
                if (t >= 1)
                {
                    int temp3 = k.val;
                    for (int i = 0; i < t; i++)
                    {
                          int temp32 = k.next.val;
                          k.next.val =temp3;
                          temp3 = temp32;
                           k = k.next;
                     }
                    p.next.val = temp3;
                }
                p = p.next;
                if (p2.next == null)
                    p2 = p2.next;
                else
                p2 = p2.next.next;
                t++;
            }
 

            return head;
    }
}