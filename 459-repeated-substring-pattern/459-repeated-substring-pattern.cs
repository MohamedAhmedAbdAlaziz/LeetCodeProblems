public class Solution {
    public bool RepeatedSubstringPattern(string s) {
         for (int i = 1; i <= s.Length/2; i++)
            {
          
                string t = s.Substring(0,i);
               
                int j = 0;
                while (j+i<= s.Length && s.Substring(j,i) == s.Substring(0,i))
                {
                    j+=i;
                }
                 
                if (j== s.Length) return true;
                
            }

            return false;
    }
}