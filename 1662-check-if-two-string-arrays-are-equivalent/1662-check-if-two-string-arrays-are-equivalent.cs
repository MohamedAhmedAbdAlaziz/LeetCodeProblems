public class Solution {
    public bool ArrayStringsAreEqual(string[] word1, string[] word2) {
         string s1 = "";
            string s2 = "";
             for (int i = 0; i <  Math.Max(word2.Length, word1.Length); i++)
            {
              if(i< word1.Length) s1 += word1[i];
              if(i< word2.Length)s2 += word2[i];
            }

            return s2 == s1;
    }
}