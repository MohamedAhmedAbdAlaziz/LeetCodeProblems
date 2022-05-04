public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int t = Math.Max(word2.Length, word1.Length);
            string s = "";
            for (int i = 0; i < t; i++)
            {
                if (i < word1.Length) s += word1[i];
                if (i < word2.Length) s += word2[i];
            }
            return s; 
    }
}