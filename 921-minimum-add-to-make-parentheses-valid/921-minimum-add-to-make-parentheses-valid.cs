public class Solution {
    public int MinAddToMakeValid(string s) {
         Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {  if (stack.Count() > 0 && stack.Peek() == '(' && s[i] == ')')    stack.Pop();
                 else  stack.Push(s[i]);
                }

            return stack.Count();
    }
}