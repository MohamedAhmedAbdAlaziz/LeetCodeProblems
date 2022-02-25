public class Solution {
    public int Reverse(int x) {
   
   if (x > 0)
            {
                int t = 0;

                while (x != 0)
                {
                    if (t * 10.0 > Int32.MaxValue)
                        return 0;
                    t = t * 10 + x % 10;
                    x /= 10;
                }
                return t;
            }
            else  
            {
            
                int t = 0;
                while (x != 0)
                {
                    int y =  (x % 10);
                    if (t * -10.0 < Int32.MinValue)
                        return 0;
                    t = t * 10 +(-1* y );
                   x/= 10;
                }
               return -1 * t;
            }
           
    }
}