public class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        
        
            int t = 0, m = 0, r = 0;
            int i = 0;
            while (i < firstWord.Length || i < secondWord.Length || i < targetWord.Length)
            {
                if (i < firstWord.Length)
                {
                    t = t * 10 + (firstWord[i] -97);

                }
                if (i < secondWord.Length)
                {
                    m = m * 10 + (secondWord[i] -97);


                }
                if (i < targetWord.Length)
                {
                    r = r * 10 +(targetWord[i] -97);

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