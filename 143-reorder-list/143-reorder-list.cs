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
    public void ReorderList(ListNode head) {
        ListNode slow = head;
            ListNode fast = head.next;
            
            while (fast!= null && fast.next != null)
            {

                slow = slow.next;
                fast = fast.next.next;
            }


        
           ListNode second = slow.next;
           ListNode prev =  null;
           slow.next =  null;
            while (second!= null)
            {
                ListNode temp =second.next;
                second.next = prev;
                prev = second;
                second = temp;

            }

            ListNode first = head;
             second= prev;

            while(second != null)
            {
                ListNode temp1 = first.next ;
                ListNode temp2= second.next;

                first.next = second;
                second.next = temp1;
                first = temp1;
                second = temp2;
            }
            }
     
}