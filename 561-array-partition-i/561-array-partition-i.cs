public class Solution {
    public int ArrayPairSum(int[] nums) {
         Array.Sort(nums);
            int t = 0;
            for (int i = 1; i < nums.Length; i+=2)
            {
                t += Math.Min(nums[i], nums[i - 1]);
            }
            return t;
    }
}