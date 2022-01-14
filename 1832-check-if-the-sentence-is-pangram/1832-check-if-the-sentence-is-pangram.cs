public class Solution {
    public bool CheckIfPangram(string sentence) {
         int[] alphabet = new int[26];
            string t = "abcdefghijklmnopqrstuvwxyz";
           
           int[] g = new int[26];
            for (int i = 0; i < sentence.Length; i++)
            {
               int tg= t.IndexOf(sentence[i]);
                g[tg]++;
                
            }

            for (int i = 0; i < g.Length; i++)
            {
                if (g[i] < 1)
                {
                    return false;
                }
            }

            return true;
    }
}