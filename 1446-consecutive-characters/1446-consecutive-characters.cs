public class Solution {
    public int MaxPower(string s) {
         if (s.Length == 1) return 1;
            int k =1;
            int c = 1;
            for (int i = 0; i < s.Length-1; i++)
            {

                if (s[i] == s[i + 1])
                {
                    k++;
                    continue;
                }
                   
                    c = Math.Max(c, k);
                     k = 1;


            }
            c = Math.Max(c, k);
            return c;
    }
}