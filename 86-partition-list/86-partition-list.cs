public class Solution {
    public ListNode Partition(ListNode head, int x) {
                 if(head== null)  return head; 
                if(head.next== null)  return head;   

        ListNode p =head;
            ListNode left =new(0, null);
            ListNode te =  left;
            ListNode right = new(0, null);
            ListNode te2 = right;
             
            while (p!= null)
            {
                ListNode temp=null;
                if (p.val < x) {
                      temp = p.next;
                       
                        p.next = null;
                        te.next = p;
                        te = te.next;
                     }
                else
                {
                      temp = p.next;
                    p.next = null;
                    te2.next = p;
                    te2 = te2.next;
                  
                }
                  p = temp;

            }
          left = left.next;
            right = right.next;

            if (left == null)
            {
                return right;
            }
            te.next = right;
            te = te.next;
           
        
            return left;

    }
}