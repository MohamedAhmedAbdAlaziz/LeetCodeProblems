public class Solution {
    public bool IsIsomorphic(string s, string t) {
      if (s.Length != t.Length) return false;

            Dictionary<char, char> prevSum = new Dictionary<char, char>();

            for (int i = 0; i < s.Length; i++)
            {
                
                if (prevSum.ContainsKey(s[i]))
                {
                    StringBuilder b = new StringBuilder(s);

                    b[i] =prevSum[s[i]];
                    s = b.ToString();
                }
                else
                {
                    if (prevSum.ContainsValue(t[i]))
                    {
                        return false;
                    }
                        prevSum[s[i]] = t[i];
                        StringBuilder b = new StringBuilder(s);
                        b[i] = t[i];
                        s = b.ToString();
                  

                }
            }
            if (s == t) { return true; }

            return false;
     
    }
}