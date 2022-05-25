public class Solution {
    public string MinRemoveToMakeValid(string s) {
              Stack<int> stack = new Stack<int>();
           
            for ( int i = 0; i < s.Length; i++)
            {
                if (stack.Count() > 0 && s[stack.Peek()] == '(' && s[i] == ')') 
                    stack.Pop();
             
                else if(s[i]== '(' || s[i] == ')')    stack.Push(i);
               
            }
            if (stack.Count() == 0) return s;
             
            while (stack.Count() != 0) 
                s = s.Remove(stack.Pop(), 1);
                  return s ;
    }
}