public class Solution {
    public int MaxDepth(string s) {
          int t = 0, r = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    t++;
                }
                else if (s[i] == ')')
                {
                    t--;
                }
                r = Math.Max(r, t);
            }
            return r;
    }
}