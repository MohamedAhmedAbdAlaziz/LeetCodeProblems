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
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
           ListNode p = list1;
            ListNode p2 = list2;
            int index = 0;
            while (p!= null)
            {
              
                if(index== a-1)
                {
                   
                    while(p2 != null)
                    {
                        ListNode node = new ListNode(p2.val, null);
                        node.next = p.next;
                        p.next = node;
           

                        p2 = p2.next;
                        p = p.next;

                    }
                    while (index <= b - 1)
                    {
                        if(p.next != null)
                          p.next = p.next.next;
                         
                        index++;
                    }
                    break;
                } 
                 p = p.next;
                 index++;
            }

             
            return list1;
    }
}