public class Solution {
    public int MySqrt(int x) {
         double t = 1;
            for (double i = 0; (i*i)<= x; i++)
            {
                t = i * 1.0;
            }
            return Convert.ToInt32( t);
    }
}