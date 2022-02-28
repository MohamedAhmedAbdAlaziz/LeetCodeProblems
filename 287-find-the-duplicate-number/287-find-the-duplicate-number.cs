public class Solution {
    public int FindDuplicate(int[] nums) {
        Dictionary<int, int> prevSu = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!prevSu.ContainsKey(nums[i]))
                {
                    prevSu[nums[i]] = 1;

                }
                else
                {
                    return nums[i];
                }
            }

            return -1;  
    }
}