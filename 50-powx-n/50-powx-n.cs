public class Solution {
    public double MyPow(double x, int n) {
            int t = n;
            double result = 1;
            while (n!= 0)
            {
                if (n % 2 != 0)
                {
                    result= result * x;
                }
                x= x*x;
                n=n / 2;
            }
            if (t < 1)
            {
                return 1 / result;
            }
            return result;

      
    }
 
}