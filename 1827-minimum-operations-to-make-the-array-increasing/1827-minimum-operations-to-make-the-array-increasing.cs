public class Solution {
    public int MinOperations(int[] nums) {
          int t =nums[0];
            int count = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                if(t < nums[i])
                {
                    t = nums[i] ;
                }
                else
                {
                    count += t - nums[i]+1;
                    nums[i] = t + 1;
                    t = nums[i];
                }
            }

            return count;
    }
}