public class Solution {
    public int FindFinalValue(int[] nums, int original) {
           Dictionary<int, int> prevSum = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]%original == 0)
                {
                    prevSum[nums[i]] = nums[i] / original;
                }

            }
            int t = original;
            while(prevSum.ContainsKey(t))
            {
                  t *= 2;
             }

            return t;
    }
}