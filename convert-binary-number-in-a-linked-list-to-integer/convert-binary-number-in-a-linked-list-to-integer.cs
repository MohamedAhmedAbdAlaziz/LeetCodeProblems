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
    public int GetDecimalValue(ListNode head) {
        ListNode p = head;
            string s = "";
            while (p !=null)
            {
               s +=p.val;
                p = p.next;
              
            }

            int b = Convert.ToInt32(s, 2);

            return b;
    }
}