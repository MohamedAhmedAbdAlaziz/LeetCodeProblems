public class Solution {
    public bool CloseStrings(string word1, string word2) {
           var dic = new Dictionary<char, int>();
            var dic2 = new Dictionary<char, int>();

            for (int i = 0; i < word1.Length; i++)
            { if (dic.ContainsKey(word1[i]))
                {
                    dic[word1[i]] += 1;
                }
                else
                {
                    dic[word1[i]] = 1;
                }
            }
            for (int i = 0; i < word2.Length; i++)
            {
                   if (dic2.ContainsKey(word2[i]))
                {
                    dic2[word2[i]] += 1;
                }
                else if (dic.ContainsKey(word2[i]))
  {
                    dic2[word2[i]] = 1;
                }
                else
                {
                    return false;
                }
            }

            var tt = dic.OrderBy(x => x.Value).Select(x=>x.Value).ToList();
            var tt2 = dic2.OrderBy(x => x.Value).Select(x=>x.Value).ToList();
              if (dic.Count() != dic2.Count()) return false;

            for (int i = 0; i < tt.Count(); i++)
            {
                if (tt[i]!= tt2[i]) return false;
            }
            return true;
    }
}