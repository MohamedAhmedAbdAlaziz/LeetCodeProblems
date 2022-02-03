public class Solution {
    public int SubtractProductAndSum(int n) {
          int t = 1, s = 0;
            while (n>0)
            {
                int i = n % 10;
               
                    t *= i;
                     s += i;
                
                n = n / 10;
            }
            return t - s;
    }
}