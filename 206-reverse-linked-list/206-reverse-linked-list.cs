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
    public ListNode ReverseList(ListNode head) {
        if (head == null ||
               head.next == null)
                return head;

            // Reverse the rest list and put 
            // the first element at the end
            ListNode rest = ReverseList(head.next);
            head.next.next = head;

            // Tricky step --
            // see the diagram
            head.next = null;

            // Fix the head pointer
            return rest;
    }
}