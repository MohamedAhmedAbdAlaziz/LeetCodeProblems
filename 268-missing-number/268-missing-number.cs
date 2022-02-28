public class Solution {
    public int MissingNumber(int[] nums) {
         int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            int n = nums.Length + 1;
            return  (n * (n - 1) / 2) - sum;
    }
}