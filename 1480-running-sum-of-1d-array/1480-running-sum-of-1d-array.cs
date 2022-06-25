public class Solution {
    
    public int[] RunningSum(int[] nums) {
        
        int k =0;
        int[] numsb = new int[nums.Length];

        for (int i = 0; i <= nums.Length - 1; i++)
            {
            
            k+= nums[i];
            numsb[i]=k;
            
            }
        return numsb;

    }
}