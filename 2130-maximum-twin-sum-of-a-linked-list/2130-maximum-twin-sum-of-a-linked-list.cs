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
    public int PairSum(ListNode head) {
         ListNode p = head;
            ListNode p2 = head;
            Stack<int> stack = new Stack<int>();
            int t = 0;
            while (p != null)
            {

                if(p2== null)
                {
                    t = Math.Max(t, p.val + stack.Pop());
                }
                else
                {
                    stack.Push(p.val);

                }

                p = p.next;
              if(p2 != null)
                p2 = p2.next.next;
            }

            return t;
    }
}