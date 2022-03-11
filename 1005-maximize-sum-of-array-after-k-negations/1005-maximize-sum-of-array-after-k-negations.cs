public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
          Array.Sort(nums);
            
            int i = 0;
            int j = 0;
            while ( j < k)
            { 
            if (i >= nums.Length)  
              nums[nums.Length-1] = -1 * nums[nums.Length - 1];                
        
             else if (i > 0 && nums[i] > nums[i - 1])
                     nums[i - 1] = -1 * nums[i - 1];
                else
                {
                    nums[i] = -1 * nums[i];
                    i++;
                }
                j++;
             }

            return nums.Sum();
    }
}