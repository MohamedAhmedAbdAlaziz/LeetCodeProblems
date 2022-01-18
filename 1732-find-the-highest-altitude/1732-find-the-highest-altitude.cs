public class Solution {
    public int LargestAltitude(int[] gain) {
     
            int k = 0;
           int max=0;
            for (int i = 0; i < gain.Length; i++)
            {
                k += gain[i];
               max= Math.Max(k,max);
            }
            return max;  
    }
}