public class Solution {
    public int MinSwaps(string s) {
       Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count() > 0 && s[stack.Peek()] == '[' && s[i] == ']')
                    stack.Pop();
                 else   stack.Push(i);
               }
             if (stack.Count() == 0) return 0; 
               if (stack.Count() == 2) return 1; 
              if (stack.Count() % 4 == 0) return stack.Count() / 4;
            
                 return(stack.Count()+2) / 4; 
             
    }
}