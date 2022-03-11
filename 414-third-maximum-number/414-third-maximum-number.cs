public class Solution {
    public int ThirdMax(int[] nums) {
            Array.Sort(nums);

            int cout = 1, min = nums[nums.Length-1];
            for (int i = nums.Length-2; i >=0; i--)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    cout++;
                }
                if (cout == 3)
                {
                    return min;
                }
            }
            return nums[nums.Length-1];
    }
}