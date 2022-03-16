public class Solution {
    public ListNode MiddleNode(ListNode head) {
     
           ListNode p =   head;
            int index = 0;
            while (p != null)
            { 
               p = p.next;
                index++;
            }
        
            index = index / 2;
            int i = 0;

           p =   head;
            while(i<index)
            {
                p = p.next;
                i++;
             }

            return p;
    }
}