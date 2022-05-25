public class Solution {
    public long SubArrayRanges(int[] nums) {
          long result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int min = nums[i];
                int max = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    max = Math.Max(max, nums[j]);
                    min = Math.Min(min, nums[j]);
                    result += max - min;
                }

            }
            return result;
    }
}