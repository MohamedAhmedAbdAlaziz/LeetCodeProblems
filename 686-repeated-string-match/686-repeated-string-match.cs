public class Solution {
    public int RepeatedStringMatch(string a, string b) {
           if (a.IndexOf(b[0]) == -1)
            {
                return -1;
            } 
        int t = 1;
            string s = new string(a);

            while (s.Length< b.Length)
            {
                s += a;
                t++;
            }
            int u=0;
            char bs = b[0];
        
            int n = (int)Math.Ceiling((double)b.Length / (double)a.Length);
            int tn = n - 1;
        
            while (tn<= n)
            {
               
                for (int i = s.IndexOf(b[0]) ; i <= s.Length-b.Length; i++)
                {

                    if (s[i] == bs && (s.Length-i+1>=b.Length))
                    {
                       if( s.Substring(i, b.Length)==b)
                        {
                            return t;
                        }
                    }
                }
                s += a;
                t++;
                tn++;
            }
            return -1;
    }
}