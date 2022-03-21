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
    public ListNode SwapPairs(ListNode head) {
           ListNode d = new ListNode(0, head);
             ListNode pre = d;
            ListNode curr = head;
            while(curr != null && curr.next != null)
            {
                ListNode nxtpair = curr.next.next;
                ListNode seconnd = curr.next;
                seconnd.next = curr;
                curr.next = nxtpair;
                pre.next = seconnd;
                 pre = curr;
                curr = nxtpair;

            }
            return d.next;   
    }
}