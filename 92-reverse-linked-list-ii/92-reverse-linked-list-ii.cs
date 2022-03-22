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
    public ListNode ReverseBetween(ListNode head, int left, int right) {
      
              ListNode p = head;
            ListNode dummy =new(0, head);
            ListNode leftpre = dummy;

            for (int i = 0; i < left-1; i++)
            {
                leftpre = p;
                p = p.next;
            }
            ListNode pre = null;

            for (int i = 0; i < right-left+1; i++)
            {
                ListNode temp = p.next;
                p.next = pre;
                pre = p;
                p = temp;
            }

            leftpre.next.next = p;
            leftpre.next = pre;

            return dummy.next;
    }
}