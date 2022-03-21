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
    public int[] NextLargerNodes(ListNode head) {
        Stack<int[]> stack = new Stack<int[]>();
            int i = 0;
            List<int[]> list = new List<int[]>();
            ListNode p = head;
            while(p!= null)
            {

                while(stack.Count > 0 && p.val > stack.Peek()[0])
                {
                  
                    list.Add(new int[] { p.val, stack.Pop()[1] });
                }
                stack.Push(new int []{ p.val, i });
                p = p.next;
                i++;
            }
            int[] arr = new int[i];


            for (int j = 0; j < list.Count; j++)
            {
                int t = list[j][1];
                arr[t] = list[j][0];
            }
            while ( stack.Count>0)
            {

                int t = stack.Pop()[1];
                arr[t] =0;
                
            }
            return arr;
    }
}