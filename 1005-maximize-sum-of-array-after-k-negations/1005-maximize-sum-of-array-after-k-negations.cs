public class Solution {
    public int LargestSumAfterKNegations(int[] nums, int k) {
           for (int i = 0; i < k; i++)
            {
                Array.Sort(nums);
                   nums[0] = -1 * nums[0];

                

            }

            return nums.Sum();
    }
}