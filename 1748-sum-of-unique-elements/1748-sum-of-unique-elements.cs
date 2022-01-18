public class Solution {
    public int SumOfUnique(int[] nums) {
         int[] hash = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                hash[nums[i]]++;
            }
            int m = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash[nums[i]] == 1)
                {
                    m += nums[i];
                }
            }
            return m;
    }
}