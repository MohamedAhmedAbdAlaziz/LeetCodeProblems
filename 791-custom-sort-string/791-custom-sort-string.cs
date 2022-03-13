public class Solution {
    public string CustomSortString(string order, string s) {
        Dictionary<char, int> dic = new Dictionary<char, int>();
            string st="";
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

            for (int i = 0; i < order.Length; i++)
            {
                if (dic.ContainsKey(order[i]))
                {
                    while (dic[order[i]] > 0)
                    {
                        st += order[i];
                        dic[order[i]] -= 1;
                    }
                }
                
            }
            var dic2 = dic.Where(x => x.Value > 0);
            foreach (var item in dic2)
            {
                int yy = item.Value;
                while (yy> 0)
                {
                    st += item.Key;
                    yy--;
                }
            }
            return st;
    }
}