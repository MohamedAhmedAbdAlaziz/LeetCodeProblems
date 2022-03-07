public class Solution {
    public int HammingWeight(uint n) {
         int t = 0;
            while (n > 0)
            {
                t++;
                n = n & (n - 1);
            }
            return t;  
    }
}