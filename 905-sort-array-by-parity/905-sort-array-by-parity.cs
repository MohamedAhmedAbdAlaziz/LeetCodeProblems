public class Solution {
    public int[] SortArrayByParity(int[] nums) {
          List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                  if (nums[i] % 2 != 0)
                    list.Add(nums[i]);
                else
                    list.Insert(0, nums[i]);
            }
            return list.ToArray();
    }
}