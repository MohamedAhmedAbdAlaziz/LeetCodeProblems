public class Solution {
    public bool IsPowerOfTwo(int n) {
             int t = 0;
            while (n > 0)
            {
                t++;
                n = n & (n - 1);
            }
            return t==1;
        
    }  
    
}