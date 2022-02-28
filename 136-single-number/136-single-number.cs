public class Solution {
    public int SingleNumber(int[] nums) {
              Dictionary<int, int> prevSu = new Dictionary<int, int>();
            for (int i = 0; i <nums.Length; i++)
            {
                if (!prevSu.ContainsKey(nums[i]))
                {
                    prevSu[nums[i]] = 1;

                }
                else
                {
                    prevSu[nums[i]] = prevSu[nums[i]] + 1;
                }
            }
        

            foreach (var item in prevSu)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return -1;
    }
}