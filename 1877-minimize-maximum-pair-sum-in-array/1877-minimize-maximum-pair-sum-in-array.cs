public class Solution {
    public int MinPairSum(int[] nums) {
            int num = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length/2; i++)
            {
                int t = nums[i] + nums[nums.Length - 1 - i];
                num = Math.Max(num, t);
            }
            return num;
    }
}