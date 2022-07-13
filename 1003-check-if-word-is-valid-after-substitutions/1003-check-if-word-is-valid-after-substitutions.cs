public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
            stack.Push(s[0]);
            for (int i = 1; i < s.Length; i++)
            {
                if(stack.Count()>1)
                {
                    char r = stack.Pop();
                    char m = stack.Peek();
                    if ( String.Concat( s[i],r,m )== "cba")
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(r);
                        stack.Push(s[i]);
                    }
                }
                else
                {
                    stack.Push(s[i]);

                }
            }
            return stack.Count() == 0;
    }
}