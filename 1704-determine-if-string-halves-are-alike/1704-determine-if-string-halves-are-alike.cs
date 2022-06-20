public class Solution {
    public bool HalvesAreAlike(string s) {
       int ss = s.Length / 2, t=0, t2=0;
            string s1 = s.Substring(0, ss);
            string s2 = s.Substring(ss);
            string vowels = "aeiouAEIOU";
            for (int i = 0; i < s1.Length; i++)
            {
              if(  vowels.Contains(s1[i]))
                t++;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if(vowels.Contains(s2[i]))
                  t2++;
            }
            return t==t2;
    }
}