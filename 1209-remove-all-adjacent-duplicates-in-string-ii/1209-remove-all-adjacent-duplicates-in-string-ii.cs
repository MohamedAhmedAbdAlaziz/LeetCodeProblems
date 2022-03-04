public class Solution {
    public string RemoveDuplicates(string s, int k) {
        
          Stack<int[]> stack = new Stack<int[]>();
            
            
            for (int i = 0; i < s.Length; i++)
            {
                   
                

                if (stack.Count > 0 && stack.Peek()[0] == s[i] )
                {
                    stack.Peek()[1]++;   
                }
                else
                {
                    stack.Push(new[] {s[i],1});
                }

                if (stack.Peek()[1] == k)
                {
                    stack.Pop();
                }
 }

            string t = "";

            while (stack.Count() > 0)
            {
                int[] tr = stack.Pop();
               while(tr[1]-- >0)
                t =   (char)tr[0] +t ;
            }

            return t;
    }
}