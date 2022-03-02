public class Solution {
    public int[] SumZero(int n) {
      
        int[] arry = new int[n];
             if (n == 1) return arry;
                arry[0]= -1;
                arry[1] = 1;
            
            for (int i = 2; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    arry[i] = 1* i;
                }
                else
                {
                    arry[i] = -1 * (i-1);
                }
             
            }
            if (n % 2 != 0)
            {
                arry[n - 1] = 0;
            }
            return arry;
    }
}