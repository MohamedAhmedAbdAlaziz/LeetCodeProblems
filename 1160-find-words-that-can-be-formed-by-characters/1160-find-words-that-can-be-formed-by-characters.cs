public class Solution {
    public int CountCharacters(string[] words, string chars) {
                Dictionary<char, int> prevSum = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (prevSum.ContainsKey(chars[i]))
                {
                    prevSum[chars[i]] = 1 + prevSum[chars[i]];
                }
                else
                {
                    prevSum[chars[i]] = 1;
                }
            }
            int num = 0;

            for (int i = 0; i < words.Length; i++)
            {
                int j = 0;
                Dictionary<char, int> prevSu = new (prevSum);
                 for (j = 0; j < words[i].Length; j++)
                {
                    if (prevSu.ContainsKey(words[i][j]) && prevSu[words[i][j]]>0)
                    {
                        prevSu[words[i][j]] = prevSu[words[i][j]] - 1;
                      //  break;
                    }
                    else
                    {
                        break;
                    }
               }
                if (j == words[i].Length)
                {
                    num+= words[i].Length;
                }
            }
            return num;
    }
}