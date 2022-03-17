/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
           ListNode first = headA;
            ListNode second = headB;

            while (first != second)
            {
                if (first != null)
                {
                    first = first.next;
                }
                else
                {
                    first = headB;
                }

                if (second != null)
                {
                    second = second.next;
                }
                else
                {
                    second = headA;
                }

            }

            return first;
    }
}