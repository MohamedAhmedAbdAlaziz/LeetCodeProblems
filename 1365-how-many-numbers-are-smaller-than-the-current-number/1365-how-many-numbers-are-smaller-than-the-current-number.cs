public class Solution {
    public int[] SmallerNumbersThanCurrent(int[] nums) {
          int[] kids = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if(nums[i]> nums[j])
                    {
                        k++;
                    }

                }
                kids[i] = k;
            }
            return kids;
    }
}