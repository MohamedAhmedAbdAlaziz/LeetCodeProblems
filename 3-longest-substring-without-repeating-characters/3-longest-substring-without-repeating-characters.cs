public class Solution {
    public int LengthOfLongestSubstring(string s) {
var res = 0;
            var dict = new Dictionary<char, int>();
            var start = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                {
                    start = Math.Max(start, dict[s[i]] + 1);
                    dict[s[i]] = i;
                }
                else
                {
                    dict.Add(s[i], i);
                }

                res = Math.Max(res, i - start + 1);
            }

            return res;
    }
}