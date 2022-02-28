public class Solution {
    public char FindTheDifference(string s, string t) {
        if(t.Length==1)return t[0];
        Dictionary<char, int> prevSu = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!prevSu.ContainsKey(s[i]))
                {
                    prevSu[s[i]] = 1;

                }
                else
                {
                    prevSu[s[i]] = prevSu[s[i]] + 1;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (!prevSu.ContainsKey(t[i]))
                {
                   return t[i];

                }
                else
                {
                    prevSu[t[i]] = prevSu[t[i]] + 1;
                }
                
            }

            foreach (var item in prevSu)
            {
               if(item.Value%2 != 0)
                {
                    return item.Key;
                }
            }

            return '1';
    }
}