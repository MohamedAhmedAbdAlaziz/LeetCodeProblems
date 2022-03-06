public class Solution {
    public bool IsValid(string s) {
      Stack<int> stack = new Stack<int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count() > 0 && 
                    (stack.Peek()== s[i]-2 ||
                    stack.Peek() == s[i] - 1
                    ) )
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(s[i]);

                }

            }
            if (stack.Count() == 0)
            {
                return true;
            }
            return false;
    }
}