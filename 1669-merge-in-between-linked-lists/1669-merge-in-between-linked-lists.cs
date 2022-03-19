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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
          ListNode p = list1;
            ListNode p2 = list2;
            ListNode p3 = new ListNode(0, p);
            ListNode p4 = p3;
           int index = 0;
            while (p!= null)
            {
              
                if(index== a)
                {
                   
                    while(p2 != null)
                    {
                        p4.next =new ListNode(p2.val,null);
                        p4 = p4.next;
                        p2 = p2.next;
                    }
                    break;
              }

                p = p.next;
                p4 = p4.next;
                index++;

            }

            while(p!= null)
            {
               if (index == b)
               {
                    if (p.next != null)
                        p4.next = p.next;
                    break;
               }
              
                p = p.next;
              index++;

            }


            return p3.next;
    }
}