public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
           int k = 1, m=1 ;
        
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] < nums[i + 1]) k++;
                else
                {
                    m = Math.Max(k, m);
                    k = 1;
                }
            }
    m = Math.Max(k, m);
            return m;
    }
}