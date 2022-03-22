public class Solution {
    public int MostWordsFound(string[] sentences) {
        
            int max = 0;
            for (int i = 0; i < sentences.Length; i++)
            {
                 int t = sentences[i].Split(" ").Length;
                max = Math.Max(max, t);
            }
            return max;
    }
}