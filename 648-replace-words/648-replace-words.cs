public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) {
         string[] s = sentence.Split(" ");
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int t = 1000;
            int t2 = 0;
            for (int  j = 0;  j < dictionary.Count;  j++)
            {
                t = Math.Min(t, dictionary[j].Length);
                t2 = Math.Max(t, dictionary[j].Length);
                dic[dictionary[j]] = dictionary[j].Length;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (t >= s[i].Length)
                    continue;
                int k = t;
                while (k < s[i].Length && k<= t2) { 
                string ss = s[i].Substring(0, k);
                   
                        if (dic.ContainsKey(ss))
                        {
                        s[i] = ss;
                        break;
                        }
                    k++;
                }
                
            }
           
            return String.Join(' ', s); 
    }
}