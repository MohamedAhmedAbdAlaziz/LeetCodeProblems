public class Solution {
    public int FindUnsortedSubarray(int[] nums) {
        int[] ArrayCopy = new int[nums.Length];

          Array.Copy( nums,  ArrayCopy, nums.Length);
            Array.Sort(nums);
            int first = -1;
            int last = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (ArrayCopy[i] != nums[i])
                { first = i;
                    break;
                }
              }
            for (int i =nums.Length-1; i >= 0; i--)
            {
                if (ArrayCopy[i] != nums[i])
                {
                    last = i;
                    break;
                }
            }
            if (first == -1) return 0;
            if (last == nums.Length) return nums.Length - first;

            return last + 1 - first;
    }
}