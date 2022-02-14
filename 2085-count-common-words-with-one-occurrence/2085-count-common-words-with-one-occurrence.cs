public class Solution {
    public int CountWords(string[] words1, string[] words2) {
     Dictionary<string, int> prevSum = new Dictionary<string, int>();
            
            for (int i = 0; i < words1.Length; i++)
            {

                if (prevSum.ContainsKey(words1[i]))
                {

                    prevSum[words1[i]] = prevSum[words1[i]] + 1;
                }
                else
                {
                    prevSum[words1[i]] = 1;

                }
            }
             for (int i = 0; i < words2.Length; i++)
            {

                if (prevSum.ContainsKey(words2[i]))
                {
                    if (prevSum[words2[i]] == 1) 
                    prevSum[words2[i]] =-1 * prevSum[words2[i]];
                    else if (prevSum[words2[i]] < 1)
                     prevSum[words2[i]] = -2 * prevSum[words2[i]];
              }
                
            }
            int tr = 0;
            int t = Math.Max(words1.Length, words2.Length);
            foreach (var item in prevSum)
            {
                if (item.Value ==-1)
                {
                    tr++;
                }
            }
            return tr;   
    }
}