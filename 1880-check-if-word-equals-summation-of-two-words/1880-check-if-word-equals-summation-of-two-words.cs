public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        
            string k = "abcdefghijklmnopqrstuvwxyz";
            int t = 0, m = 0, r = 0;
            int i = 0;
            while (i < firstWord.Length || i < secondWord.Length || i < targetWord.Length)
            {
                if (i < firstWord.Length)
                {
                    t = t * 10 + k.IndexOf(firstWord[i]);

                }
                if (i < secondWord.Length)
                {
                    m = m * 10 + k.IndexOf(secondWord[i]);


                }
                if (i < targetWord.Length)
                {
                    r = r * 10 + k.IndexOf(targetWord[i]);

                }
                i++;

            }


            if (t + m == r)
            {
                return true;
            }
            return false;
    }
}