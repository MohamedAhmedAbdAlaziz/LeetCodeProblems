public class Solution {
    public int LongestPalindrome(string[] words) {
           var dic = new Dictionary<string, int>();
            int t = 0;
            int t2 = 0;
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray =words[i].ToCharArray();
                Array.Reverse(charArray);
                string tt= new string(charArray);
               
                if (dic.ContainsKey(tt))
                {

                    t += 4;
                    if(dic[tt]==1)
                    dic.Remove(tt);
                    else
                        dic[tt] -= 1;

                }
                else if (dic.ContainsKey(words[i]))
                {
                    
                        dic[words[i]] += 1;

                }
                 else
                {
                    dic[words[i]] = 1;
                }
            }

            var ttt = dic.Where(x => x.Key[0] == x.Key[1]).Select(x=>x.Value).ToList();
            if (ttt.Count != 0) t+=2;
            return t;

    }
}