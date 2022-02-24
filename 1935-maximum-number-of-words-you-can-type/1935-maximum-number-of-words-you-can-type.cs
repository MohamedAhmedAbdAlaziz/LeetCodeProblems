public class Solution {
    public int CanBeTypedWords(string text, string brokenLetters) {
         int num = 0;
            string[] t = text.Split(" ");
             ;
            for (int i = 0; i < t.Length; i++)
            {
                int j=0;
                 for ( j = 0; j < brokenLetters.Length; j++)
                {
                    if (t[i].Contains(brokenLetters[j]))
                    {
                        break;
                    }
                    
                }
                if(j == brokenLetters.Length  )
                {
                    num++;
                }
            }
            return num;

    }
}