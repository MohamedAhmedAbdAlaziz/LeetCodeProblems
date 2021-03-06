public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var Dic = new Dictionary<string, List<string>>();

            foreach (var s in strs)
            {
                char[] charArray = s.ToCharArray();
                Array.Sort(charArray);
                string s2 = new string(charArray);
                

                if (Dic.ContainsKey(s2))    Dic[s2].Add(s);
                
                else 
                    Dic[s2] = new List<string>()
                    {
                        s
                    };
                
            }
    List<IList<string>> n = new List<IList<string>>();
            foreach (var item in Dic)
            {
                n.Add(item.Value);
            }
            return n;

    }
}