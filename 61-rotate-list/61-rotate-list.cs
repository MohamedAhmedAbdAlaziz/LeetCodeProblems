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
     
       
          ListNode p = head;
            int l = 0;
            while (p != null)
            {   p = p.next;
                l++;
            }
           k = k % l;
        if(k==0) return head;
        
            ListNode cur = head;
            for (int i = 0; i < l- k; i++)
            {
                cur = cur.next;
            }
            p = head;
            ListNode temp = cur;
            for (int i = 0; i< l-1; i++)
            {
                if (i >= k-1)
                {
                    temp.next = new ListNode(p.val, null);
                    temp = temp.next;
                    p = p.next;
                }
                else
                {
                    temp = temp.next;
                }
            }
 
            return cur;
    }
}