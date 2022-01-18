public class Solution {
    public int RepeatedNTimes(int[] nums) {
         int n = nums.Length / 2;
            int[] hash = new int[10001];
            for (int i = 0; i < nums.Length; i++)
            {
                hash[nums[i]]++;
            }
            int m = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash[nums[i]] == n)
                {
                    m = nums[i];
                    break;
                }
            }
            return m;
    }
}