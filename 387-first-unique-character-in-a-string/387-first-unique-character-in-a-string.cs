public class Solution {
    public int FirstUniqChar(string s) {
           Dictionary<char, int> dic = new Dictionary<Char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] =
                    dic[s[i]] + 1;
                }
                else
                {
                    dic[s[i]] = 1;
                }
            }

            foreach (var item in dic)
            {
                if (item.Value == 1) return s.IndexOf(item.Key);
            }
            return -1;
    }
}