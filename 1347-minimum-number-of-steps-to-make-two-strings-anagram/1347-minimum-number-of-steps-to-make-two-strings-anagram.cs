public class Solution {
    public int MinSteps(string s, string t) {
        var dic = new Dictionary<char, int>();
         var dic2 = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {

                if (dic.ContainsKey(s[i]))
                {
                    dic[s[i]] += 1;
                }
                else
                {
                    dic[s[i]] = 1;


                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (dic2.ContainsKey(t[i]))
                {
                    dic2[t[i]] += 1;
                }
                else
                {
                    dic2[t[i]] = 1;
                 }
            }
            dic = dic.OrderBy(x => x.Value).ToDictionary(x=>x.Key, y=>y.Value);
            dic2 = dic2.OrderBy(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            int tt = 0;
            foreach (var item in dic2)
            {
                char ty = item.Key;
                if (dic.ContainsKey(ty) && dic[ty] != dic2[ty])
                {
                    if (dic[ty] < dic2[ty])
                    {
                        tt += Math.Abs(dic[ty] - dic2[ty]);
                    }
                }
                else if (!dic.ContainsKey(ty))
                {
                    tt += dic2[ty];
                }
            }
               

            
            return tt;
    }
}