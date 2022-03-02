public class Solution {
    public string RemoveOuterParentheses(string s) {
             StringBuilder S = new StringBuilder();
            Stack<char> st = new Stack<char>();
     
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i] == '(' )
                {
                    if (st.Count > 0)
                        S.Append(s[i]);
                    st.Push(s[i]);
                }
                else
                {
                    st.Pop();
                    if (st.Count > 0)
                       S.Append(s[i]);
                }
              }
            return S.ToString();  
    }
}