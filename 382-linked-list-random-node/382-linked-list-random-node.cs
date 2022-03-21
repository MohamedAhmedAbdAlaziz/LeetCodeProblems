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
     ListNode node = null;
      int size = 0;
       Random r ;  
    Dictionary<int, int> dic ;
    public Solution(ListNode head) {
       
   dic = new Dictionary<int, int>();

        while (head!= null)
            {
                dic[size++]= head.val;
                
                head = head.next;
            }
     r = new Random();
    }
    
    public int GetRandom() {
        
         if (size > 0) {
            int index = r.Next(0,size);
            int val = dic[index];
            return val;
        }
        return -1;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(head);
 * int param_1 = obj.GetRandom();
 */