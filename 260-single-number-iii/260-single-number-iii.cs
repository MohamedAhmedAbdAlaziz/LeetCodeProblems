public class Solution {
    public int[] SingleNumber(int[] nums) {
                  Dictionary<int, int> prevSu = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
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
   

            return prevSu.Where(x => x.Value == 1).Select(x => x.Key).ToArray();
      
    }
}