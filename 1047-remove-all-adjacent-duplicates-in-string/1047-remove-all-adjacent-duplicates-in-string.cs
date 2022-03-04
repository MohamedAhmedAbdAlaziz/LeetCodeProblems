public class Solution {
    public string RemoveDuplicates(string s) {
        Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
               if (stack.Count > 0 && stack.Peek() == s[i])
                   stack.Pop();
                else
                 stack.Push(s[i]);   
                  }
            string t = "";
              while (stack.Count()>0)
            {
                t = stack.Pop() + t;
            }
            return t;
    }
}