public class Solution {
    public int MaxRepeating(string sequence, string word) {
      if (word.Length > sequence.Length) return 0;
            if (word.Length == sequence.Length && word == sequence) return 1;
            int t = word[0];
            int y = 0;
            int mm = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if ((sequence.Length - i) < word.Length )   return mm;
                 
                string s = sequence.Substring(i, word.Length);
                string kword = new string(word);
                int ki = 2;
                y = 0;
                while(s == kword)
                {
                    
                    y++;
                    if((sequence.Length-i)<word.Length *ki)
                    {
                        mm = Math.Max(y, mm);
                        return mm;
                    }
                     
                        s = sequence.Substring(i, word.Length * ki);

                  
                    kword = kword + word;
                    ki++;
                      //  i+=word.Length-1;

                }
                mm = Math.Max(y, mm);
                 
            }
            return mm;
    }
}