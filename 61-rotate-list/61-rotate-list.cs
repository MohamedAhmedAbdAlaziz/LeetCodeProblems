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
    public ListNode RotateRight(ListNode head, int k) {
        if(head==null)return null; 
       
          ListNode p = head.next;
            int l = 1;
            while (p != null)
            {
                 
                p = p.next;
                l++;
            }

            k = k % l;  
        
        for (int i = 0; i < k; i++)
            {
                  p = head.next;
                int h = head.val;
                while (p != null)
                {
                    int temp = p.val;
                    p.val = h;
                    h = temp;

                    p = p.next;
                }
                head.val = h;
            }

            return head;
    }
}