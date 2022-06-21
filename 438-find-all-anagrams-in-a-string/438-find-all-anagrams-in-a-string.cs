public class Solution {
    public IList<int> FindAnagrams(string s, string p) {
                      int[] arr1 = new int[26];

            for (int j = 0; j < p.Length; j++)
            {
                arr1[p[j] - 'a']++;
            }
         string s11=     string.Join("", arr1);
            List<int> list = new List<int>();
            for (int i = 0; i < s.Length-p.Length+1; i++)
            {
                string s1 = s.Substring(i, p.Length);
                int[] arr = new int[26];
                for (int j = 0; j < p.Length; j++)
                {
                    arr[s1[j] - 'a']++;
                }
                string ss = string.Join("", arr);
                if (ss == s11) list.Add(i);

            }
            return list;
    }
}