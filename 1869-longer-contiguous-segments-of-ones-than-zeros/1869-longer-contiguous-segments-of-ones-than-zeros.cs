public class Solution {
    public bool CheckZeroOnes(string s) {
         int k = 0;
            int c = 0;
            int k1 = 0;
            int c1 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '1')
                {
                    k1++;
                    c = Math.Max(c, k);
                    k = 0;
                }
                else // if (nums[i] == 0)
                {
                    k++;
                    c1 = Math.Max(c1, k1);
                    k1 = 0;
                }

            }
            c = Math.Max(c, k);
            c1 = Math.Max(c1, k1);
            if (c1 <= c) return false;
            return true;
    }
}