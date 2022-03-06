public class Solution {
    public string MakeGood(string s) {
        
            Stack<string> stack = new Stack<string>();     
        for (int i = 0; i < s.Length; i++)
            {
                if(stack.Count()>0 &&
                    (stack.Peek().ToUpper() == stack.Peek() && stack.Peek().ToLower() == s[i].ToString() ||
                     (stack.Peek().ToLower() == stack.Peek() && stack.Peek().ToUpper() == s[i].ToString()))
                  )
                    
                {
                    stack.Pop();
                }
                else
                {
                  
                        stack.Push(s[i].ToString());
                    }
            }

            string t = "";

            while (stack.Count() > 0)
            {
                t = stack.Pop() + t;
            }
            return t;
    }
}