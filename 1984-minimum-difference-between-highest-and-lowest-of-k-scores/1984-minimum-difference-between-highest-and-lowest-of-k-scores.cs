public class Solution {
    public int MinimumDifference(int[] nums, int k) {
             Array.Sort(nums);
              //Array.Reverse(nums);
            if (k == 1) return 0;
 
            int sum = nums[k-1] - nums[0];
          
            for (int i = k-1; i < nums.Length; i++)
            {
              sum = Math.Min(sum, nums[i]- nums[i-(k-1)]);
            }
            return sum;
    }
}