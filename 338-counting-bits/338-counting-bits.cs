public class Solution {
    public int[] CountBits(int n) {
         int[] newArray = new int[n + 1];
         for (int i = 0; i < newArray.Length; i++)
            {   int t = 0;
               int k=i;
                while (k> 0)
                {
                    t++;
                    k = k & (k - 1);
                }
              
                newArray[i] = t;
            }
            return newArray;
    }
}