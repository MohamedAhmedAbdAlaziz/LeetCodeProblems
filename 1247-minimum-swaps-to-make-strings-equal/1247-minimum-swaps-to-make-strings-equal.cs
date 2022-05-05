public class Solution {
    public int MinimumSwap(string s1, string s2) {
         int xy = 0, yx = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == 'x' && s2[i] == 'y')
                    xy += 1;
                else if (s1[i] == 'y' && s2[i] == 'x')
                    yx += 1;
            }
            if ((xy + yx) % 2 == 1) return -1;

            return (int)(xy / 2) + (int)(yx / 2) + xy % 2 + yx % 2;
    }
}