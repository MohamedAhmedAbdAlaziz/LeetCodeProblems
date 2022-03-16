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
    public ListNode MiddleNode(ListNode head) {
     
           ListNode p =new ListNode(0,head);
            int index = 0;
            while (p != null)
            { 
               p = p.next;
                index++;
            }
            index = index - 1;
            index = index / 2;
            int i = 0;

            ListNode p2 = head;
            while(i<index)
            {
                p2 = p2.next;
                i++;
             }

            return p2;
    }
}