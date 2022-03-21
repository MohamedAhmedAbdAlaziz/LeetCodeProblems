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
        Stack<int> stack = new Stack<int>();
            ListNode p = head;
            ListNode p2 = new ListNode(0, null);
           ListNode p3 = p2;
            int t = 0;
            while (p!= null)
            {

                stack.Push(p.val);
                t++;
                p = p.next;
            }
            p = head;
                    int j = t % 2;

            t = t / 2;
            int i = 0;
            while(i<t)
            {
                ListNode k = new ListNode(stack.Pop(),null);

                
                k.next = p.next;
                p.next = k;
                i++;
            if (i == t  && j==0)
                    p.next.next = null;
                if (i == t && j == 1)
                    p.next.next = new ListNode(stack.Pop(), null);
                else p = p.next.next;
            }

       
    }
}