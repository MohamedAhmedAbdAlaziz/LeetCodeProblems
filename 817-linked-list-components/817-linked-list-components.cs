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
    public int NumComponents(ListNode head, int[] nums) {
         Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic[nums[i]] = 1;
            }
            ListNode p = head;
          int j = 0;
            int k = 0;
            while (p!= null)
            {
                if (dic.ContainsKey(p.val))
                {
                    j++;
                   dic.Remove(p.val);
                }
                else
                {
                 if(j> 0) k+=1;
                    j =0;
                    
                }
                p = p.next;
            }
           if(j> 0) k+=1;

            return k;
    }
}