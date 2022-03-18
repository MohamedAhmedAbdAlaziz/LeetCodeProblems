/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
              ListNode p = l1;
            ListNode p2 = l2;
            ListNode p3 = new ListNode(0, null);
            ListNode p4 = p3;

           
            int rest = 0;
            while(p!= null || p2 != null)
            {
                int t1 = 0;
                int t2 = 0;
                          if (p != null)
                          t1 = p.val;
                          if (p2 != null)
                           t2 = p2.val;

                    int result = t1 + t2+rest;
                    if (result / 10 == 1)
                    {
                        p4.next = new ListNode(result % 10, null);
                        p4 = p4.next;
                        rest = result / 10;
                    }
                    else
                    {
                        p4.next = new ListNode(result  , null);
                        p4 = p4.next;
                        rest = 0;
                    }

                
                if(p!=null)
                p = p.next;
                if (p2 != null)
                       p2 = p2.next;

            }
        
                if (rest > 0)
               {
                       p4.next = new ListNode(rest, null);
                       // p4 = p4.next;
                 // p4.val += rest;
             
              }
            return p3.next;
    }
}