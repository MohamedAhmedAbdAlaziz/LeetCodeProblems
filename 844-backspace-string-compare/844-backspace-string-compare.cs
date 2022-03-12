public class Solution {
    public bool BackspaceCompare(string s, string t)
    { 
      Stack<char> stack = new Stack<char>();
            Stack<char> stack2 = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {

              if(stack.Count() >0 && s[i]=='#')
                {
                    stack.Pop();
                }
                else if(s[i] != '#')
                {
                    stack.Push(s[i]);
                }
            }
            for (int i = 0; i < t.Length; i++)
            {

                if (stack2.Count() > 0 && t[i] == '#')
                {
                    stack2.Pop();
                }
                else if(t[i] != '#')
                {
                    stack2.Push(t[i]);
                }
            }
            string t4 = new String(stack.ToArray());
            string t42 = new String(stack2.ToArray());
    
            return t4 == t42;
        
    }
}