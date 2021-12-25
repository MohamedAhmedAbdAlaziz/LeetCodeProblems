public class Solution {
    public int BalancedStringSplit(string s) {
    int coR = 0;
       int coL = 0;
        int k = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                coL = 0;
                coR = 0;
                int ss = 0;
                for (int j = i; j < s.Length; j++)
                {

                    if (s[j] == 'R')
                    {

                        coR++;
                        ss++;
                    } 
                    else
                    {
                        coL++;
                        ss++;

                    }
                    if (coR == coL && ss >= 2)
                    {
                        k++;
                        i = j ;
                        break;
                    }
                }
                
            }
            return k;
        }
    }
