public class Solution {
     static String[] codes = {".;","" ,
            "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"
                          };
    public List<string> LetterCombinations(string s) {
       
       
            if (s.Length == 0)
            {
                List<string> base1 = new List<string>();
                return base1;

            }
            string ch = s[0].ToString();
            string km = codes[Convert.ToInt32(ch)];
            string ros = s.Substring(1);
            List<string> t = LetterCombinations(ros);
            List<string> list = new List<string>();
            if (t.Count == 0)
            {
                for (int i = 0; i < km.Length; i++)
                {
                    list.Add("" + km[i]);
                }
            }
            else
            {
                for (int i = 0; i < km.Length; i++)
                {
                    for (int j = 0; j < t.Count; j++)
                    {
                        list.Add(km[i] + t[j]);
                    }
                }
            }
            return list;
        }
    
}