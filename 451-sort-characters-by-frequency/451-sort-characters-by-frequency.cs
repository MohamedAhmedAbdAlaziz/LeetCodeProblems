public class Solution {
    public string FrequencySort(string s) {
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
            var tt = dic.OrderByDescending(x => x.Value).ToList();
            string ss = "";
           foreach (var item in tt)
            {
                 
                    ss += new String(item.Key, item.Value );
                
            }
            return ss;
    }
}