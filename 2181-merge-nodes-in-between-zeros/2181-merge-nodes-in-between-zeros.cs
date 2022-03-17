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
    public ListNode MergeNodes(ListNode head) {
           ListNode p = head.next;
            ListNode p2 = new ListNode(0,null);
            ListNode p3 = p2 ;
            
            
            while (p != null)
            {  p3.val += p.val;

                if (p.val == 0 && p.next != null)
                {
                    p3.next= new(0,null);
                    p3 = p3.next;
                }
                p = p.next;
            }
           
            return p2;
    }
}