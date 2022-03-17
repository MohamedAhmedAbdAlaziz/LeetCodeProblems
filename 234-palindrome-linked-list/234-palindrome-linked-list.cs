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
    public bool IsPalindrome(ListNode head) {
      ListNode fast = head;
            ListNode slow = head;
            while(fast !=null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            ListNode prev = null;
            while(slow!= null)
            {
                ListNode temp = slow.next;
                slow.next = prev;
                prev = slow;
                slow = temp;
            }
            ListNode left = head;
            ListNode right = prev;

            while(right != null)
            {
                if(left.val != right.val)
                   return false;
                
                left = left.next;
                right = right.next;
            }

            return true;
    }
}