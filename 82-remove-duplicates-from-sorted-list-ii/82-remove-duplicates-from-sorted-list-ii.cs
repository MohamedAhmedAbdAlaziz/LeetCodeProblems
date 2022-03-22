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
    public ListNode DeleteDuplicates(ListNode head) {
       ListNode p2 =new(0, head);
            ListNode p = p2;
            int t = 0;
            while (p != null)
            {      t = 0;
                  if (p.next==null||p.next.next == null) break;

                    while(p.next.val == p.next.next.val)
                    {
                        p.next = p.next.next;
                  if (p.next==null||p.next.next == null){
                       p.next = p.next.next;
                      break;
                         } 
                      if(p.next.val != p.next.next.val)
                    {
                        ListNode temp = p.next.next;
                        p.next = temp;
                        t = 1;
                        break;
                    }
                    }
                    if(t==0)
                      p = p.next;
                
            }
            return p2.next;
    }
}